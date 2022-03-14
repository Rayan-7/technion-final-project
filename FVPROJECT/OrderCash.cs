//Rayan Halabi
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*חלון יפתח אחרי שהמוכר לוחץ על כפתור מזומן שזה יאפשר מילוי פרטי הלקוח*/
namespace FVPROJECT
{
    public partial class OrderCash : Form
    {
        private DBSQL dataB;
        public string[] clientsDetails;//כשהמשתמש ממלא את הפרטים ממלים אותם במערך גלובלי בגלל שנשתמש בהם בפורם אחר
        public bool payNowClick;//  אם המשתמש לחץ על הכפתור שלם עכשיו
        private double totalPrice;
        private int countClients;
        public OrderCash(double totalPrice)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            clientsDetails = new string[4];
            this.totalPrice = totalPrice;
            this.payNowClick = false;
        }

        //כשהדף הזה טוען מעלה את ת.ז של כל הלקוחות
        private void OrderCash_Load(object sender, EventArgs e)
        {
            comboBoxClientId.Items.Clear();
            this.countClients = dataB.CountClients();
            Client[] clients = new Client[this.countClients];

            clients = dataB.SelectClientsIdName();
            
            for (int i = 0; i < this.countClients; i++)
            {
                comboBoxClientId.Items.Add(clients[i].IdNumber+" - "+clients[i].Name);
            }

        }
        //כשהמוכר מבצע הזמנה אם הוא בחר ת.ז שהיא קיימת במערכת מעלה אוטומטית את השם ושם המשפחה של הלקוח
        private void comboBoxClientId_TextChanged(object sender, EventArgs e)
        {
            string id=comboBoxClientId.Text.Substring(0, comboBoxClientId.Text.IndexOf(" ") + 1);
            
            Client client = new Client();
            client = dataB.selectClientsSearchId(id);
            textBoxName.Text = client.Name;
            textBoxLastName.Text = client.LastName;
        }
        //כשהמשתמש לוחץ על הכפתור מתמלא המערך בפרטי הלקוח וכמה הוא שלם
        private void buttonPayNow_Click(object sender, EventArgs e)
        {
            if (comboBoxClientId.Text != "" || textBoxName.Text != "" || textBoxLastName.Text != "")
            {
                if (Convert.ToDouble(numericUpDownCash.Value) >= totalPrice)
                {
                    clientsDetails[0] = comboBoxClientId.Text.Substring(0, comboBoxClientId.Text.IndexOf(" ") + 1);
                    clientsDetails[1] = textBoxName.Text;
                    clientsDetails[2] = textBoxLastName.Text;
                    clientsDetails[3] = Convert.ToString(numericUpDownCash.Value);
                    this.payNowClick = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("הלקוח חייב לשלם את הכסף שרשום", " Order Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("עליך למלא את כל הפרטים", " Order Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //יציאה
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
