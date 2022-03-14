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
using System.Windows.Forms.VisualStyles;
//חלון לעדכון מוצרים
namespace FVPROJECT
{
    public partial class ProductEditForm : Form
    {
        private DBSQL dataB;
        ProductsForm productsForm;
        private Product product = new Product();
        public ProductEditForm(ProductsForm productsForm, Product product)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.product = product;
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            comboBoxProductType.Items.Clear();
            int countTypes = dataB.CountTypes();
            string[] types = new string[countTypes];
            types = dataB.SelectTypesNamesId();
            for (int i = 0; i < countTypes; i++)
            {
                comboBoxProductType.Items.Add(types[i]);
            }
            ///////////////
            comboBoxProductSupplier.Items.Clear();
            int countSuppliers = dataB.CountSuppliers();
            string[] suppliers = new string[countSuppliers];
            suppliers = dataB.SelectSuppliersNamesId();
            for (int i = 0; i < countSuppliers; i++)
            {
                comboBoxProductSupplier.Items.Add(suppliers[i]);
            }
            //הוספת את הפרטים שלא יכתוב אותם מההתחלה
            textBoxProductCode.Text = product.Id;
            textBoxProductName.Text = product.Name;
            numericUpDownCount.Value = product.Count;
            numericUpDownPrice.Value = Convert.ToDecimal(product.Price);
        }
        //  כפתור מעדכן את הנתונים של המוצר
        private void buttonProductUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם אתה בטוח שאתה רוצה לעדכן את נתונים אלה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if ((textBoxProductCode.Text == "") || (textBoxProductName.Text == "") || (comboBoxProductType.Text == "") || (comboBoxProductSupplier.Text == ""))
                {
                    MessageBox.Show("עליך למלא את כל הפרטים", " Updating failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string supplierId =productFilter();
                    //בהכנסת את המוצר יש להכניס את קוד הספק
                    product.SupplierName = supplierId;
                    product.Count = Convert.ToInt32(numericUpDownCount.Value);
                    product.Price = Convert.ToDouble(numericUpDownPrice.Value);
                    product.EntryDate = DateTime.Now.ToString("dd-MM-yyy hh:mm:ss");
                    dataB.UpdateProduct(product);
                    MessageBox.Show("המוצר עודכן בהצלחה", " Successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productsForm.DataGridProductsFun();
                }

            }
        }
        //טיפול בטקסטים
        private string productFilter()
        {
            //פה אני מעדכן את המוצר  שהמשתמש החליט לשנות
            product.Id = textBoxProductCode.Text;
            product.Name = textBoxProductName.Text;
            string typeId = comboBoxProductType.Text;
            typeId = typeId.Substring(typeId.IndexOf("-") + 1);
            typeId = typeId.Replace(" ", String.Empty);
            product.Type = typeId;
            string supplierId = comboBoxProductSupplier.Text;
            //אני מטפל במחרוזת שתהיה רק קוד ספק
            supplierId = supplierId.Substring(supplierId.IndexOf("-") + 1);
            supplierId = supplierId.Replace(" ", String.Empty);
            return supplierId;
        }
        //יציאה
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
