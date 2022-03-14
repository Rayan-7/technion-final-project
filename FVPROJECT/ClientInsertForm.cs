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
//כאשר המשתמש בוחר להוסיף לקוח חדש החלון הזה יפתח
namespace FVPROJECT
{
    public partial class ClientInsertForm : Form
    {
        private DBSQL dataB;
        ClientsForm clientsForm;
        ExternalFunctions exFuncs;
        public ClientInsertForm(ClientsForm clientsForm)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.clientsForm = clientsForm;
            exFuncs = new ExternalFunctions();
        }
        
        private void ClientInsertForm_Load(object sender, EventArgs e)
        {
            comboBoxClientAddress.Items.Clear();
            int countCities = dataB.CountCities();
            string[] cities = new string[countCities];

            cities = dataB.SelectCitiesNames();

            for (int i = 0; i < countCities; i++)
            {
                comboBoxClientAddress.Items.Add(cities[i]);
            }
        }
        //לחיצה על כפתור הוספת לקוח חדש מאפשרת הוספתיו
        private void buttonInsertClient_Click(object sender, EventArgs e)
        {
            bool exists;
            if (MessageBox.Show("?האם אתה בטוח שאתה רוצה לשמור את נתונים אלה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {


                if ((textBoxClientId.Text == "") || (textBoxClientName.Text == "") || (textBoxClientLastName.Text == "") || (textBoxClientPhoneNumber.Text == "") ||
                    (comboBoxClientAddress.Text=="")|| (textBoxClientEmail.Text==""))
                {
                    MessageBox.Show("עליך למלא את כל הפרטים", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //בדיקה : אם המייל תקין או לא אם כן מכניס את הלקוח חדש למערכת
                    if (exFuncs.IsValidEmail(textBoxClientEmail.Text))
                    {
                        //הכנסת לקוח חדש
                        ClientInsert();
                    }
                    else
                    {
                        MessageBox.Show("עליך לרשום מייל תקין", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //מספר טלפון מורכב מספרות
        private void textBoxClientPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsNumber(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }


        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //הכנסת לקוח חדש
        public void ClientInsert()
        {
            bool exists;
            Client client = new Client();
            client.IdNumber = textBoxClientId.Text;
            client.Name = textBoxClientName.Text;
            client.LastName = textBoxClientLastName.Text;
            client.PhoneNumber = textBoxClientPhoneNumber.Text;
            client.Address = comboBoxClientAddress.Text;
            client.Email = textBoxClientEmail.Text;
            exists = dataB.InsertClient(client);
            if (exists)
            {
                clientsForm.DataGridClientsFun();//עדכון טבלה
                MessageBox.Show("הלקוח נשמר בהצלחה", " Successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ////אחרי קליטת הלקוח למערכת יש לנקות הטקסטים
                ClearTexts();
            }
            else
            {
                MessageBox.Show("הלקוח קיים במערכת", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //פרו" שמנקה את הטקסטים
        public void ClearTexts()
        {
            textBoxClientId.Clear();
            textBoxClientName.Clear();
            textBoxClientLastName.Clear();
            textBoxClientPhoneNumber.Clear();
            comboBoxClientAddress.Text = "";
            textBoxClientEmail.Clear();
        }
    }
}
