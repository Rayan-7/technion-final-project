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
using System.Net.Mail;
//חלון זה יפתח להקלדת סיסמא החדשה
namespace FVPROJECT
{
    public partial class RestPassForm : Form
    {
        private string userName;
        private DBSQL dataB;
        private ExternalFunctions exFuncs;
        public RestPassForm(string userName)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            this.userName = userName;
            InitializeComponent();
        }

        //כפתור האיפוס סיסמא
        private void buttonRestPass_Click(object sender, EventArgs e)
        {
            if(textBoxRestPassword.Text!="" && textBoxReRestPassword.Text!="")
            {
                if(textBoxRestPassword.Text==textBoxReRestPassword.Text)
                {
                    string password = exFuncs.ComputeSha256Hash(textBoxRestPassword.Text);
                    //מעדכן את הסטטוס של האיפוס
                    dataB.RestPassUser(userName, password);
                    MessageBox.Show("האיפוס התבצע בהצלחה", " Successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("שתי הסיסמאות לא זהות נסה שוב", "saving failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("עליך למלא את הכל הפריטים", "saving failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //יציאה
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
    }
}
