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
/*כשהמשתמש בוחר שורה מסויימת בטבלת המוצרים זה החלון הזה יוקפץ ויראה למשתמש מה
 הלקוח קנה איזה מוצרים*/
namespace FVPROJECT
{
    public partial class OrderDetailsForm : Form
    {
        private DBSQL dataB;
        private int orderId;
        public OrderDetailsForm(int orderId)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.orderId = orderId;
        }
        //פתיחת החלון
        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            DataGridOrderFun();
        }
        //מילוי הטבלה
        public void DataGridOrderFun()
        {
            int i = 0;
            dataGridViewOrdersDetails.Rows.Clear();
            int countOrders = dataB.CountOrderDetails(orderId);
            //רק אם יש נתונים התוכנה מעלה את הנתונים
            if (countOrders > 0)
            {
                Product[] products = new Product[countOrders];
                products = dataB.SelectOrderDetails(orderId);
                dataGridViewOrdersDetails.RowCount = products.Length;
                foreach (Product aProduct in products)
                {
                    dataGridViewOrdersDetails[0, i].Value = aProduct.Id;
                    dataGridViewOrdersDetails[1, i].Value = aProduct.Name;
                    dataGridViewOrdersDetails[2, i].Value = aProduct.Price;
                    dataGridViewOrdersDetails[3, i].Value = aProduct.Count;
                    i++;
                }

            }
        }

        private void panelPrev_Click(object sender, EventArgs e)
        {
            dataGridViewOrdersDetails.Rows.Clear();
            this.Close();
        }
    }
}
