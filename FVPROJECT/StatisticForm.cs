//Rayan Halabi
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//חלון הסטטסטיקה
namespace FVPROJECT
{
    public partial class StatisticForm : Form
    {
        private DBSQL dataB;
        
        public StatisticForm()
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
        }


        private void StatisticForm_Load(object sender, EventArgs e)
        {
            dateTimePickerMin.Value = DateTime.Now.Date;
            dateTimePickerMax.Value = DateTime.Now.Date;
            //העלאת הנתונים לטבלה
            DataGridStatisticFunMax();
            DataGridStatisticFunMin();
            DataGridToChartMax();
            DataGridToChartMin();
        }
        //פונקציה שלוקחת את הנתונים שיש בטבלה ומציגה אותם כגרף
        public void DataGridToChartMax()
        {
            chart1.Series.Clear();
            
            chart1.Series.Add("count");
            chart1.Series[0] = new Series();
            chart1.Series[0].LegendText = "Count";
            //chart1.Series[0].XValueMember = dataGridViewStatistics.Columns[0].HeaderText;
            //chart1.Series[0].YValueMembers = dataGridViewStatistics.Columns[3].HeaderText;
            chart1.DataSource = dataGridViewStatisticsMax.DataSource;
            if (dataGridViewStatisticsMax.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewStatisticsMax.Rows)
                {
                    chart1.Series[0].Points.AddXY(row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());

                }
            }
            else
            {
                chart1.Visible = false;
            }
        }
        public void DataGridToChartMin()
        {
            chart2.Series.Clear();

            chart2.Series.Add("count");
            chart2.Series[0] = new Series();
            chart2.Series[0].LegendText = "Count";
            //chart1.Series[0].XValueMember = dataGridViewStatistics.Columns[0].HeaderText;
            //chart1.Series[0].YValueMembers = dataGridViewStatistics.Columns[3].HeaderText;
            chart2.DataSource = dataGridViewStatisticsMin.DataSource;
            if (dataGridViewStatisticsMax.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewStatisticsMin.Rows)
                {
                    chart2.Series[0].Points.AddXY(row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());

                }
            }
            else
            {
                chart2.Visible = false;
            }
        }
        public void DataGridStatisticFunMax()
        {
            dataGridViewStatisticsMax.Rows.Clear();
            int countProducts = dataB.Countstatistics();
            //רק אם יש נתונים מעלה את הנתונים
            if (countProducts > 0)
            {
                int j = 1, i = 0;
                Product[] products = new Product[countProducts];
                products = dataB.SelectstatisticsMax(dateTimePickerMin.Value, dateTimePickerMax.Value);
                //לספור את התאים המלאים במערך
                countProducts = products.Count(s => s != null);
                if (countProducts > 0)
                {
                    dataGridViewStatisticsMax.RowCount = countProducts;
                    foreach (Product aProduct in products)
                    {
                        //הכנסת הנתונים לטבלה
                        dataGridViewStatisticsMax[0, i].Value = j++;
                        dataGridViewStatisticsMax[1, i].Value = aProduct.Id;
                        dataGridViewStatisticsMax[2, i].Value = aProduct.Name;
                        dataGridViewStatisticsMax[3, i].Value = aProduct.Count;
                        i++;
                    }
                }
            }
        }

        public void DataGridStatisticFunMin()
        {
            dataGridViewStatisticsMin.Rows.Clear();
            int countProducts = dataB.Countstatistics();

            //רק אם יש נתונים מעלה את הנתונים
            if (countProducts > 0)
            {
                int j = 1, i = 0;
                Product[] products = new Product[countProducts];
                products = dataB.SelectstatisticsMin(dateTimePickerMin.Value, dateTimePickerMax.Value);
                //לספור את התאים המלאים במערך
                countProducts = products.Count(s => s != null);
                if (countProducts > 0)
                {
                    dataGridViewStatisticsMin.RowCount = countProducts;
                    foreach (Product aProduct in products)
                    {
                        //הכנסת הנתונים לטבלה
                        dataGridViewStatisticsMin[0, i].Value = j++;
                        dataGridViewStatisticsMin[1, i].Value = aProduct.Id;
                        dataGridViewStatisticsMin[2, i].Value = aProduct.Name;
                        dataGridViewStatisticsMin[3, i].Value = aProduct.Count;
                        i++;
                    }
                }
            }
        }

        private void buttonDateSearch_Click(object sender, EventArgs e)
        {
            DataGridStatisticFunMax();
            DataGridStatisticFunMin();
            DataGridToChartMax();
            DataGridToChartMin();
        }
        //יציאה
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
