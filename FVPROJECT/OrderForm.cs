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
/*טבלה שמראה למשתמש את הלקוחות וההזמנות שעשו*/
namespace FVPROJECT
{
    public partial class OrderForm : Form
    {
        private DBSQL dataB;
        private int count = 0;
        public OrderForm()
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            dateTimePickerOrderMin.Value = new DateTime(2020, 7, 1);
            DataGridOrderFun();
        }

        //פרו" ממלא הטבלה
        public void DataGridOrderFun()
        {
            int i = 0;
            dataGridViewOrders.Rows.Clear();
            DateTime dateMin=new DateTime(2019,1,1);
            int countOrders = dataB.CountOrders();
            //רק אם יש נתונים התוכנה מעלה את הנתונים
            if (countOrders > 0)
            {
                Order[] orders = new Order[countOrders];
                orders = dataB.SelectOrders(dateTimePickerOrderMin.Value.Date,
                    dateTimePickerOrderMax.Value.Date,textBoxSearchOrder.Text);
                countOrders = orders.Count(s => s != null);
                dataGridViewOrders.RowCount = countOrders;
                //להציב תאריך ישן שאם השתנה התאריך המינימלי שיחזור על מה שהיה
                foreach (Order aOrder in orders)
                {
                    dataGridViewOrders[0, i].Value = aOrder.Id;
                    dataGridViewOrders[1, i].Value = aOrder.ClientId;
                    dataGridViewOrders[2, i].Value = aOrder.ClientName;
                    dataGridViewOrders[3, i].Value = aOrder.ClientLastName;
                    dataGridViewOrders[4, i].Value = aOrder.TotalPrice;
                    dataGridViewOrders[5, i++].Value = aOrder.DatePlacingOrder;        
                }
            }
        }
        
        private void buttonDateSearch_Click(object sender, EventArgs e)
        {
            if(dateTimePickerOrderMin.Value>dateTimePickerOrderMax.Value)
                MessageBox.Show("תבדוק את התאריך", "searching failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridOrderFun();
        }

        private void panelPrev_Click(object sender, EventArgs e)
        {
            dataGridViewOrders.Rows.Clear();
            this.Close();
        }
        //בחירת שורה מאפשרת פתיחת חלון פרטי ההזמנה
        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int rowIndex;
            rowIndex = dataGridViewOrders.CurrentCell.OwningRow.Index;//לקבל את מספר השורה
            DataGridViewRow selected = dataGridViewOrders.Rows[rowIndex];
            int orderId = Convert.ToInt32(selected.Cells[0].Value);
            if (orderId != 0)
            {
                OrderDetailsForm orderDetailsForm = new OrderDetailsForm(orderId);
                orderDetailsForm.ShowDialog();
            }
        }
    }
}
