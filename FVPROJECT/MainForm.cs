//Rayan Halabi
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*המחלקה או חלון המרכזי זה של המוכר ,שהמוכר יכול בו לנהל את הלקוחות,הספקים,המוצרים
 ההזמנות,לבצע הזמנות..*/

namespace FVPROJECT
{
    public partial class MainForm : Form
    {
        private DBSQL dataB;
        private Seller seller;
        private DateTime startDay;
        private string totalPriceTemp;
        private SendMail sendMail;
        public MainForm(string userName)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            seller = dataB.SelectSeller(userName);
            sendMail=new SendMail();
        }
        //mouse hover
        private void productsBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("ניהול מוצרים", productsBtn);
        }
        private void suppliersBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("ספקים", suppliersBtn);
        }

        private void clientsBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("לקוחות", clientsBtn);
        }
        //////////////////////////////////////////////////////
        ///טעינת החלון
        private void MainForm_Load(object sender, EventArgs e)
        {
            //הפעלת שיכול המוכר ללחוץ על המספרים במקלדת
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(MainForm_KeyPress);
            //פונקציה לבניית הכפתורים המקוצרים
            productButtonsBuild();
            //////////////////////////////////////////////
            sellerTextBox.Text = seller.Name+" "+ seller.LastName;
            //////////////////
            timer1.Enabled = true;
            //התחלת היום של העובד/
            startDay = DateTime.Now;

        }
        //שעון
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeTextBox.Text = DateTime.Now.ToString("dd/MM/yy  HH:mm:ss");
        }
        /////////////
        ///Click buttons
        ///כשהמשתמש לוחץ על הכפתורים אלה נפתח החלון המתאים
        private void clientsBtn_Click(object sender, EventArgs e)
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
                    ClientsForm clientsForm = new ClientsForm();
                    clientsForm.ShowDialog();
                }
            }
            
        }
        //כפתור הספקים
        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewMainOrder.Rows.Count == 0)
            {
                bool trying = false;
                while (!trying)
                {
                    try
                    {
                        SuppliersForm supplierForm = new SuppliersForm();
                        supplierForm.ShowDialog();
                        trying = true;
                    }
                    catch
                    {
                    }
                }
                
            }
            else
            {
                MessageBox.Show("עליך לטפל בהזמנה שבטבלה", "SuppliersForm Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //כפתור המוצרים
        private void productsBtn_Click(object sender, EventArgs e)
        {
            //שולח לו את הפורם הנוכחי מכיוון שעל כל הוספת מוצר יתרעננו הכפתורים
            if (dataGridViewMainOrder.Rows.Count == 0)
            {
                bool trying=false;
                while (!trying)
                {
                    try
                    {
                        ProductsForm productsForm = new ProductsForm(false, this);
                        productsForm.ShowDialog();
                        trying = true;
                    }
                    catch
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("עליך לטפל בהזמנה שבטבלה", "ProductsForm Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //כפתור ההזמנות
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


        //כפתור החיפוש מוצר
        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            bool trying = false;
            while (!trying)
            {
                try
                {
                    ProductViewForm productViewForm = new ProductViewForm(this);
                    productViewForm.ShowDialog();
                    trying = true;
                }
                catch
                {
                }
            }
        }
        //////////////////////////////////
        // מספרים מאפס עד תשע להקל על המשתמש לבצע הזמנה עם כמויות של המוצר
        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            //שלא יכתוב המוכר אפס בהתחלת הטקסט בגלל שהכמות לא מתחילה ב0
            //אם הגודל לא אפס
            if (textBoxProductsCount.Text.Length > 0)
            {
                //והגודל של המחרוזת קטנה מ6
                if (textBoxProductsCount.Text.Length < 6)
                    //המספר נכנס למחרוזת 
                    textBoxProductsCount.Text += "0";
            }
        }

        //////////////////////////////////////////
        ////המספרים שהמוכר יכול לבחור שזה יאפשר לו לבחור כמות מסויימת
        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            if (textBoxProductsCount.TextLength < 6)
                textBoxProductsCount.Text += "1";
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            if (textBoxProductsCount.TextLength < 6)
                textBoxProductsCount.Text += "2";
        }
        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            if (textBoxProductsCount.TextLength < 6)
                textBoxProductsCount.Text += "3";
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            if (textBoxProductsCount.TextLength < 6)
                textBoxProductsCount.Text += "4";
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            if (textBoxProductsCount.TextLength < 6)
                textBoxProductsCount.Text += "5";
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            if (textBoxProductsCount.TextLength < 6)
                textBoxProductsCount.Text += "6";
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            if (textBoxProductsCount.TextLength < 6)
                textBoxProductsCount.Text += "7";
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            if (textBoxProductsCount.TextLength < 6)
                textBoxProductsCount.Text += "8";
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            if (textBoxProductsCount.TextLength < 6)
                textBoxProductsCount.Text += "9";
        }
        ///////////////////////////////////////////////////////////////
        ///מחיקה
        private void buttonNumberC_Click(object sender, EventArgs e)
        {
            textBoxProductsCount.Clear();
        }

        //מחיקת שורה ממההזמנה
        private void buttonDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridViewMainOrder.Rows.Count > 0)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את השורה הזאת", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int rowIndex;
                    rowIndex = dataGridViewMainOrder.CurrentCell.OwningRow.Index;//לקבל את מספר השורה
                    DataGridViewRow selected = dataGridViewMainOrder.Rows[rowIndex];
                    dataGridViewMainOrder.Rows.RemoveAt(rowIndex);
                        string productId = selected.Cells[0].Value.ToString();
                        int productCount = Convert.ToInt32(selected.Cells[3].Value);
                        dataB.UpdateProductCountUp(productId, productCount);
                    sumCol();//כל עוד המשתמש מחק את מוצר מחשבים את הסכום מההתחלה
                }
            }
            else
            {
                MessageBox.Show("הטבלה שלך ריקה", " Delete Row Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //לחיצה על כפתור מחק במקלדת מאפשר מחיקת שורה
        private void dataGridViewMainOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("?האם אתה בטוח שאתה רוצה למחוק את השורה הזאת", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int rowIndex;
                    rowIndex = dataGridViewMainOrder.CurrentCell.OwningRow.Index;//לקבל את מספר השורה
                    DataGridViewRow selected = dataGridViewMainOrder.Rows[rowIndex];
                    dataGridViewMainOrder.Rows.RemoveAt(rowIndex);
                    string productId = selected.Cells[0].Value.ToString();
                    int productCount = Convert.ToInt32(selected.Cells[3].Value);
                    //פריט כללי אין לו ID
                    if (productId != null)
                    {
                        dataB.UpdateProductCountUp(productId, productCount);
                    }
                    sumCol();//כל עוד המשתמש מחק את מוצר מחשבים את הסכום מההתחלה
                }
            }
        }
        //פונקציה שמחשבת את הסכום הכללי של המוצרים בהזמנה
        public void sumCol()
        {
            Double val = 0;
            textBoxTotalPrice.Text = "";
            foreach (DataGridViewRow item in dataGridViewMainOrder.Rows)
            {
                if (item.Cells[4] != null && item.Cells[4].Value != null)
                {
                    val += Convert.ToDouble(item.Cells[4].Value);
                }    
            }
            val -= Convert.ToDouble(numericUpDownDiscount.Value);
            textBoxTotalPrice.Text = "₪ " + Convert.ToString(val);

        }

        //כשהמשתמש בוחר לצאת מהתוכנית התוכנית בודקת אם יש בטבלה מוצרים להחזיר אותם למלאי
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataGridViewRow data in dataGridViewMainOrder.Rows)
            {
                if (data.Cells[0] != null && data.Cells[0].Value != null)
                {
                    string id = Convert.ToString(data.Cells[0].Value);
                    int count = Convert.ToInt32(data.Cells[3].Value);

                    dataB.UpdateProductCountUp(id, count);
                }
            }
        }

        //ביצוע הזמנה במזומן
        private void buttonCash_Click(object sender, EventArgs e)
        {
            //רק אם הטבלה מלאה מבצעים הזמנה אם לא אז מדפסים הודעה מתאימה
            if (dataGridViewMainOrder.Rows.Count > 0 && dataGridViewMainOrder.Rows != null)
            {
                OrderBegin();
            }
            else
            {
                MessageBox.Show("!עליך למכור איזה שהוא מוצר קודם", "Placing order failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        private void OrderBegin()
        {
            int countOrders;
            //פותחים פורם חדש כשהמשתמש ממלא אותו שומרים את הנתונים במערך
            double totalPrice = Convert.ToDouble((textBoxTotalPrice.Text).Replace(" ", "").Replace("₪", ""));
            OrderCash orderCash = new OrderCash(totalPrice);
            orderCash.ShowDialog();
            ArrayList orders = new ArrayList();
            Order order = new Order();
            //כאשר מקבלים את המערך שומרים את הנתונים שמוכר הכניס
            if (orderCash.payNowClick)//רק אם המשתמש ביצע את ההזמנה ההזמנה תתבצע
            {
                countOrders = dataB.CountOrders();
                InsertOrder(order, orderCash, countOrders, totalPrice);
                int orderDetailsId = dataB.CountOrdersDetails();
                PdfOrderA(orders, countOrders, orderDetailsId);
                double ClientCash = Convert.ToDouble(orderCash.clientsDetails[3]);
                OrderConfirmation(Convert.ToDouble(orderCash.clientsDetails[3]), totalPrice);
                string ClientFullName = order.ClientName + " " + order.ClientLastName;
                PdfOrderB(orders, ClientFullName, orderCash.clientsDetails[0]);
            }
        }
        //הכנסת הנתונים שבחר המוכר להטבלה בבסיס הנתונים
        private void InsertOrder(Order order ,OrderCash orderCash,int countOrders,double totalPrice)
        {
            order.ClientId = orderCash.clientsDetails[0];
            order.ClientName = orderCash.clientsDetails[1];
            order.ClientLastName = orderCash.clientsDetails[2];
            //למספר את הנתונים בבסיס הנתונים
            order.Id = countOrders + 1;//המשתנה הזה הוא מספר ההזמנה
            order.DatePlacingOrder = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
            order.TotalPrice = totalPrice;
            //מכניס את הנתונים לטבלת Orders
            dataB.InsertOrder(order);
        }
        //פתיחת חלון שמציג כמה הלקוח שלם וכמה על המוכר להחזיר
        private void OrderConfirmation(double clientPayPrice, double totalPrice)
        {
            //חלון מציג: כמה הלקוח שלם והמוכר כמה עליו להחזיר
            OrderRefundToCustomer orderRefundToCustomer = new OrderRefundToCustomer(clientPayPrice, totalPrice);
            orderRefundToCustomer.ShowDialog();
            dataGridViewMainOrder.Rows.Clear();
            //לשמור את המחיר לפני שמוחק אותו בגלל לשלוח אותו בקבלה
            totalPriceTemp = textBoxTotalPrice.Text;
            textBoxTotalPrice.Clear();
            textBoxProductShow.Clear();
        }
        //לפני יצירת הקובץ : להכין את הנתונים ושולחת אותה לפונ" שיוצרת את הקובץ
        private void PdfOrderA(ArrayList orders,int countOrders,int orderDetailsId)
        {
            Order order = new Order();
            foreach (DataGridViewRow data in dataGridViewMainOrder.Rows)
            {
                if (data.Cells[0].Value != null)
                {
                    order = new Order();
                    //מכניסים את המוצר עם הפרטים של הלקוח
                    order.ProductId = Convert.ToString(data.Cells[0].Value);
                    order.ProductName = Convert.ToString(data.Cells[1].Value);
                    order.ProductPrice = Convert.ToDouble(data.Cells[2].Value);
                    order.ProductCount = Convert.ToInt32(data.Cells[3].Value);
                    order.TotalPrice = Convert.ToDouble(data.Cells[4].Value);
                    order.Id = countOrders + 1;
                    orderDetailsId++;
                    //הכנסה לבסיס הנתונים
                    dataB.InsertOrderDetails(order, orderDetailsId);
                    //////////////////////////
                    ///pdf
                    //מכין את הנתונים ליצור קבלה
                    orders.Add(order);
                }
            }
        }
        private void PdfOrderB(ArrayList orders,string ClientFullName,string clientIdTemp)
        {
            ///pdf
            ///המרת הרשימה למערך רגיל
            Order[] ordersArray = orders.ToArray(typeof(Order)) as Order[];
            //לשלוח אות הנתונים שבמערך לפונקציה שמיצרת קבלה
            PdfOrderCreate(ordersArray, ClientFullName, "קבלה");
            Client client = new Client();
            //אני צריך את הפרטים של הלקוח
            client = dataB.selectClientsSearchId(clientIdTemp);
            //לשלוח מייל
            if (sendMail.SendEmailClient(client))
            {
                MessageBox.Show("הקבלה נשלחה בהצלחה");
            }
            else
            {
                MessageBox.Show("שליחת הקבלה נכשלה");
            }
            //כשמבצעת המערכת הזמנה אם יש הנחה כל שהיא מוחקת אותה
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Name == "label5")
                {
                    this.Controls.Remove(ctrl);
                }
            }
        }
        //פעולות הכפתורים המקוצרים
        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Product product = new Product();
            product = dataB.SelectProduct(button.Name);
            //אם המוכר לא בחר כמות מסוימת אז המערכת תחשב את זה ככמות 1
            if (textBoxProductsCount.Text == "")
            {
                textBoxProductsCount.Text = "1";
            }
            if (product.Count >= Convert.ToInt32(textBoxProductsCount.Text))
            {
                bool productExist = ProductExistGrid(product);
                //אם הפונקציה החזירה שקר זאת אומרת שעליה לבצע הוספה חדשה
                if (productExist == false)
                {
                    //הטבלה מתמלא לפי הבחירה של המוכר
                    dataGridViewMainOrder.Rows.Add(product.Id, product.Name, product.Price, textBoxProductsCount.Text,
                        Convert.ToDouble(textBoxProductsCount.Text) * product.Price);
                    dataB.UpdateProductCountDown(product.Id, product.Count, Convert.ToInt32(textBoxProductsCount.Text));
                }
                sumCol();//אחרי הוספת מוצר לעדכן את המחיר
            }
            else
                MessageBox.Show("בחרת כמות שאין לך במלאי", "Selected failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //פונקציה שבודקת אם המוצר קיים בטבלה אם כן אז רק לעדכן את הכמות ואז מחזירה אמת אחרת מחזירה שקר
        private bool ProductExistGrid(Product product)
        {
            bool productExist = false;
            //כשהמוכר מוסיף מוצר לטבלת ההזמנות המערכת בודקת אם המוצר קיים בטבלה לפי הקוד ואז מוסיף רק את הכמות
            if (dataGridViewMainOrder.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewMainOrder.Rows)
                {
                    if (product.Id == row.Cells[0].Value.ToString())
                    {
                        int sumProductCount = Convert.ToInt32(row.Cells[3].Value) + Convert.ToInt32(textBoxProductsCount.Text);
                        row.Cells[3].Value = sumProductCount;
                        row.Cells[4].Value = sumProductCount * product.Price;
                        dataB.UpdateProductCountDown(product.Id, product.Count, Convert.ToInt32(textBoxProductsCount.Text));
                        productExist = true;
                        return productExist;
                    }
                }
            }
            return false;
        }
        //פרו" שתפקידה לבנות כפתורים לפי המוצרים וגם לפי הכמות אם המוצר קיים והכמות שלו היא אפס אז לא מתבצעת הבנייה
        public void productButtonsBuild()
        {
            panelButtonsCuts.Controls.Clear();
            ////////////////////////////////
            ///בנית כפתורים דינמיים לפי המוצרים ,כל מוצר יש לו את הכפתור המקוצר שלו
            int countProducts = dataB.CountProductView();
            Product[] products = new Product[countProducts];
            products = dataB.SelectProductsView("");
            Point newLoc = new Point(0, 0);
            foreach (Product aProduct in products)
            {
                BuildButtons(aProduct, ref newLoc);
            }
        }
        private void BuildButtons(Product aProduct,ref Point newLoc)
        {
            //בניית כפתור
            Button button = new Button();
            //הכנסת השם והקוד של המוצר
            button.Name = aProduct.Id;
            button.Text = aProduct.Name;
            //לקבל את שם של הצבע 
            string colorName = dataB.SelectProductColorButton(aProduct.Type);
            //להמיר את שם של הצבע לצבע אמיתי
            button.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + colorName);
            //הגדרת הגודל של הכפתור
            button.Size = new Size(67, 60);
            button.Location = newLoc;
            newLoc.X = newLoc.X + button.Height + 10;
            if (newLoc.X >= panelButtonsCuts.Height + 150)
            {
                newLoc.Y = newLoc.Y + button.Height + 10;
                newLoc.X = 0;
            }
            panelButtonsCuts.Controls.Add(button);
            button.Click += new System.EventHandler(this.button_Click);
        }
        //יציאה
        private void panelExit_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("?האם אתה רוצה לצאת מהחשבון שלך", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (dataGridViewMainOrder.Rows.Count > 0) {
                       if(MessageBox.Show("יש לך מוצרים בטבלה אם אתה יוצא מהחשבון שלך המוצרים יוחזרו למלאי", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes){
                        //ביציאה מהמערכת , המערכת תחשב כמה שעות העובד עבד
                        SellerStartDayEndDate();
                        this.Close();
                    }
                }
                else
                {
                    //ביציאה מהמערכת , המערכת תחשב כמה שעות העובד עבד
                    SellerStartDayEndDate();
                    this.Close();
                }
            }

        }
        
        private void tabControl1_Click(object sender, EventArgs e)
        {
            productButtonsBuild();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                //שלא יכתוב המוכר אפס בהתחלת הטקסט בגלל שהכמות לא מתחילה מ0
                if (e.KeyChar == '0')
                {
                    //אם הגודל לא אפס
                    if (textBoxProductsCount.Text.Length != 0)
                    {
                        //והגדול של המחרוזת קטנה מ6
                        if(textBoxProductsCount.Text.Length < 6)
                            //המספר נכנס למחרוזת 
                        textBoxProductsCount.Text += e.KeyChar.ToString();
                    }
                }
                //אם לא אפס
                else
                {
                    //והגודל קטן מ6
                    if (textBoxProductsCount.Text.Length < 6)
                    {
                        //יכניס את המספר
                        textBoxProductsCount.Text += e.KeyChar.ToString();
                    }
                }
            }
            //כשלוחץ המוכר על BACKSPACE
            if(e.KeyChar==(Char)Keys.Back)
            {
                //למחוק את התו האחרון מהמחרזות
                if(textBoxProductsCount.Text.Length>0)
                textBoxProductsCount.Text = textBoxProductsCount.Text.Remove(textBoxProductsCount.Text.Length - 1);
            }
        }
        //יצירת PDF
        public void PdfOrderCreate(Order[] order,string name,string type)
        {
            Pdf pdf = new Pdf(name+"-"+type+"-"+DateTime.Now.ToString("dd_MM_yyyy"));
            pdf.SetTitle("קבלה");
            pdf.SetDate();
            pdf.insertOrder(order);
            pdf.SetCSDetails(sellerTextBox.Text,name, totalPriceTemp);
            pdf.CloseReport();

        }
        //הנחה
        private void buttonDiscount_Click(object sender, EventArgs e)
        {
            //אם יש הזמנה בטבלה יכול לעשות הנחה
            if (dataGridViewMainOrder.Rows.Count > 0 && dataGridViewMainOrder.Rows != null)
            {
                //הפעלת חלון ההנחה
                DiscountForm discountForm = new DiscountForm(this);
                discountForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("!עליך למכור איזה שהוא מוצר קודם", "discount failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //עריכת שורה בטבלת ההזמנות
        private void buttonEditRow_Click(object sender, EventArgs e)
        {
            //להוציא את הנתונים בשורה המסומנת
            int rowIndex = dataGridViewMainOrder.CurrentRow.Index;
            DataGridViewRow selected = dataGridViewMainOrder.Rows[rowIndex];
            Product product = new Product();
            product.Name = selected.Cells[1].Value.ToString();
            product.Price = Convert.ToDouble(selected.Cells[2].Value);
            //לשלוח את הנתונים של השורה לחלון העריכה
            EditRowForm editRowForm = new EditRowForm(this,product);
            editRowForm.ShowDialog();
            sumCol();
        }
        //ביטול הנחה
        private void buttonDiscountCancel_Click(object sender, EventArgs e)
        {
            discountLabel.Visible = false;
            numericUpDownDiscount.Value = 0;
            sumCol();
        }
        //פונקציה שמחשבת כמה שעות העובד עבד מכניסה תאריך כניסת עובד ויציאתיו
        private void SellerStartDayEndDate()
        {
            DateTime endDay = DateTime.Now;
            double hours = (endDay - startDay).TotalHours;
            seller.BusinessHours = Math.Round(hours, 3);
            dataB.businessHours(seller);
            //פונקציה המכניסה תאריך כניסה ותאריך יציאה
            dataB.StartEndDay(seller.IdNumber,startDay,endDay,seller.BusinessHours);
        }
    }

}
