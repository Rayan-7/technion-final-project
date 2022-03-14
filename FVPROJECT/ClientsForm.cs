//Rayan Halabi
using FVPROJECT.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//החלון תפקידיו לנהל את הלקוחות , הוספה,עריכה, מחיקה
namespace FVPROJECT
{

    public partial class ClientsForm : Form
    {
        private DBSQL dataB;
        public ClientsForm()
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
        }
        

        private void ClientForm_Load(object sender, EventArgs e)
        {
            DataGridClientsFun();
        }
        //כפתור שמכניס לקוח חדש
        private void buttonInsertClient_Click(object sender, EventArgs e)
        {
            ClientInsertForm clientInsertForm = new ClientInsertForm(this);
            clientInsertForm.ShowDialog();
        }

        //פר" שממלא שמוציאה את הלוקוחות וממלא את הטבלה
        public void DataGridClientsFun()
        {
            dataGridViewClients.Rows.Clear();
            int countClients = dataB.CountClients();
            //רק אם יש נתונים התוכנה מעלה את הנתונים
            if (countClients > 0)
            {
                Client[] clients = new Client[countClients];

                clients = dataB.selectClients(textBoxSearchClient.Text);
                //לספור את התאים המלאים במערך
                countClients = clients.Count(s => s != null);
                dataGridViewClients.RowCount = countClients;
                //מילוי הטבלה
                GridFill(clients);
            }
        }


        private void textBoxSearchClient_TextChanged(object sender, EventArgs e)
        {
            DataGridClientsFun();
        }

        ///לחיצה על כפתור העריכה או המחיקה
        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex = e.RowIndex;
            if (e.ColumnIndex == dataGridViewClients.Columns["Edit"].Index)
            {
                EditRow(rowIndex);
            }
            if(e.ColumnIndex == dataGridViewClients.Columns["Delete"].Index)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את הלקוח הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DeleteRow(rowIndex);
                }
            }
        }

        private void dataGridViewClients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את הלקוח הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int rowIndex = dataGridViewClients.CurrentCell.OwningRow.Index;//לקבל את מספר השורה
                    DeleteRow(rowIndex);
                }
            }
        }
        //כפתור יציאה
        private void panelPrev_Click(object sender, EventArgs e)
        {
            dataGridViewClients.Rows.Clear();
            this.Close();
        }
        //עריכת שורה
        public void EditRow(int rowIndex)
        {
            DataGridViewRow selected = dataGridViewClients.Rows[rowIndex];
            Client client = new Client();
            client.IdNumber = selected.Cells[0].Value.ToString();
            client.Name = selected.Cells[1].Value.ToString();
            client.LastName = selected.Cells[2].Value.ToString();
            client.PhoneNumber = selected.Cells[3].Value.ToString();
            client.Address = selected.Cells[4].Value.ToString();
            client.Email = selected.Cells[5].Value.ToString();
            ClientEditForm clientEditForm = new ClientEditForm(this, client);
            clientEditForm.ShowDialog();
        }
        //מחיקת שורה
        public void DeleteRow(int rowIndex)
        {
            DataGridViewRow selected = dataGridViewClients.Rows[rowIndex];
            string clientId = selected.Cells[0].Value.ToString();
            dataB.DeleteClient(clientId);//מחיקה מהבסיס הנתונים
            dataGridViewClients.Rows.RemoveAt(rowIndex);
        }
        //פר" שממלא את הטבלה
        public void GridFill(Client [] clients)
        {
            int i=0;
            foreach (Client aclient in clients)
            {
                DataGridViewButtonCell buttonEditCell = new DataGridViewButtonCell();
                DataGridViewButtonCell buttonDeleteCell = new DataGridViewButtonCell();
                buttonEditCell.Value = "ערוך";
                buttonDeleteCell.Value = "מחק";
                dataGridViewClients[0, i].Value = aclient.IdNumber;
                dataGridViewClients[1, i].Value = aclient.Name;
                dataGridViewClients[2, i].Value = aclient.LastName;
                dataGridViewClients[3, i].Value = aclient.PhoneNumber;
                dataGridViewClients[4, i].Value = aclient.Address;
                dataGridViewClients[5, i].Value = aclient.Email;
                dataGridViewClients[6, i] = buttonEditCell;
                dataGridViewClients[7, i] = buttonDeleteCell;
                i++;
            }
        }
    }
}
