//Rayan Halabi
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*חלון הזה ההוא החלון המרכזי של המנהל יכול לנהל את מנהלים,מוכרים,הלקוחות,הספקים,מוצרים,להסתכל על ההזמנות 
 וגם לראות את הסטטיסטיקה*/
namespace FVPROJECT
{
    public partial class ManagerForm : Form
    {
        private string userName;
        private Manager manager;
        private DBSQL dataB;
        public ManagerForm(string userName)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.userName = userName;
            manager = dataB.SelectManager(userName);
        }

        //פתיחת החלון
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            ///////////
            labelHiText.Text = "שלום "+manager.Name;
            timer1.Enabled=true;

            //להראות למנהל מה הכמות של המוצרים שנגמרו מהמלאי
            int countProductZero=dataB.CountProductZero();
            if (countProductZero != 0)
            {
                buttonProducts.Text = countProductZero.ToString();
            }
            else
                buttonProducts.Text = "";
            if (buttonProducts.Text!="")
            {
                MessageBox.Show("יש לך חוסר במלאי", "You have a shortage in stock!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
              
        }
        //כפתור לפתיחת הטבלה של הלקוחות
        private void buttonClients_Click(object sender, EventArgs e)
        {
            bool trying = false;
            while (!trying)
            {
                try
                {
                    ClientsForm clientsForm = new ClientsForm();
                    clientsForm.ShowDialog();
                    trying = true;
                }
                catch
                {
                   
                }
            }
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            bool trying = false;
            while (!trying)
            {
                try
                {
                    OrderForm orderForm = new OrderForm();
                    orderForm.ShowDialog();
                    trying = true;
                }
                catch
                {

                }
            }
        }
        //כפתור לפתיחת הטבלה של המוצרים
        private void buttonProducts_Click(object sender, EventArgs e)
        {
            bool trying = false;
            while (!trying)
            {
                try
                {
                    ProductsForm productsForm = new ProductsForm(true, null);
                    productsForm.ShowDialog();
                    trying = true;
                }
                catch
                {

                }
            }
            CountProductZero();

        }
        //פרו" מראה למנהל כמה מצרים חסרים יש לך במלאי
        private void CountProductZero()
        {
            //לעדכן את הכמות אחרי כניסת ויציאת המנהל מהחלון של המוצרים אולי עדכן משהו
            int countProductZero = dataB.CountProductZero();
            if (countProductZero != 0)
            {
                buttonProducts.Text = countProductZero.ToString();
            }
            else
                buttonProducts.Text = "";
            if (buttonProducts.Text != "")
            {
                MessageBox.Show("יש לך חוסר במלאי", "You have a shortage in stock!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //כפתור לפתיחת הטבלה של הספקים
        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            bool trying = false;
            while (!trying)
            {
                try
                {
                    SuppliersForm suppliersForm = new SuppliersForm();
                    suppliersForm.ShowDialog();
                    trying = true;
                }
                catch { }
            }
        }


        //כפתור לפתיחת הטבלה של המוכרים
        private void buttonSellers_Click(object sender, EventArgs e)
        {
            bool trying = false;
            while (!trying)
            {
                try
                {
                    SellersForm sellersForm = new SellersForm();
                    sellersForm.ShowDialog();
                    trying = true;
                }
                catch { }
            }
        }
        //שעון
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeTextBox.Text= DateTime.Now.ToString("dd/MM/yy  HH:mm:ss");
        }
        //כפתור לפתיחת הטבלה של המנהלים
        private void buttonManagers_Click(object sender, EventArgs e)
        {
            bool trying = false;
            while (!trying)
            {
                try
                {
                    ManagersForm managersForm = new ManagersForm(userName);
                    managersForm.ShowDialog();
                    trying = true;
                }
                catch { }
            }
        }
        //כפתור לפתיחת הסטטיסטיקה
        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            bool trying = false;
            while (!trying)
            {
                try
                {
                    StatisticForm statisticForm = new StatisticForm();
                    statisticForm.ShowDialog();
                    trying = true;
                }
                catch { }
            }
        }

        private void panelClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם אתה רוצה לצאת מהחשבון שלך", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }
            
    }
}
