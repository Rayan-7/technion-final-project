using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

/*חלון להצגת שעות עבודה של מוכר מפרוטת
 */
namespace FVPROJECT
{
    public partial class WorkDetailsForm : Form
    {
        private string userId;
        private DBSQL dataB;
        private double total;
        private SendMail sendMail;
        private Seller seller;
        public WorkDetailsForm(string userId)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.userId = userId;
            this.seller = dataB.SelectSeller(userId);
            this.sendMail = new SendMail();
        }

        private void WorkDetailsForm_Load(object sender, EventArgs e)
        {
            //הצגת הטבלת השעות של העובד
            DataGridWorkFun();
            //סה"כ של שעות
            sumCol();
            ComboBoxLoad();
        }
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void DataGridWorkFun()
        {
            int i = 0;
            dataGridViewWorkHoursDetails.Rows.Clear();
            int countDetails = dataB.CountWorkDetails(userId);
            //רק אם יש נתונים התוכנה מעלה את הנתונים
            if (countDetails > 0)
            {
                Seller[] sellerData = new Seller[countDetails];
                sellerData = dataB.UserWorkDetails(userId);
                dataGridViewWorkHoursDetails.RowCount = sellerData.Length;
                foreach (Seller aSeller in sellerData)
                {
                    dataGridViewWorkHoursDetails[0, i].Value = aSeller.StartDay;
                    dataGridViewWorkHoursDetails[1, i].Value = aSeller.EndDay;
                    dataGridViewWorkHoursDetails[2, i].Value = aSeller.BusinessHours;
                    i++;
                }
            }
        }

        //פונקציה שמחשבת את הסכום הכללי של שעות עבודה
        public void sumCol()
        {
            this.total = 0;
            foreach (DataGridViewRow item in dataGridViewWorkHoursDetails.Rows)
            {
                if (item.Cells[2] != null && item.Cells[2].Value != null)
                {
                    this.total += Convert.ToDouble(item.Cells[2].Value);
                }
            }
            textBoxTotalWorkHours.Text = this.total.ToString("N3");
        }

