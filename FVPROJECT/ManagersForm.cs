//Rayan Halabi
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*החלון לניהול מנהלים הוספה , עריכה , מחיקה , אפוס סיסמא*/
namespace FVPROJECT
{
    public partial class ManagersForm : Form
    {
        private DBSQL dataB;
        private int rowIndex;
        private string userName;
        public ManagersForm(string userName)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.userName = userName;
        }
        //יציאה
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //הכנסת מנהל
        private void buttonManagerInsert1_Click(object sender, EventArgs e)
        {
            UserInsertForm userInsertForm = new UserInsertForm(0, null,this);
            userInsertForm.ShowDialog();
        }
        //למלא את הטבלה
        public void DataGridManagersFun()
        {
            int i = 0;
            dataGridViewManagers.Rows.Clear();
            int countManagers = dataB.CountManager(userName);
            //רק אם יש נתונים התוכנה מעלה את הנתונים
            if (countManagers > 0)
            {
                Manager[] managers = new Manager[countManagers];
                managers = dataB.SelectManagers(textBoxSearchManager.Text,userName);
                //לספור את התאים המלאים במערך
                countManagers = managers.Count(s => s != null);
                dataGridViewManagers.RowCount = countManagers;
                foreach (Manager aManager in managers)
                {
                    GridFillManagers(aManager,ref i);
                }
            }
        }
        private void GridFillManagers(Manager aManager,ref int i)
        {
            DataGridViewButtonCell buttonEditCell = new DataGridViewButtonCell();
            DataGridViewButtonCell buttonDeleteCell = new DataGridViewButtonCell();
            DataGridViewButtonCell buttonRestPassCell = new DataGridViewButtonCell();
            buttonEditCell.Value = "ערוך";
            buttonDeleteCell.Value = "מחק";
            buttonRestPassCell.Value = "איפוס סיסמא";
            dataGridViewManagers[0, i].Value = aManager.IdNumber;
            dataGridViewManagers[1, i].Value = aManager.Name;
            dataGridViewManagers[2, i].Value = aManager.LastName;
            dataGridViewManagers[3, i].Value = aManager.PhoneNumber;
            dataGridViewManagers[4, i].Value = aManager.Address;
            dataGridViewManagers[5, i].Value = aManager.Email;
            dataGridViewManagers[6, i].Value = aManager.UserName;
            dataGridViewManagers[7, i].Value = aManager.EntryDate;
            dataGridViewManagers[8, i] = buttonEditCell;
            dataGridViewManagers[9, i] = buttonDeleteCell;
            dataGridViewManagers[10, i] = buttonRestPassCell;
            i++;
        }
        //פתיחת חלון
        private void ManagersForm_Load(object sender, EventArgs e)
        {
            DataGridManagersFun();
        }
        //בחירת שורה
        private void dataGridViewManagers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            Manager manager = new Manager();
            if (e.ColumnIndex == dataGridViewManagers.Columns["Edit"].Index)
            {
                dataGridEdit(manager);
            }
            if (e.ColumnIndex == dataGridViewManagers.Columns["Delete"].Index)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את המנהל הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dataGridDelete();
                }
            }
            if (e.ColumnIndex == dataGridViewManagers.Columns["RestPass"].Index)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה לאפס את הסיסמא של המנהל הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dataGridRestPass();
                }
            }
        }
        //עריכת שורה
        private void dataGridEdit(Manager manager)
        {
            rowIndex = dataGridViewManagers.CurrentCell.OwningRow.Index;
            DataGridViewRow selected = dataGridViewManagers.Rows[rowIndex];
            manager.IdNumber = selected.Cells[0].Value.ToString();
            manager.Name = selected.Cells[1].Value.ToString();
            manager.LastName = selected.Cells[2].Value.ToString();
            manager.PhoneNumber = selected.Cells[3].Value.ToString();
            manager.Address = selected.Cells[4].Value.ToString();
            manager.Email = selected.Cells[5].Value.ToString();
            manager.UserName = selected.Cells[6].Value.ToString();
            SellerManagerEditForm sellerManagerEditForm = new SellerManagerEditForm(null, this, null, manager, 0);
            sellerManagerEditForm.ShowDialog();
        }
        //מחיקה
        private void dataGridDelete()
        {
            rowIndex = dataGridViewManagers.CurrentCell.OwningRow.Index;
            DataGridViewRow selected = dataGridViewManagers.Rows[rowIndex];
            string managerId = selected.Cells[0].Value.ToString();
            dataB.DeleteManager(managerId);//שינוי הסטטוס ללא פעיל מהבסיס הנתונים
            dataGridViewManagers.Rows.RemoveAt(rowIndex);
        }
        //איפוס סיסמא
        private void dataGridRestPass()
        {
            rowIndex = dataGridViewManagers.CurrentCell.OwningRow.Index;
            DataGridViewRow selected = dataGridViewManagers.Rows[rowIndex];
            string managerId = selected.Cells[0].Value.ToString();
            dataB.RestPassUserTrue(managerId);//שינוי הסטטוס לפעיל מהבסיס הנתונים
        }
        //לחיצה על כפתור מחיקה במקלדת מאפשרת גם מחיקה
        private void dataGridViewManagers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את המנהל הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    dataGridDelete();
                }
            }
        }
    }
}
