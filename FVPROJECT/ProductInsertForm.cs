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
//חלון להוספת מוצר
namespace FVPROJECT
{
    public partial class ProductInsertForm : Form
    {
        private DBSQL dataB;
        ProductsForm productsForm;
        public ProductInsertForm(ProductsForm productsForm)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.productsForm = productsForm;
        }
        //פונקציה שמעלה את הסוגים מהבסיס הנתונים ומכניסה אותם לטקסט הבחירה בפתיחת הדף
        private void ProductInsertForm_Load(object sender, EventArgs e)
        {
            comboBoxProductType.Items.Clear();
            int countTypes = dataB.CountTypes();
            string[] types = new string[countTypes];

            types = dataB.SelectTypesNamesId();

            for (int i = 0; i < countTypes; i++)
            {
                comboBoxProductType.Items.Add(types[i]);
            }
            ///////////////////
            ///העלאת הספקים
            comboBoxProductSupplier.Items.Clear();
            int countSuppliers = dataB.CountSuppliers();
            string[] suppliers = new string[countSuppliers];

            suppliers = dataB.SelectSuppliersNamesId();

            for (int i = 0; i < countSuppliers; i++)
            {
                comboBoxProductSupplier.Items.Add(suppliers[i]);
            }
        }
        //פונקציה שמכניסה מוצרים לבסיס נתונים
        private void buttonProductInsert_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם אתה בטוח שאתה רוצה לשמור את נתונים אלה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if ((textBoxProductCode.Text == "") || (textBoxProductName.Text == "") || (comboBoxProductType.Text == "") || (comboBoxProductSupplier.Text == ""))
                {
                    MessageBox.Show("עליך למלא את כל הפרטים", " Saving failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Product product = new Product();
                    product.Id = textBoxProductCode.Text;
                    product.Name = textBoxProductName.Text;
                    //המחרוזת הזאת מורכבת משני חלקים קוד סוג ושם סוג
                    string typeId = comboBoxProductType.Text;
                    //אני מטפל במחרוזת שתהיה רק קוד הסוג
                    typeId = typeId.Substring(typeId.IndexOf("-") + 1);
                    typeId = typeId.Replace(" ", String.Empty);
                    product.Type = typeId;
                    //המחרוזת הזאת מורכבת משני חלקים קוד ספק ושם ספק
                    string supplierId = comboBoxProductSupplier.Text;
                    //אני מטפל במחרוזת שתהיה רק קוד ספק
                    supplierId = supplierId.Substring(supplierId.IndexOf("-") + 1);
                    supplierId = supplierId.Replace(" ", String.Empty);
                    ProductInsert(product, supplierId);
                }
            }
        }
        //הכנסת המוצר
        private void ProductInsert(Product product,string supplierId)
        {
            bool exists = false;
            //בהכנסת את המוצר יש להכניס את קוד הספק
            product.SupplierName = supplierId;
            product.Count = (int)numericUpDownCount.Value;
            product.Price = (double)numericUpDownPrice.Value;
            product.EntryDate = Convert.ToString(DateTime.Now.Date);
            exists = dataB.InsertProduct(product);
            if (exists)
            {
                productsForm.DataGridProductsFun();//לעדכן את הטבלה
                MessageBox.Show("המוצר נשמר בהצלחה", " Successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //אחרי קליטת המוצר למערכת יש לנקות הטקסטים
                textBoxProductCode.Clear();
                textBoxProductName.Clear();
                comboBoxProductType.Text = "";
                comboBoxProductSupplier.Text = "";
                numericUpDownCount.Value = 1;
                numericUpDownPrice.Value = 0;
            }
            else
            {
                MessageBox.Show("המוצר קיים במערכת", "saving failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //קוד מוצר מעורבב: מספרים ו אותיות
        private void textBoxProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!(Char.IsLetter(ch)) && !(Char.IsNumber(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }

        //שם מוצר מעורבב: מספרים ו אותיות
        private void textBoxProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!(Char.IsLetter(ch)) && !(Char.IsNumber(ch)) && (ch != 8) && (ch != 32))
            {
                e.Handled = true;
            }
        }
        //כפתור הקטוגוריות
        private void buttonInsertType_Click(object sender, EventArgs e)
        {
            TypesForm typeForm = new TypesForm();
            typeForm.ShowDialog();
        }
        //כפתור הספקים
        private void buttonInsertPsupplier_Click(object sender, EventArgs e)
        {
            SuppliersForm supplierForm = new SuppliersForm();
            supplierForm.ShowDialog();
        }
        //יציאה
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