        //כפתור השליחה
        private void buttonSendWorkHours_Click(object sender, EventArgs e)
        {
            bool success;
            //אם יש בכלל נתונים בטבלה
            if (dataGridViewWorkHoursDetails.Rows.Count > 0)
            {
                //בהמשתמש בחר קובץ ישן
                if (comboBoxFolders.SelectedIndex > 0)
                {
                    //להקפיץ חלון שהמשתמש יכול להקלד מייל ולשלוח אותו
                    SendMailMSG(comboBoxFolders.Text.Replace("/", "_"));
                }
                else
                {
                    BuildExcel();
                    //להקפיץ חלון שהמשתמש יכול להקלד מייל ולשלוח את הקובץ
                    SendMailMSG(DateTime.Now.ToString("dd_MM_yyyy"));

                
                }
              
            }
            else
                MessageBox.Show("אין לך נתונים בטבלה", "Excel file falied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
        //בניית קובץ אקסל
        public void BuildExcel()
        {
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            xlWorkBook=xcelApp.Application.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            //בניית הטבלה
            BuildExcelGrid(seller,xlWorkSheet);
            xlWorkSheet.Columns.AutoFit();
            //שם הקובץ:ת.ז - שם - תאריך
            var savepath = System.IO.Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "WorkingHours",
                seller.IdNumber+"-"+seller.Name+"-"+DateTime.Now.ToString("dd_MM_yyyy")+".xlsx");
            //שמירה
            xlWorkBook.SaveAs(savepath, Excel.XlFileFormat.xlOpenXMLWorkbook, 
                misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //סגירה
            xlWorkBook.Close(true, misValue, misValue);
            xcelApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xcelApp);
            //מחיקת שעות
            dataB.DeleteWorkHours(seller.IdNumber);
            //איפוס שעות העבודה
            dataB.businessHoursRest(seller.IdNumber);
        }
        //בניית הטבלה באקסל
        public void BuildExcelGrid(Seller seller,Excel.Worksheet xlWorkSheet)
        {
            //דחיפת בראש הדף שם של המוכר עם תעודת ת.ז וגם סכ"ה שעות עבודה
            xlWorkSheet.Cells[1, 1] = seller.IdNumber + "  " + seller.Name + " " + seller.LastName;
            xlWorkSheet.Cells[1, 2] = "סך הכל שעות עבודה";
            xlWorkSheet.Cells[2, 2] = total.ToString("N3");
            //העתקת הטבלה לקובץ אקסל
            for (int i = 1; i < dataGridViewWorkHoursDetails.Columns.Count + 1; i++)
            {
                xlWorkSheet.Cells[4, i] = dataGridViewWorkHoursDetails.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewWorkHoursDetails.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewWorkHoursDetails.Columns.Count; j++)
                {
                    xlWorkSheet.Cells[i + 5, j + 1] = dataGridViewWorkHoursDetails.Rows[i].Cells[j].Value.ToString();
                }
            }
        }
        //פונקציה לרענון הקבצים בטקסט
        public void ComboBoxLoad()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\WorkingHours";
            DirectoryInfo d = new DirectoryInfo(path);
            //להוציא את הקבצים הרלוונטים למשתמש הזה לפי קוד של משתמש
            FileInfo[] Files = d.GetFiles("*"+userId+"*");
            string str = "";
            foreach (FileInfo file in Files)
            {
                //שם של הקובץ
                str = file.Name;
                //טיפול במחרוזת : שיראה המשתמש רק את התאריך
                FileStrSplit(str);
            }
        }
        private void comboBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFolders.SelectedIndex > 0)
            {
                dataGridViewWorkHoursDetails.Rows.Clear();
                GetExcel(comboBoxFolders.Text.Replace("/","_"));
            }
            if(comboBoxFolders.SelectedIndex == 0)
            {
                DataGridWorkFun();
            }
        }
        //להעלות את הנתונים בקובץ שבחר המשתמש
        public void GetExcel(string FileDate)
        {
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            var savepath = System.IO.Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "WorkingHours", 
                userId+"-"+seller.Name+"-"+FileDate+".xlsx");
            xlWorkBook = xcelApp.Workbooks.Open(savepath, 0, true, 5, "", "", true,
                Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = xcelApp.Worksheets[1];
            int i = 5, j = 1;
            for (int k = 0; xlWorkSheet.Cells[i, j].Value != null; k++)
            {
                dataGridViewWorkHoursDetails.Rows.Add();
                dataGridViewWorkHoursDetails.Rows[k].Cells[0].Value = xlWorkSheet.Cells[i, j++].Value; 
                dataGridViewWorkHoursDetails.Rows[k].Cells[1].Value = xlWorkSheet.Cells[i, j++].Value; 
                dataGridViewWorkHoursDetails.Rows[k].Cells[2].Value = xlWorkSheet.Cells[i, j].Value;
                i++;
                j = 1;
            }
            xlWorkBook.Close(true, misValue, misValue);
            xcelApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xcelApp);
            //לסכום את השעות שבטבלה
            sumCol();
        }
        //פונקציה לטיפול במחרוזת שמוסיפה לקומבובוקס רק את התאריך
        public void FileStrSplit(string str)
        {
            string [] subStrings;
            //לחתוך אותו לחלקים
            subStrings = Regex.Split(str, "(-)");
            //מקום הארבע זה התאריך וסוג הקובץ :למחוק סוג הקובץ ולהחזיר אותו בפורמט יפה
            str = subStrings[4].Replace(".xlsx", "").Replace("_", "/");
            //להוסיף אותו
            comboBoxFolders.Items.Add(str);
        }
        
        public void SendMailMSG(string date)
        {
            bool success;
            //לא צריך לייצור את הקובץ רק לשלוח אותו
            string email = Interaction.InputBox("תקליד את המייל של הרואה חשבון", "Enter Email");
            if (IsValidEmail(email))
            {
                success = sendMail.SendEmailWorksHours(seller, email, date);
                
                if (success)
                {
                    MessageBox.Show("הקובץ נשלח בהצלחה", "The file was sent successfully", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("שליחת הקובץ נכשלה", "sending failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("עליף להקליד מייל תקין", "Error Mail syntax ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //פונקציה לבדיקה אם המייל תקין או לא
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
