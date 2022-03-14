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
//חלון לעריכת לקוח אחרי לחיצה על כפתור העריכה יוקפץ החלון הזה ויאפשר עריכת לקוח
namespace FVPROJECT
{
    public partial class ClientEditForm : Form
    {
        private DBSQL dataB;
        ClientsForm clientsForm;
        Client client=new Client();
        ExternalFunctions exFuncs;
        public ClientEditForm(ClientsForm clientsForm, Client client)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.client = client;
            this.clientsForm = clientsForm;
            exFuncs=new ExternalFunctions();
        }

        //אחרי פתיחת החלון רואים את כל המדינות במדינה שמשתמש יוכל לבחור ואת הפרטים הישנים שידע איזה פריטים היו
        private void ClientEditForm_Load(object sender, EventArgs e)
        {
            comboBoxClientAddress.Items.Clear();
            int countCities = dataB.CountCities();
            string[] cities = new string[countCities];

            cities = dataB.SelectCitiesNames();

            for (int i = 0; i < countCities; i++)
            {
                comboBoxClientAddress.Items.Add(cities[i]);
            }
            //פרטים ישנים
            textBoxClientId.Text = client.IdNumber;
            textBoxClientName.Text = client.Name;
            textBoxClientLastName.Text = client.LastName;
            textBoxClientPhoneNumber.Text = client.PhoneNumber;
            comboBoxClientAddress.Text = client.Address;
            textBoxClientEmail.Text = client.Email;
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם אתה בטוח שאתה רוצה לשמור את נתונים אלה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if ((textBoxClientId.Text == "") || (textBoxClientName.Text == "") || (textBoxClientLastName.Text == "") || (textBoxClientPhoneNumber.Text == "") ||
                    (comboBoxClientAddress.Text == "") || (textBoxClientEmail.Text == ""))
                {
                    MessageBox.Show("עליך למלא את כל הפרטים", " Updating failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //בדיקה : אם המייל תקין או לא אם כן מעדכן את הלקוח שבמערכת
                    if (exFuncs.IsValidEmail(textBoxClientEmail.Text))
                    {
                        ClientUpdate();
                    }
                    else
                    {
                        MessageBox.Show("עליך לרשום מייל תקין", " Updating failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //עדכון לקוח 
        public void ClientUpdate()
        {
            bool exist;
            //הכנסת הנתונים ל בסיס הנתונים
            client.IdNumber = textBoxClientId.Text;
            client.Name = textBoxClientName.Text;
            client.LastName = textBoxClientLastName.Text;
            client.PhoneNumber = textBoxClientPhoneNumber.Text;
            client.Address = comboBoxClientAddress.Text;
            client.Email = textBoxClientEmail.Text;
            exist = dataB.UpdateClient(client);
            if (exist)
            {
                MessageBox.Show("הלקוח עודכן בהצלחה", " Successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clientsForm.DataGridClientsFun();
                this.Close();
            }
            else
            {
                MessageBox.Show("הלקוח קיים במערכת", "updating failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
