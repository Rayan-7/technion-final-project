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
//חלון לספקים, חלון זה יציג את כל הספקים ויאפשר ניהול:הוספה,מחיקה,עריכה
namespace FVPROJECT
{
    public partial class SuppliersForm : Form
    {
        private DBSQL dataB;
        private int rowIndex;
        public SuppliersForm()
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
        }
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            DataGridSuppliersFun();
        }

        private void buttonInsertSupplier1_Click(object sender, EventArgs e)
        {
            SupplierInsertForm supplierInsertForm = new SupplierInsertForm(this);
            supplierInsertForm.ShowDialog();
        }

      
        //כפתור יציאה של הפורם מנקה את הנתונים שלא יעמיס על תוכנה ויוצא
        private void buttonExitSupplierForm_Click(object sender, EventArgs e)
        {
            dataGridViewSuppliers.Rows.Clear();
            this.Close();
        }

        private void textBoxSearchProducts_TextChanged(object sender, EventArgs e)
        {
            DataGridSuppliersFun();
        }
        public void DataGridSuppliersFun()
        {
            int i = 0;
            dataGridViewSuppliers.Rows.Clear();
            int countSuppliers = dataB.CountSuppliers();
            Supplier[] suppliers = new Supplier[countSuppliers];
            //רק אם יש נתונים התוכנה מעלה את הנתונים
            if (countSuppliers > 0)
            {
                suppliers = dataB.SelectSuppliers(textBoxSearchProducts.Text);
                //לספור את התאים המלאים במערך
                countSuppliers = suppliers.Count(s => s != null);
                dataGridViewSuppliers.RowCount = countSuppliers;
                foreach (Supplier aSupplier in suppliers)
                {
                    dataGridFill(aSupplier,ref i);
                }
            }
        }
        private void dataGridFill(Supplier aSupplier,ref int i)
        {
            DataGridViewButtonCell buttonEditCell = new DataGridViewButtonCell();
            DataGridViewButtonCell buttonDeleteCell = new DataGridViewButtonCell();
            buttonEditCell.Value = "ערוך";
            buttonDeleteCell.Value = "מחק";
            dataGridViewSuppliers[0, i].Value = aSupplier.Id;
            dataGridViewSuppliers[1, i].Value = aSupplier.Name;
            dataGridViewSuppliers[2, i].Value = aSupplier.PhoneNumber;
            dataGridViewSuppliers[3, i].Value = aSupplier.ContactName;
            dataGridViewSuppliers[4, i].Value = aSupplier.Address;
            dataGridViewSuppliers[5, i].Value = aSupplier.Email;
            dataGridViewSuppliers[6, i] = buttonEditCell;
            dataGridViewSuppliers[7, i++] = buttonDeleteCell;
        }
        //בחירת שורה
        private void dataGridViewSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            //ליצה על הכפתור העריכה
            if (e.ColumnIndex == dataGridViewSuppliers.Columns["Edit"].Index)
            {
                SupplierEdit();
            }
            if (e.ColumnIndex == dataGridViewSuppliers.Columns["Delete"].Index)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את הספק הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SupplierDelete();
                }
            }
        }
        //עריכת ספק
        private void SupplierEdit()
        {
            Supplier supplier = new Supplier();
            rowIndex = dataGridViewSuppliers.CurrentCell.OwningRow.Index;
            DataGridViewRow selected = dataGridViewSuppliers.Rows[rowIndex];
            supplier.Id = selected.Cells[0].Value.ToString();
            supplier.Name = selected.Cells[1].Value.ToString();
            supplier.PhoneNumber = selected.Cells[2].Value.ToString();
            supplier.ContactName = selected.Cells[3].Value.ToString();
            supplier.Address = selected.Cells[4].Value.ToString();
            supplier.Email = selected.Cells[5].Value.ToString();
            SupplierEditForm supplierEditForm = new SupplierEditForm(this, supplier);
            supplierEditForm.ShowDialog();
        }
        private void SupplierDelete()
        {
            rowIndex = dataGridViewSuppliers.CurrentCell.OwningRow.Index;
            DataGridViewRow selected = dataGridViewSuppliers.Rows[rowIndex];
            string supplierId = selected.Cells[0].Value.ToString();
            dataB.DeleteSupplier(supplierId);//מחיקה מהבסיס הנתונים
            dataGridViewSuppliers.Rows.RemoveAt(rowIndex);
        }
        //כלוחצים על כפתור המחיקה גם מוחק
        private void dataGridViewSuppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את הספק הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SupplierDelete();
                }
            }
        }
        //כפתור סגירת המסך
        private void panelPrev_Click(object sender, EventArgs e)
        {
            dataGridViewSuppliers.Rows.Clear();
            this.Close();
        }
    }
}
