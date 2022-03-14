//Rayan Halabi
using iText.Kernel.Colors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
//חלון תפקידו לאפשר למוכר לעשות הנחה
namespace FVPROJECT
{
    public partial class DiscountForm : Form
    {
        private MainForm mainForm;
        public DiscountForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
        
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDiscount_Click(object sender, EventArgs e)
        {
            //איפוס תא של ההנחות
            mainForm.numericUpDownDiscount.Value = 0;
            //לחשב את הסכום מחדש
            mainForm.sumCol();
            //להוציא את ההנחות והציב אותם במשתנים
            double totalPrice = Convert.ToDouble(mainForm.textBoxTotalPrice.Text.Replace(" ","").Replace("₪",""));
            mainForm.numericUpDownDiscount.Value = numericUpDownDiscount.Value;
            double discount = Convert.ToDouble(mainForm.numericUpDownDiscount.Value);
            string finalPrice;
            //כשההנחה גדולה מהסכום
            if(totalPrice > discount)
            {
                //התוכנית מחשבת את ההנחה לפי התא של ההנחות
                finalPrice = Convert.ToString(totalPrice - discount)+ " ₪";
                mainForm.numericUpDownDiscount.Value = Convert.ToDecimal(discount);
                mainForm.discountLabel.Text = "הנחה של " + "₪ " + discount;
                mainForm.textBoxTotalPrice.Text = finalPrice.ToString();
                mainForm.discountLabel.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("הערך של ההנחה גדול או שווה לסכום", "Discount falied",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                mainForm.discountLabel.Visible = false;
            }
        }
    }
}
