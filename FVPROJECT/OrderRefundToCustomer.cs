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
using System.Threading;
/*חלון יוקפץ אחרי ביצוע ההזמנה בהצלחה שמראה למשתמש כמה הלקוח שלם ומה עליו לחזיר*/
namespace FVPROJECT
{
    //דף שטוען אחרי שהלקוח משלם ומראה לו כמה הלקוח שלם וכמה עליו להחזיר
    public partial class OrderRefundToCustomer : Form
    {
        
        private double clientPayPrice,totalPrice;
        public OrderRefundToCustomer(double clientPayPrice,double totalPrice)
        {
            this.clientPayPrice = clientPayPrice;//כמה שלם הלקוח
            this.totalPrice = totalPrice;//מה הסכום הכולל
            InitializeComponent();
        }

        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderRefundToCustomer_Load(object sender, EventArgs e)
        {
            textBoxClientPayPrice.Text = Convert.ToString(clientPayPrice);
            textBoxReturnPrice.Text = Convert.ToString(clientPayPrice-totalPrice);
        }

    }
}
