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
//בחלון הזאת תוצג טבלה שיש בה את כל המוצרים שהכמות שלם גדולה מ0 שתאפשר בחירת מוצר גם
namespace FVPROJECT
{
    public partial class ProductViewForm : Form
    {
        private DBSQL dataB;
        MainForm mainForm;
        public ProductViewForm(MainForm mainForm)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void ProductViewForm_Load(object sender, EventArgs e)
        {
            DataGridProductsFun();
        }

        //פרוצדורה שמעלה את המוצרים שהכמות שלהם גדולים מ0
        public void DataGridProductsFun()
        {
            int i = 0;
            dataGridViewProductsView.Rows.Clear();
            int countProducts = dataB.CountProductView();
            //רק אם יש נתונים התוכנה מעלה את הנתונים
            if (countProducts > 0)
            {
                Product[] products = new Product[countProducts];

                products = dataB.SelectProductsView(textBoxSearchProduct.Text);
                countProducts = products.Count(s => s != null);
                dataGridViewProductsView.RowCount = countProducts;
                foreach (Product aproduct in products)
                {
                    dataGridViewProductsView[0, i].Value = aproduct.Id;
                    dataGridViewProductsView[1, i].Value = aproduct.Name;
                    dataGridViewProductsView[2, i].Value = aproduct.Count;
                    dataGridViewProductsView[3, i++].Value = aproduct.Price;
                }
            }
        }

        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            DataGridProductsFun();
        }
        //בחירת מוצר 
        private void dataGridViewProductsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            Product product = new Product();
            if (dataGridViewProductsView.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
            {
                //לוקחים מהשורה שמסומנת את הפרטים של המוצר
                product.Id = dataGridViewProductsView.Rows[e.RowIndex].Cells[0].Value.ToString();
                product.Name = dataGridViewProductsView.Rows[e.RowIndex].Cells[1].Value.ToString();
                product.Count = Convert.ToInt32(dataGridViewProductsView.Rows[e.RowIndex].Cells[2].Value);
                product.Price = Convert.ToDouble(dataGridViewProductsView.Rows[e.RowIndex].Cells[3].Value);
                int countClientProductSelect;
                bool productExist=false;//אם המוצר קיים בטבלה
                //אם לא בחר המשתמש את כמות המוצרים שהוא מוכר אז מאתחילים ב1
                if (mainForm.textBoxProductsCount.Text.Length==0)
                    countClientProductSelect = 1;
                else
                    countClientProductSelect = Convert.ToInt32(mainForm.textBoxProductsCount.Text);
                if (product.Count >= countClientProductSelect)
                {
                    //כשהמוכר מוסיף מוצר לטבלת ההזמנות המערכת בודקת אם המוצר קיים בטבלה לפי הקוד ואז מוסיף רק את הכמות
                    if (mainForm.dataGridViewMainOrder.Rows.Count != 0)
                    {
                        foreach (DataGridViewRow row in mainForm.dataGridViewMainOrder.Rows)
                        {
                            if (product.Id == row.Cells[0].Value.ToString())
                            {
                                int sumProduct = Convert.ToInt32(row.Cells[3].Value) + countClientProductSelect;
                                row.Cells[3].Value = sumProduct;
                                row.Cells[4].Value = sumProduct * product.Price;
                                productExist = true;
                                this.Close();
                            }
                        }
                    }
                    if (productExist==false)
                    {
                        mainForm.dataGridViewMainOrder.Rows.Add(product.Id, product.Name, product.Price, countClientProductSelect, countClientProductSelect * product.Price);
                        mainForm.textBoxProductShow.Text = product.Name;
                        this.Close();
                    }
                    dataB.UpdateProductCountDown(product.Id,product.Count, countClientProductSelect);
                    mainForm.textBoxProductsCount.Clear();
                    sumCol();
                   
                }
                else
                {
                    MessageBox.Show("בחרת כמות שאין לך במלאי", "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainForm.textBoxProductsCount.Clear();
                    this.Close();
                }
                
            }
        }
        //פונקציה שמחשבת את הסכום הכללי של המוצרים בהזמנה
        private void sumCol()
        {
            decimal val = 0;
            foreach (DataGridViewRow item in mainForm.dataGridViewMainOrder.Rows)
            {
                if (item.Cells[4] != null && item.Cells[4].Value != null)
                    val += Convert.ToDecimal(item.Cells[4].Value);
            }
            mainForm.textBoxTotalPrice.Text ="₪ "+Convert.ToString(val);
        }
        //יציאה
        private void panelPrev_Click(object sender, EventArgs e)
        {
            dataGridViewProductsView.Rows.Clear();
            this.Close();
        }

    
    }
}
