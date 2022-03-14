//Rayan Halabi
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Excel = Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using Microsoft.VisualBasic;
using System.IO;
//אחרי לחיצה על הכפתור על ידי המנהל יפתח החלון הזה לניהול מוכרים
namespace FVPROJECT
{
    public partial class SellersForm : Form
    {
        private DBSQL dataB;
        private int rowIndex;
        public bool flag = false;
        public SellersForm()
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
        }



        private void SellersForm_Load(object sender, EventArgs e)
        {
            DataGridSellersFun();
        }

        //פרוצודורה להעלאת כל המוכרים הרלוונטים
        public void DataGridSellersFun()
        {
            dataGridViewSellers.Rows.Clear();
            int countSellers = dataB.CountSellers();
            //רק אם יש נתונים התוכנה מעלה את הנתונים
            if (countSellers > 0)
            {
                Seller[] sellers = new Seller[countSellers];

                sellers = dataB.SelectSellers(textBoxSearchSellers.Text);
                //לספור את התאים המלאים במערך
                countSellers = sellers.Count(s => s != null);
                dataGridViewSellers.RowCount = countSellers;
                dataGridFill(sellers);
            }
        }
        private void dataGridFill(Seller[] sellers)
        {
            int i = 0;
            foreach (Seller aSeller in sellers)
            {
                DataGridViewButtonCell buttonEditCell = new DataGridViewButtonCell();
                DataGridViewButtonCell buttonDeleteCell = new DataGridViewButtonCell();
                DataGridViewButtonCell buttonRestPassCell = new DataGridViewButtonCell();
                buttonEditCell.Value = "ערוך";
                buttonDeleteCell.Value = "מחק";
                buttonRestPassCell.Value = "איפוס סיסמא";
                dataGridViewSellers[0, i].Value = aSeller.IdNumber;
                dataGridViewSellers[1, i].Value = aSeller.Name;
                dataGridViewSellers[2, i].Value = aSeller.LastName;
                dataGridViewSellers[3, i].Value = aSeller.PhoneNumber;
                dataGridViewSellers[4, i].Value = aSeller.Address;
                dataGridViewSellers[5, i].Value = aSeller.Email;
                dataGridViewSellers[6, i].Value = aSeller.UserName;
                dataGridViewSellers[7, i].Value = aSeller.EntryDate;
                dataGridViewSellers[8, i].Value = aSeller.BusinessHours;
                dataGridViewSellers[9, i] = buttonEditCell;
                dataGridViewSellers[10, i] = buttonDeleteCell;
                dataGridViewSellers[11, i++] = buttonRestPassCell;
            }
        }
        //בחירת שורה
        private void dataGridViewSellers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            rowIndex = e.RowIndex;
            Seller seller = new Seller();
            if (e.ColumnIndex == dataGridViewSellers.Columns["Edit"].Index)
            {
                EditRow(seller, rowIndex);
            }
            else if (e.ColumnIndex == dataGridViewSellers.Columns["Delete"].Index)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את המוכר הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteRow(seller, rowIndex);
                }
            }
            else if (e.ColumnIndex == dataGridViewSellers.Columns["PassReset"].Index)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה לאפס את הסיסמא של המוכר הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    RestPass(seller, rowIndex);
                }
            }
            else if(e.ColumnIndex!=12)
            {
                SelectRow(seller, rowIndex);
            }
        }

        private void panelPrev_Click(object sender, EventArgs e)
        {
            dataGridViewSellers.Rows.Clear();
            this.Close();
        }

        private void buttonSearchSellers_Click(object sender, EventArgs e)
        {
            DataGridSellersFun();
        }

        //מחיקת מוכר על ידי לחיצה על כפתור המחיקה במקלדת
        private void dataGridViewSellers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את המוכר הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int rowIndex;
                    rowIndex = dataGridViewSellers.CurrentCell.OwningRow.Index;//לקבל את מספר השורה
                    DataGridViewRow selected = dataGridViewSellers.Rows[rowIndex];
                    string sellerId = selected.Cells[0].Value.ToString();
                    dataB.DeleteSeller(sellerId);//מחיקה מהבסיס הנתונים
                    dataGridViewSellers.Rows.RemoveAt(rowIndex);
                }
            }
        }
        //שליחת שעות
        private void buttonSendHours_Click(object sender, EventArgs e)
        {

            bool checkExist = CheckCheckBox();
            if(checkExist)
            {
                string email = Interaction.InputBox("תקליד את המייל של הרואה חשבון", "Enter Email");
                if (IsValidEmail(email))
                {
                    chkSellers_CheckedChanged(email);
                }
                else
                    MessageBox.Show("עליף להקליד מייל תקין", "Error Mail syntax ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("עליך לסמן איזה שהוא מוכר שעבד ,שמספר השעות עבודה שלו גדול מ0",
                    "ordering filed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //פרוצודרה שמטפלת בתיבת סימון שכל שורה שמסומנת שישמרו את הפרטים לכל מוכר ושולחת אותם 
        private void chkSellers_CheckedChanged(string email)
        {

            List<Seller> sellers = new List<Seller>();
            foreach (DataGridViewRow row in dataGridViewSellers.Rows)
            {
                if (row.Cells[12].Value != null && (bool)row.Cells[12].Value)
                {
                    Seller seller = new Seller();
                    seller.IdNumber = row.Cells[0].Value.ToString();
                    seller.Name = row.Cells[1].Value.ToString();
                    seller.LastName = row.Cells[2].Value.ToString();
                    sellers.Add(seller);
                }

            }
            BuildExcel(sellers,email);
        }
        //
        private void BuildExcel(List<Seller> sellers,string email)
        {
           
            foreach (Seller seller in sellers)
            {
                WorkDetailsForm workDetailsForm = new WorkDetailsForm(seller.IdNumber);
                workDetailsForm.DataGridWorkFun();
                workDetailsForm.sumCol();
                workDetailsForm.BuildExcel();
            }
            FilesSearch(email);

        }



        //לבדוק אם המשתמש בחר
        private bool CheckCheckBox()
        {
          foreach (DataGridViewRow row in dataGridViewSellers.Rows)
          {
             if (row.Cells[12].Value != null && (bool)row.Cells[12].Value)
             {
                //לבדוק אם בחר גם מוכר שמספר השעות שלו גדול מ0
                if(Convert.ToDouble(row.Cells[8].Value) > 0)
                  return true;
             }

          }
            return false;
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
        public void FilesSearch(string email)
        {
            SendMail sendMail = new SendMail();
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\WorkingHours";
            DirectoryInfo d = new DirectoryInfo(path);
            //להוציא את הקבצים הרלוונטים למשתמש הזה לפי קוד של משתמש
            FileInfo[] files = d.GetFiles("*" + DateTime.Now.ToString("dd_MM_yyyy") + "*");
            bool success = sendMail.SendEmailAllFiles(files, email);
            if (success)
            {
                MessageBox.Show("הקבצים נשלחו בהצלחה", "The file was sent successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CheckBoxClear();
            }
            else
                MessageBox.Show("שליחת הקבצים נשלחה", "sending failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //פונקציות למניעת הרבה שורות
        public void EditRow(Seller seller, int rowIndex)
        {
            DataGridViewRow selected = dataGridViewSellers.Rows[rowIndex];
            seller.IdNumber = selected.Cells[0].Value.ToString();
            seller.Name = selected.Cells[1].Value.ToString();
            seller.LastName = selected.Cells[2].Value.ToString();
            seller.PhoneNumber = selected.Cells[3].Value.ToString();
            seller.Address = selected.Cells[4].Value.ToString();
            seller.Email = selected.Cells[5].Value.ToString();
            seller.UserName = selected.Cells[6].Value.ToString();
            SellerManagerEditForm sellerManagerEditForm = new SellerManagerEditForm(this, null, seller, null, 1);
            sellerManagerEditForm.ShowDialog();
        }
        public void DeleteRow(Seller seller, int rowIndex)
        {
            DataGridViewRow selected = dataGridViewSellers.Rows[rowIndex];
            string sellerId = selected.Cells[0].Value.ToString();
            dataB.DeleteSeller(sellerId);//שינוי הסטטוס ללא פעיל מהבסיס הנתונים
            dataGridViewSellers.Rows.RemoveAt(rowIndex);
        }
        public void RestPass(Seller seller, int rowIndex)
        {
            DataGridViewRow selected = dataGridViewSellers.Rows[rowIndex];
            string sellerId = selected.Cells[0].Value.ToString();
            dataB.RestPassUserTrue(sellerId);//שינוי הסטטוס לפעיל מהבסיס הנתונים
        }
        public void SelectRow(Seller seller, int rowIndex)
        {
            rowIndex = dataGridViewSellers.CurrentCell.OwningRow.Index;//לקבל את מספר השורה
            DataGridViewRow selected = dataGridViewSellers.Rows[rowIndex];
            string sellerId = Convert.ToString(selected.Cells[0].Value);
            if (sellerId != "")
            {
                bool trying = false;
                while (!trying)
                {
                    try
                    {
                        WorkDetailsForm workDetailsForm = new WorkDetailsForm(sellerId);
                        workDetailsForm.ShowDialog();
                        trying = true;
                    }
                    catch
                    {

                    }
                }
                //עדכון הטבלה יכול להיות שעודכנו השעות העבודה של המוכרים
                DataGridSellersFun();
            }
        }
        public void CheckBoxClear()
        {
            //אחרי ההזמנה צריך לרקן את התאי סימון
            foreach (DataGridViewRow row in dataGridViewSellers.Rows)
            {
                if (row.Cells[12].Value != null && (bool)row.Cells[12].Value)
                {
                    row.Cells[12].Value = false;
                }
            }
        }
        //לחיצה על הכפתור
        private void buttonSellerInsert_Click(object sender, EventArgs e)
        {
            UserInsertForm userInsertForm = new UserInsertForm(1, this, null);
        }
    }
}



