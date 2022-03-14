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
/*החלון זה יופעל אחרי כניסת המשתמש למערכת וכך הוא יכול לכנס לדף הרלוונטי שלו,מנהל או מוכר
עם שם משתמש שזה מייל או שם משתמש,וסיסמה*/
namespace FVPROJECT
{
    public partial class LoginForm : Form
    {
        private DBSQL dataB;
        public LoginForm()
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //הפעלת שיכול המוכר ללחוץ על המספרים במקלדת
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(LoginForm_KeyPress);
        }
        //לחיצה על כפתור הכניסה
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool exist;
            string userName=textBoxUserName.Text;
            string password = ComputeSha256Hash(textBoxPassword.Text);
            //לבדוק אם קיים המשתמש
            exist=dataB.Login(userName, password);
            //אם המשתמש קיים במערכת
            if(exist)
            {
                this.Hide();
                //בדיקה אם צריך לעדכן את הסיסמא או לא
                exist = dataB.RestPassCheckTorFUser(userName);
                //אם צריך לעדכן סיסמא
                if (exist)
                {
                    RestPassForm restPassForm = new RestPassForm(userName);
                    restPassForm.ShowDialog();
                }
                else
                {
                    FormOpen(userName);
                }
            }
                //אם המשתמש לא קיים במערכת
            else
            {
                MessageBox.Show("שם משתמש או סיסמא שגויים", " Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void FormOpen(string userName)
        {
            bool managerOrSeller;
            managerOrSeller = dataB.CheckManager(userName);
            //מנהל
            if (managerOrSeller == true)
            {
                ManagerForm managerForm = new ManagerForm(userName);
                managerForm.ShowDialog();
            }
            managerOrSeller = dataB.CheckSeller(userName);
            //מוכר
            if (managerOrSeller == true)
            {
                MainForm mainForm = new MainForm(userName);
                mainForm.ShowDialog();
            }
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //לחיצה על הלינק של שכיחת תאפשרת פתיחת חלון לאיפוס סיסמא
        private void linkLabelRestPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RestPassEmailForm formRestPassMessage = new RestPassEmailForm();
            formRestPassMessage.ShowDialog();
        }
        
        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(Char)Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

    }
}
