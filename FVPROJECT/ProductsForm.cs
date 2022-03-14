//Rayan Halabi
using DocumentFormat.OpenXml.Packaging;
using FVPROJECT.Properties;
using iText.Layout.Element;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ניהול המוצרים , טבלת המוצרים ,הוספה מחיקה , עריכה,הזמנת מוצרים
namespace FVPROJECT
{
    public partial class ProductsForm : Form
    {
        private DBSQL dataB;
        private int rowIndex;
        private bool managerLogin=false;
        private MainForm mainForm;
        
        public ProductsForm(bool managerLogin,MainForm mainForm)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.managerLogin = managerLogin;
            this.mainForm = mainForm;
        }


        private void ProductsBtnForm_Load(object sender, EventArgs e)
        {
            //כשהמנהל נכנס למערכת מייצרים לו כפתור שמבצע הזמנות
            if(managerLogin)
            {
                //עמודה רק בחלון של המנהל
                dataGridViewProducts.Columns.Add("Select", "");
                //הפעלת הרכיבים הרלוונטים להמנהל
                numericUpDownCount.Visible = true;
                buttonOrderSupplier.Visible = true;
                label3.Visible = true;
            }
            //העלאת המוצרים
            DataGridProductsFun();

        }

        private void buttonProductInsert1_Click(object sender, EventArgs e)
        {
            ProductInsertForm productInsertForm = new ProductInsertForm(this);
            productInsertForm.ShowDialog();
            //אחרי כל הוספה מעדכנים את הכפתורים המקוצרים
            if (managerLogin == false)
            {
                mainForm.productButtonsBuild();
            }

        }

