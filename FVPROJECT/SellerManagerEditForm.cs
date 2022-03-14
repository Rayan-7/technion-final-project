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
using System.Net.Mail;
//חלון זה לעריכת משתמש - מוכר או מנהל
namespace FVPROJECT
{
    public partial class SellerManagerEditForm : Form
    {
        //מנהל-0
        //1-מוכר
        int managerOrSeller;
        private DBSQL dataB;
        private SellersForm sellersForm;
        private ManagersForm managersForm;//אחרי שיוצרים את זה עורכים שנית
        private Seller seller;
        private Manager manager;
        private ExternalFunctions exFuncs;
        public SellerManagerEditForm(SellersForm sellersForm,ManagersForm managersForm,Seller seller,Manager manager,int managerOrSeller)
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
            InitializeComponent();
            this.managerOrSeller = managerOrSeller;
            //בגלל לעדכן את הטבלה הפתוחה
            this.sellersForm = sellersForm;
            this.managersForm = managersForm;
            //להעלאות את הנתונים מהטבלה שלא ירשום אותם המשתמש מהתחלה
            this.seller = seller;
            this.manager = manager;
            this.managersForm = managersForm;
            exFuncs = new ExternalFunctions();
        }

        //בפתיחת החלון
        private void SellerManagerEditForm_Load(object sender, EventArgs e)
        {
            //העלאת כל הערים במדינה
            comboBoxMSAddress.Items.Clear();
            int countCities = dataB.CountCities();
            string[] cities = new string[countCities];
            cities = dataB.SelectCitiesNames();
            for (int i = 0; i < countCities; i++)
            {
                comboBoxMSAddress.Items.Add(cities[i]);
            }
            //אם הוא מוכר מטפל במוכר
            if (managerOrSeller == 1)
            {
                labelTitle.Text = "עדכון המוכר";
                TextsFill();
            }
            else
            {
                // אם הוא מנהל מטפל במנהל
                if(managerOrSeller==0)
                {
                    labelTitle.Text = "עדכון המנהל";
                    //למלא את הטקסטים
                    TextsFill();
                }
            }
        }

        private void buttonMSEdit_Click(object sender, EventArgs e)
        {
            bool exist;
            if (MessageBox.Show("?האם אתה בטוח שאתה רוצה לשמור את נתונים אלה", " Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if ((textBoxMSId.Text == "") || (textBoxMSName.Text == "") || (textBoxMSLastName.Text == "") ||
                    (textBoxMSPhoneNumber.Text == "") || (comboBoxMSAddress.Text == "") || (textBoxMSEmail.Text == ""||textBoxMSUserName.Text==""))
                    MessageBox.Show("עליך למלא את כל הפרטים", " Updating failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    //בדיקה: אם המייל תקין
                    if (exFuncs.IsValidEmail(textBoxMSEmail.Text))
                    {
                        //טיפול במוכר
                        if (managerOrSeller == 1)
                            SellerUpdate();
                        //טיפול במנהל
                        else
                            ManagerUpdate();
                    }
                    else
                        MessageBox.Show("עליך לרשום מייל תקין", " Updating failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SellerUpdate()
        {
            bool exist = false;
            //פה אני מעדכן את המוכר שהמשתמש החליט לערוך
            seller.IdNumber = textBoxMSId.Text;
            seller.Name = textBoxMSName.Text;
            seller.LastName = textBoxMSLastName.Text;
            seller.PhoneNumber = textBoxMSPhoneNumber.Text;
            seller.Address = comboBoxMSAddress.Text;
            seller.Email = textBoxMSEmail.Text;
            seller.UserName = textBoxMSUserName.Text;
            exist = dataB.UpdateSeller(seller);
            if (exist)
            {
                MessageBox.Show("המוכר עודכן בהצלחה", " Successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sellersForm.DataGridSellersFun();
                SendMail sendMail = new SendMail();
                sendMail.SendEmailUpdate(null, seller, 1);
            }
            else
                MessageBox.Show("השם המשתמש או הדואר האלקטרוני או מספר הטלפון קיימים במערכת", " failed update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void ManagerUpdate()
        {
            bool exist = false;
            //פה אני מעדכן את המנהל שהמשתמש החליט לערוך
            manager.IdNumber = textBoxMSId.Text;
            manager.Name = textBoxMSName.Text;
            manager.LastName = textBoxMSLastName.Text;
            manager.PhoneNumber = textBoxMSPhoneNumber.Text;
            manager.Address = comboBoxMSAddress.Text;
            manager.Email = textBoxMSEmail.Text;
            manager.UserName = textBoxMSUserName.Text;
            exist = dataB.UpdateManager(manager);
            if (exist)
            {
                MessageBox.Show("המנהל עודכן בהצלחה", " Successfully updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                managersForm.DataGridManagersFun();
                SendMail sendMail = new SendMail();
                sendMail.SendEmailUpdate(manager, null, 0);
            }
            else
                MessageBox.Show("השם המשתמש או הדואר האלקטרוני או מספר הטלפון קיימים במערכת", " failed update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void panelPrev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void TextsFill()
        {
            //למלא את הטקסטים
            textBoxMSId.Text = seller.IdNumber;
            textBoxMSName.Text = seller.Name;
            textBoxMSLastName.Text = seller.LastName;
            textBoxMSPhoneNumber.Text = seller.PhoneNumber;
            comboBoxMSAddress.Text = seller.Address;
            textBoxMSEmail.Text = seller.Email;
            textBoxMSUserName.Text = seller.UserName;
        }
    }
}
