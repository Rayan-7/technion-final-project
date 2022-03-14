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
//החלון הזה מאפשר למשתמש לערוך את הספק
namespace FVPROJECT
{
    public partial class SupplierEditForm : Form
    {
        private DBSQL dataB;
        SuppliersForm suppliersForm;
        Supplier supplier = new Supplier();
        private ExternalFunctions exFuncs;
        public SupplierEditForm(SuppliersForm suppliersForm,Supplier supplier)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.supplier = supplier;
            this.suppliersForm = suppliersForm;
        }
        //פתיחת החלון
        private void SupplierEditForm_Load(object sender, EventArgs e)
        {
            comboBoxSupplierAddress.Items.Clear();
            int countCities = dataB.CountCities();
            string[] cities = new string[countCities];

            cities = dataB.SelectCitiesNames();

            for (int i = 0; i < countCities; i++)
            {
                comboBoxSupplierAddress.Items.Add(cities[i]);
            }
            textBoxSupplierId.Text = supplier.Id;
            textBoxSupplierName.Text=supplier.Name;
            textBoxPhoneNumber.Text=supplier.PhoneNumber;
            textBoxContactName.Text =supplier.ContactName;
            comboBoxSupplierAddress.Text=supplier.Address;
            textBoxSupplierMail.Text =supplier.Email;
        }
        //כפתור עריכת השורה
        private void buttonEditSupplier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם אתה בטוח שאתה רוצה לשמור את נתונים אלה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if ((textBoxSupplierId.Text == "") || (textBoxSupplierName.Text == "") || (textBoxPhoneNumber.Text == "") ||
                    (textBoxContactName.Text == "") || (comboBoxSupplierAddress.Text == "") || (textBoxSupplierMail.Text == ""))
                {
                    MessageBox.Show("עליך למלא את כל הפרטים", " Updating failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //בדיקה: אם המייל תקין
                    if (exFuncs.IsValidEmail(textBoxSupplierMail.Text))
                    {
                        SupplierUpdate();
                    }
                    else
                    {
                        MessageBox.Show("עליך לרשום מייל תקין", " Updating failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //עדכון הספק בבסיס הנתונים
        private void SupplierUpdate()
        {
            bool exist;
            //פה אני מעדכן את המוצר שהמשתמש החליט לשנות
            supplier.Id = textBoxSupplierId.Text;
            supplier.Name = textBoxSupplierName.Text;
            supplier.PhoneNumber = textBoxPhoneNumber.Text;
            supplier.ContactName = textBoxContactName.Text;
            supplier.Address = comboBoxSupplierAddress.Text;
            supplier.Email = textBoxSupplierMail.Text;
            exist = dataB.UpdateSupplier(supplier);
            if (exist)
            {
                MessageBox.Show("הספק עודכן בהצלחה", " Successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                suppliersForm.DataGridSuppliersFun();
            }
            else
            {
                MessageBox.Show("הספק קיים במערכת תבדוק", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