        private void buttonInsertTypes_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("הוסף סוגי של המוצרים שבחנות שלך", buttonInsertTypes);
        }

        private void buttonInsertTypes_Click(object sender, EventArgs e)
        {
            
            TypesForm typesForm = new TypesForm();
            typesForm.ShowDialog();
            //אחרי הוספה או מחיקה או שינוי שצבע הכפתור מתעדכנים הכפתורים
            mainForm.productButtonsBuild();
        }

        //כפתור יציאה של הפורם מנקה את הנתונים שלא יעמיס על תוכנה ויוצא
        private void buttonExitProductsForm_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.Rows.Clear();
            this.Close();
        }

        private void textBoxSearchProducts_TextChanged(object sender, EventArgs e)
        {
            DataGridProductsFun();
        }

        //פונקציה ממלא את הטבלה של המוצרים מהבסיס הנתונים
        public void DataGridProductsFun()
        {
            int i = 0;
            dataGridViewProducts.Rows.Clear();
            int countProducts = dataB.CountProducts();
            //רק אם יש נתונים התוכנה מעלה את הנתונים
            if (countProducts > 0)
            {
                Product[] products = new Product[countProducts];

                products = dataB.SelectProducts(textBoxSearchProducts.Text);
                
                countProducts = products.Count(s => s != null);
                dataGridViewProducts.RowCount = countProducts;
                //אם המנהל נכנס לחלון של המוצרים אז מתווספת עמודה מיוחדת רק למנהל
                if (managerLogin == true)
                {
                    
                    //הפעלת הפרוצדורה של המנהל
                    DataGridProductsFunManager(products);
                }
                else
                {
                    //הפעלת הפרוצודורה של המוכר
                    DataGridProductsFunSeller(products);
                }
            }
        }
        //לחיצה על כפתור העריכה או המחיקה בטבלה
        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            //עריכה
            if (e.ColumnIndex == dataGridViewProducts.Columns["Edit"].Index)
            {
                DataGridEdit();
            }
            //מחיקה
            if (e.ColumnIndex == dataGridViewProducts.Columns["Delete"].Index)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את המוצר הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DataGridDelete();
                }
            }
        }
        private void DataGridEdit()
        {
            rowIndex = dataGridViewProducts.CurrentCell.OwningRow.Index;
            Product product = new Product();
            DataGridViewRow selected = dataGridViewProducts.Rows[rowIndex];
            product.Id = selected.Cells[0].Value.ToString();
            product.Name = selected.Cells[1].Value.ToString();
            product.Type = selected.Cells[2].Value.ToString();
            product.SupplierName = selected.Cells[3].Value.ToString();
            product.Count = Convert.ToInt32(selected.Cells[4].Value);
            product.Price = Convert.ToDouble(selected.Cells[5].Value);
            ProductEditForm productEditForm = new ProductEditForm(this, product);
            productEditForm.ShowDialog();
            //אם המוכר עדכן את הכפתור אז צריך לראות אותו מעודכן
            if (managerLogin == false)
            {
                mainForm.productButtonsBuild();
            }
        }
        private void DataGridDelete()
        {
            int rowIndex;
            rowIndex = dataGridViewProducts.CurrentCell.OwningRow.Index;//לקבל את מספר השורה
            DataGridViewRow selected = dataGridViewProducts.Rows[rowIndex];
            string productId = selected.Cells[0].Value.ToString();
            dataB.DeleteProduct(productId);//מחיקה מהבסיס הנתונים
            dataGridViewProducts.Rows.RemoveAt(rowIndex);
            //אם המוכר מחק מוצרים צריך למחוק גם את הכפתר המוקצר שלא יראה אותו שהוא לא קיים
            if (managerLogin == false)
            {
                mainForm.productButtonsBuild();
            }
        }

        //לחיצה על כפתור מחיקה במקלדת מאפשר גם מחיקה של שורה
        private void dataGridViewProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את המוצר הזה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DataGridDelete();
                }
            }
        }
        //פרוצודורה שמכניסה מוצרים לטבלה בחלון של המנהל
        public void DataGridProductsFunManager(Product[] products)
        {
            int i = 0;
            foreach (Product aproduct in products)
            {
                DataGridViewButtonCell buttonEditCell = new DataGridViewButtonCell();
                DataGridViewButtonCell buttonDeleteCell = new DataGridViewButtonCell();
                buttonEditCell.Value = "ערוך";
                buttonDeleteCell.Value = "מחק";
                dataGridViewProducts[0, i].Value = aproduct.Id;
                dataGridViewProducts[1, i].Value = aproduct.Name;
                dataGridViewProducts[2, i].Value = aproduct.Type;
                dataGridViewProducts[3, i].Value = aproduct.SupplierName;
                dataGridViewProducts[4, i].Value = aproduct.Count;
                dataGridViewProducts[5, i].Value = aproduct.Price;
                dataGridViewProducts[6, i].Value = aproduct.EntryDate;
                dataGridViewProducts[7, i] = buttonEditCell;
                dataGridViewProducts[8, i] = buttonDeleteCell;
                //לשמור את קוד ספק בעמודה שהיא תהיה בסתר
                dataGridViewProducts[9, i].Value = aproduct.SupplierId;
                DataGridViewCheckBoxCell dataGridViewCheckBoxCell = new DataGridViewCheckBoxCell();
                dataGridViewCheckBoxCell.Value = false;
                dataGridViewProducts[10, i] = dataGridViewCheckBoxCell;
                if (aproduct.Count >= 1 && aproduct.Count < 10)
                    dataGridViewProducts.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                if (aproduct.Count == 0)
                    dataGridViewProducts.Rows[i++].DefaultCellStyle.BackColor = Color.Red;
            }
        }
        //פרוצדורה שמבצעת הכנסת המוצרים לטבלה בחלון של המוכר
        public void DataGridProductsFunSeller(Product[] products)
        {
            int i = 0;
            foreach (Product aproduct in products)
            {
                DataGridViewButtonCell buttonEditCell = new DataGridViewButtonCell();
                DataGridViewButtonCell buttonDeleteCell = new DataGridViewButtonCell();
                buttonEditCell.Value = "ערוך";
                buttonDeleteCell.Value = "מחק";
                dataGridViewProducts[0, i].Value = aproduct.Id;
                dataGridViewProducts[1, i].Value = aproduct.Name;
                dataGridViewProducts[2, i].Value = aproduct.Type;
                dataGridViewProducts[3, i].Value = aproduct.SupplierName;
                dataGridViewProducts[4, i].Value = aproduct.Count;
                dataGridViewProducts[5, i].Value = aproduct.Price;
                dataGridViewProducts[6, i].Value = aproduct.EntryDate;
                dataGridViewProducts[7, i] = buttonEditCell;
                dataGridViewProducts[8, i] = buttonDeleteCell;
                dataGridViewProducts[9, i].Value = aproduct.SupplierId;
                if (aproduct.Count >= 1 && aproduct.Count < 10)
                    dataGridViewProducts.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                if (aproduct.Count == 0)
                    dataGridViewProducts.Rows[i++].DefaultCellStyle.BackColor = Color.Red;
            }
        }
        private void buttonOrderSupplier_Click(object sender, EventArgs e)
        {
            bool checkExist = CheckCheckBox();
            if (checkExist)
            {
                chkProducts_CheckedChanged();
            }
            else
                MessageBox.Show("עליך לסמן איזה שהוא מוצר שאתה מעוניין להזמין", "ordering filed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        

        //פרוצודרה שמטפלת בתיבת סימון שכל שורה שמסומנת שישמרו את הפרטים שלה במערך
        private void chkProducts_CheckedChanged()
        {
           
            List<Product> products = new List<Product>();
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                if (row.Cells[10].Value != null && (bool)row.Cells[10].Value)
                {
                    Product product = new Product();
                    product.Id = row.Cells[0].Value.ToString();
                    product.Name = row.Cells[1].Value.ToString();
                    product.SupplierName = row.Cells[3].Value.ToString();
                    product.SupplierId= row.Cells[9].Value.ToString();
                    products.Add(product);
                }

            }
            MailOrder(products);
        }
        //לבדוק אם קיים
        private bool CheckCheckBox()
        {
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                if (row.Cells[10].Value != null && (bool)row.Cells[10].Value)
                {
                    return true;
                }

            }
            return false;
        }
        //פרוצדורה שמבצעת העלאת פרטי הספק וגם קוראת לפונקציה שמבצעת שליחת מייל
        private void MailOrder(List<Product> products)
        {
            /*ליצור דיקשנארי עם מפתח ורשימת ערכים ולהוסיף את הקוד של הספק שבמוצר ולשים אותו כמפתח ואת המוצרים
            ששיכים לאותו הספק*/
            Dictionary<string, List<string>> myDict = products.
                GroupBy(supId => supId.SupplierId).Select(grp => new KeyValuePair<string, List<String>>
                  (grp.Key, grp.Select(y => y.Id).ToList())).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach(var dict in myDict)
            {
                //להוציא את הספק לפי הקוד שלו
                Supplier supplier = new Supplier();
                supplier = dataB.SelectSupplier(dict.Key);
                SendMail sendMail = new SendMail();
                bool flag;
                //לשלוח את הספק ורשימת המוצרים והכמות שהמנהל בחר לפונקציה השולחת מייל
                flag = sendMail.SendEmailSupplier(supplier, dict.Value, Convert.ToInt32(numericUpDownCount.Value));
                if (flag)
                    MessageBox.Show(" :ההזמנה בוצעה בהצלחה לכתובת\n" + supplier.Email, "sending mail success");
                else
                    MessageBox.Show(":ההזמנה נכשלה\n" + supplier.Email, "sending mail falied");
            }
            //אחרי ההזמנה צריך לרקן את התאי סימון
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                if (row.Cells[10].Value != null && (bool)row.Cells[10].Value)
                {
                    row.Cells[10].Value = false;
                }
            }
        }
        //יציאה
        private void panelPrev_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.Rows.Clear();
            this.Close();
        }
    }

}
