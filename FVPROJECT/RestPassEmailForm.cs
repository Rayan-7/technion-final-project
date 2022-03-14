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
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace FVPROJECT
{

    public partial class RestPassEmailForm : Form
    {
        private DBSQL dataB;
        private SendMail sendMail;
        private ExternalFunctions exFuncs;
        public RestPassEmailForm()
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            sendMail = new SendMail();
            this.exFuncs = new ExternalFunctions();
        }
        //איפוס סיסמא
        private void buttonRestPass_Click(object sender, EventArgs e)
        {
            if (exFuncs.IsValidEmail(textBoxEmailPassword.Text))
            {
                bool exist;
                Random rnd = new Random();
                string password = Convert.ToString(rnd.Next(10000, 100000));//להגריל מספר בן 5 ספרות
                string realPassword=password;//לשמור את סיסמא המקורית בגלל לשלוח אותה למשתמש במייל
                password = exFuncs.ComputeSha256Hash(password);//הצפנת הסיסמא
                exist=dataB.RestPassUserEmail(textBoxEmailPassword.Text, password);//הכנסת הסיסמא למערכת
                if (exist)
                { 
                    if (sendMail.SendEmailRestPass(realPassword,textBoxEmailPassword.Text))//שליחת הסיסמא למשתמש
                        MessageBox.Show("שליחת הסיסמא הראשונית התבצעה בהצלחה", "password send", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("שליחת הסיסמא נכשלה");
                    this.Close();
                }
                else
                    MessageBox.Show("הדואר האלקטרוני לא קיים במערכת", "sending failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("הדואר האלקטרוני לא תקין", " Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //יציאה
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
