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
//חלון הכניסה בודק אם יש בכלל מנהל במערכת אם יש נכנס , אם אין מנהל מאפשר הרשמת מנהל ראשון וחדש
namespace FVPROJECT
{
    public partial class UserLoginForm : Form
    {
        private DBSQL dataB;
        public UserLoginForm()
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
        }
        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            // שיכול המוכר ללחוץ על המספרים במקלדת
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(UserLoginForm_KeyPress);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            int existManager;//אם קיים מנהל או לא

            existManager = dataB.CountManager();
            //לא קיים מנהל
            if (existManager == 0)
            {
                this.Hide();
                //אם לא קיים מנהל צריך להוסיף למערכת , פותח את החלון עם הערך 0 בגלל שזה מנהל
                UserInsertForm formInsertManager = new UserInsertForm(0, null, null);
                formInsertManager.ShowDialog();
                this.Show();
            }
            //קיים מנהל
            else
            {
                this.Hide();
                //אם קיים מנהל אז יכול להתחבר למערכת
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Show();
            }
        }

        //סוגר את התוכנית
        private void panelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //כפתור אינטר במקלדת
        private void UserLoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                buttonSignIn.PerformClick();
            }
        }

    }
}
