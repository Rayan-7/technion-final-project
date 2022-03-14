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
//מחלקה הזאת לניהול קטגוריות הוספה,מחיקה,שינוי צבע
namespace FVPROJECT
{
    public partial class TypesForm : Form
    {
        private DBSQL dataB;
        public TypesForm()
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
        }

        private void TypesForm_Load(object sender, EventArgs e)
        {
            DataGridTypesFun();
        }
        //כפתור ההוספה מבצע הוספת סוג חדש במערכת אם השם של הסוג לא קיים
        private void buttonInsertType_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם אתה בטוח שאתה רוצה לשמור את נתונים אלה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (textBoxTypeName.Text == "")
                    MessageBox.Show("עליך למלא את שם הסוג שאתה מעוניין להוסיף למערכת", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    InsertType();
                }
            }
        }
        //הכנסת הקטגוריות
        private void InsertType()
        {
            bool exists=false;
            Type type = new Type();
            int countTypes = dataB.CountTypes();
            type.Name = textBoxTypeName.Text;
            //צבע ירוק ברירת מחדל
            int greenValue = Color.FromName("green").ToArgb();
            //לשמור את הצבע כערך היקסה
            type.Color = string.Format("{0:x6}", greenValue);
            exists = dataB.InsertType(type);
            if (exists)
            {
                MessageBox.Show("סוג נשמר בהצלחה", " Successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridTypesFun();
            }
            else
                MessageBox.Show("שם הסוג קיים במערכת נסה שם אחר", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void DataGridTypesFun()
        {
            int i = 0;
            dataGridViewTypes.Rows.Clear();
            int countTypes = dataB.CountTypes();
            Type[] types = new Type[countTypes];
            //רק אם קיימת נתונים התוכנה מעלה את הנתונים
            if (countTypes > 0)
            {
                types = dataB.SelectTypes();
                dataGridViewTypes.RowCount = countTypes;
                foreach (Type atype in types)
                {
                    DataGridViewButtonCell buttonDeleteCell = new DataGridViewButtonCell();
                    DataGridViewButtonCell buttonColorCell = new DataGridViewButtonCell();
                    buttonDeleteCell.Value = "מחק";
                    buttonColorCell.Value = "שינוי צבע";
                    dataGridViewTypes[0, i].Value = atype.Id;
                    dataGridViewTypes[1, i].Value = atype.Name;
                    dataGridViewTypes[2, i] = buttonDeleteCell;
                    dataGridViewTypes[3, i] = buttonColorCell;
                    i++;
                }
            }
        }
        
        //שם הסוג מורכב רק מאותיות
        private void textBoxTypeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsLetter(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }
        
        private void dataGridViewTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            //מחיקת שורה
            if (e.ColumnIndex == dataGridViewTypes.Columns["Delete"].Index)
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את הסוג הזה", " Are you sure?", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    TypeDelete();
            //שינוי צבע
            if (e.ColumnIndex == dataGridViewTypes.Columns["ColorChange"].Index)
            {
                int rowIndex;
                rowIndex = dataGridViewTypes.CurrentCell.OwningRow.Index;//לקבל את מספר השורה
                DataGridViewRow selected = dataGridViewTypes.Rows[rowIndex];
                string typeId = selected.Cells[0].Value.ToString();
                // החלון של הצבעים שהמוכר יכול לבחור את הצבע של הכפתור
                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                dataB.UpdateTypeColor((colorDialog.Color.ToArgb() & 0x00FFFFFF).ToString("X6"), Convert.ToInt64(typeId));
            }
        }
        private void TypeDelete()
        {
            int rowIndex;
            rowIndex = dataGridViewTypes.CurrentCell.OwningRow.Index;//לקבל את מספר השורה
            DataGridViewRow selected = dataGridViewTypes.Rows[rowIndex];
            string typeName = selected.Cells[1].Value.ToString();
            dataB.DeleteType(typeName);//מחיקה מהבסיס הנתונים
            dataGridViewTypes.Rows.RemoveAt(rowIndex);
        }

        private void dataGridViewTypes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את הלקוח הזה", " Are you sure?", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    TypeDelete();
                }
            }
        }

        private void panelPrev_Click(object sender, EventArgs e)
        {
            dataGridViewTypes.Rows.Clear();
            this.Close();
        }
    }
}
