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
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Net.Mail;
/*הוספת משתמש חדש*/

namespace FVPROJECT
{
    public partial class UserInsertForm : Form
    {
        private DBSQL dataB;
        //מנהל-0
        //1-מוכר
        private int managerOrSeller;
        private SellersForm SellersForm;
        private ManagersForm managersForm;
        private SendMail sendMail;
        private ExternalFunctions exFuncs;
        public UserInsertForm(int managerOrSeller,SellersForm sellerForm,ManagersForm managersForm)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.managerOrSeller = managerOrSeller;
            this.SellersForm = sellerForm;
            this.managersForm = managersForm;
            sendMail = new SendMail();
            exFuncs = new ExternalFunctions();
        }

        private void UserInsertForm_Load(object sender, EventArgs e)
        {
            //כשנפתח החלון מעלה באופן אוטומטי את הערים שיש במדינה
            comboBoxUserAddress.Items.Clear();
            int countCities = dataB.CountCities();
            string[] cities = new string[countCities];

            cities = dataB.SelectCitiesNames();

            for (int i = 0; i < countCities; i++)
            {
                comboBoxUserAddress.Items.Add(cities[i]);
            }
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם אתה בטוח שאתה רוצה לשמור את נתונים אלה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //בודק אם יש אחת מהטקסטים ריק אם כן מדפיס הודעה מתאימה
                if (textBoxUserId.Text == "" || textBoxUserRName.Text == "" || textBoxUserLastName.Text == "" || textBoxUserPhoneNumber.Text == "" ||
                    comboBoxUserAddress.Text == "" || textBoxUserEmail.Text == "" || textBoxUserName.Text == "" || textBoxUserPassword.Text == "" || textBoxUserRePassword.Text == "")
                    MessageBox.Show("עליך למלא את כל הפרטים", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    //אם זה אפס אז להכניס מנהל למערכת
                    if (managerOrSeller == 0)
                        //בדיקה: אם המייל תקין
                        if (exFuncs.IsValidEmail(textBoxUserEmail.Text))
                            ManagerInsert();
                        else
                            MessageBox.Show("הדואר האלקטרוני לא תקין", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //אם לא אז להוסיף מוכר
                    else
                        //בדיקה: אם המייל תקין
                        if (exFuncs.IsValidEmail(textBoxUserEmail.Text))
                        {
                            //אם השתי סיסמאות זהות
                            if (textBoxUserPassword.Text == textBoxUserRePassword.Text)
                                SellerInsert();
                            else
                                MessageBox.Show("שתי הסיסמאות לא זהות", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("הדואר האלקטרוני לא תקין", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ManagerInsert()
        {
            bool exists = false;
            //אם השתי סיסמאות זהות
            if (textBoxUserPassword.Text == textBoxUserRePassword.Text)
            {
                //מכניס את הנתונים של המנהל למערכת
                Manager manager = new Manager();
                manager.IdNumber = textBoxUserId.Text;
                manager.Name = textBoxUserRName.Text;
                manager.LastName = textBoxUserLastName.Text;
                manager.PhoneNumber = textBoxUserPhoneNumber.Text;
                manager.Address = comboBoxUserAddress.Text;
                manager.Email = textBoxUserEmail.Text;
                manager.UserName = textBoxUserName.Text;
                manager.Password = exFuncs.ComputeSha256Hash(textBoxUserPassword.Text);
                manager.EntryDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                exists=dataB.InsertManager(manager);
                if (exists)
                {
                    MessageBox.Show("המנהל נשמר בהצלחה", " Successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //שליחת מייל
                    sendMail.SendEmailUserInsert(manager, null, 0, textBoxUserPassword.Text);
                    managersForm.DataGridManagersFun();
                }
                else
                    MessageBox.Show("המשתמש קיים בהצלחה", "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //נקה את הטקסטים
                TextsClear();
            }
            else
                MessageBox.Show("שתי הסיסמאות לא זהות", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void SellerInsert()
        {
            bool exist = false;
            //מכניס את הנתונים של המוכר למערכת
            Seller seller = new Seller();
            seller.IdNumber = textBoxUserId.Text;
            seller.Name = textBoxUserRName.Text;
            seller.LastName = textBoxUserLastName.Text;
            seller.PhoneNumber = textBoxUserPhoneNumber.Text;
            seller.Address = comboBoxUserAddress.Text;
            seller.Email = textBoxUserEmail.Text;
            seller.UserName = textBoxUserName.Text;
            seller.Password = exFuncs.ComputeSha256Hash(textBoxUserPassword.Text);
            seller.EntryDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
            exist = dataB.InsertSeller(seller);
            if (exist)
            {
                MessageBox.Show("המשתמש נשמר בהצלחה", " Successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //שליחת מייל למוכר
                sendMail.SendEmailUserInsert(null, seller, 1, textBoxUserPassword.Text);
                //העלאת המשתמשים מחדש
                SellersForm.DataGridSellersFun();
                TextsClear();
            }
            else
                MessageBox.Show("השם המשתמש או הדואר האלקטרוני או מספר הטלפון קיימים במערכת", "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        //מספר הת.ז מורכב : ממספרים
        private void textBoxUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsNumber(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }

        //מספר טלפון מורכב ממספרים
        private void textBoxUserPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsNumber(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }

        // שם של המשתמש מורכב רק מהאותיות
        private void textBoxUserRName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsLetter(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }
        //שם המשפחה של המשתמש מורכב רק מהאותיות
        private void textBoxUserLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsLetter(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }

        //שם משתמש מורכב : מאותיות באנגלית ומספרים
        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsNumber(ch)) && (ch != 8) && (ch != 32) && !Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z]+$"))
            {
                e.Handled = true;
            }
        }

        //ניקוי הטקסטים
        private void TextsClear()
        {
            textBoxUserId.Clear();
            textBoxUserRName.Clear();
            textBoxUserLastName.Clear();
            textBoxUserPhoneNumber.Clear();
            comboBoxUserAddress.Text = "";
            textBoxUserEmail.Clear();
            textBoxUserName.Clear();
            textBoxUserPassword.Clear();
            textBoxUserRePassword.Clear();
        }
       
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
