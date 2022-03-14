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
//חלון יאפשר למשתמש לערוך שורה בטבלת ההזמנות
namespace FVPROJECT
{
    public partial class EditRowForm : Form
    {
        private MainForm mainForm;
        private Product product;
        public EditRowForm(MainForm mainForm,Product product)
        {
            this.product = product;
            this.mainForm = mainForm;
            InitializeComponent();
        }
        private void EditRowForm_Load(object sender, EventArgs e)
        {
            //על ידי פתיחת החלון המוכר רואה את הפרטים שרוצה לערוך
            textBoxName.Text = product.Name;
            numericUpDownPrice.Value = Convert.ToDecimal(product.Price);
        }
        //הכפתור עורך את השורה הסומנת בנתונים שהמוכר בחר
        private void buttonProductUpdate_Click(object sender, EventArgs e)
        {
            int rowIndex = this.mainForm.dataGridViewMainOrder.CurrentRow.Index;
            DataGridViewRow selected = this.mainForm.dataGridViewMainOrder.Rows[rowIndex];
            selected.Cells[1].Value = textBoxName.Text;
            selected.Cells[2].Value = numericUpDownPrice.Value;
            //חישוב המחיר הכולל כמות כפול המחיר
            selected.Cells[4].Value = Convert.ToDouble(numericUpDownPrice.Value) * Convert.ToDouble(selected.Cells[3].Value);
            this.Close();
        }

        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
