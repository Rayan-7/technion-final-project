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
//חלון זה מאפשר הוספת ספק
namespace FVPROJECT
{
    public partial class SupplierInsertForm : Form
    {
        private DBSQL dataB;
        private SuppliersForm suppliersForm;
        private ExternalFunctions exFuncs;
        public SupplierInsertForm(SuppliersForm suppliersForm)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.suppliersForm = suppliersForm;
        }
        //פתיחת החלון
        private void SupplierInsertForm_Load(object sender, EventArgs e)
        {
            comboBoxSupplierAddress.Items.Clear();
            int countCities = dataB.CountCities();
            string[] cities = new string[countCities];

            cities = dataB.SelectCitiesNames();

            for (int i = 0; i < countCities; i++)
            {
                comboBoxSupplierAddress.Items.Add(cities[i]);
            }
        }
        //כפתור להוספת ספק חדש
        private void buttonInsertSupplier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם אתה בטוח שאתה רוצה לשמור את נתונים אלה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if ((textBoxSupplierId.Text == "") || (textBoxSupplierName.Text == "") || (textBoxPhoneNumber.Text == "") ||
                    (textBoxContactName.Text == "") || (comboBoxSupplierAddress.Text == "") || (textBoxSupplierMail.Text == ""))
                {
                    MessageBox.Show("עליך למלא את כל הפרטים", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //בדיקה: אם המייל תקין
                    if (exFuncs.IsValidEmail(textBoxSupplierMail.Text))
                        InsertSupplier();
                    else
                        MessageBox.Show("עליך לרשום מייל תקין", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        //הוספת הספק
        private void InsertSupplier()
        {
            bool exists=false;
            Supplier supplier = new Supplier();
            supplier.Id = textBoxSupplierId.Text;
            supplier.Name = textBoxSupplierName.Text;
            supplier.PhoneNumber = textBoxPhoneNumber.Text;
            supplier.ContactName = textBoxContactName.Text;
            supplier.Address = comboBoxSupplierAddress.Text;
            supplier.Email = textBoxSupplierMail.Text;
            exists = dataB.InsertSupplier(supplier);
            if (exists)
            {
                suppliersForm.DataGridSuppliersFun();
                MessageBox.Show("הספק נשמר בהצלחה", " Successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //כשהוסיף המשתמש את הספק המערכת צריכה לנקות את הטקסטים
                TextsClear();
            }
            else
            {
                MessageBox.Show("הספק קיים במערכת תבדוק את קוד הספק או המייל או מספר טלפון", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //קוד ספק מורכב: מספרים ו אותות
        private void textBoxSupplierId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsLetter(ch)) && !(Char.IsNumber(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }
        //שם ספק מורכב: מספרים ו אותות
        private void textBoxSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsLetter(ch)) && !(Char.IsNumber(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }
        //מספר טלפון מורכב : ממספרים
        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsNumber(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }

        //איש קשר מורכב : אותות
        private void textBoxContactName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsLetter(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }

        //כתובת מורכבת: ממספרים ו אותות
        private void textBoxSupplierAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsLetter(ch)) && !(Char.IsNumber(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }
        private void TextsClear()
        {
            textBoxSupplierId.Clear();
            textBoxSupplierName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxContactName.Clear();
            comboBoxSupplierAddress.Text = "";
            textBoxSupplierMail.Clear();
        }
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
