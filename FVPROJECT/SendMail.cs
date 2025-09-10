//Rayan Halabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Twilio.Rest.Trunking.V1;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.IO;
/*מחלקה לשליחת מיילים*/
namespace FVPROJECT
{
    public class SendMail
    {
        private DBSQL dataB;
        public SendMail()
        {
            DBSQL.ConnectionString = Application.StartupPath + "\\FVPROJECT.accdb";
            dataB = DBSQL.Instance;
        }
        public bool SendEmailSupplier(Supplier supplier, List<string> products, int count)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("האימל שלך");
                mail.To.Add(supplier.Email);
                mail.Body = "Hi " + supplier.ContactName + ",\n I want to order from you \n";
                foreach (string productId in products)
                {
                    mail.Subject = "ordering a product from RyoSofts";
                    Product product = new Product();
                    product = dataB.SelectProduct(productId);
                    mail.Body += "Product ID is:" + product.Id + "\n" +
                        " Product Name is:" + product.Name + "\n Product Count is:" + count + "\n" +
                        "When we order these products it means that our customers are impressed with your products \n" +
                        "thanks";
                }
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("האימל שלך", "הסיסמא שלך");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SendEmailClient(Client client)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("האימל שלך");
                mail.To.Add(client.Email);
                mail.Subject = "Thank you for buying from us";
                mail.Body = "Dear " + client.Name + "\n We have sent you a receipt for your purchase from us\n";
                System.Net.Mail.Attachment attachment;
                var savepath = System.IO.Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Orders",
                client.Name + " " + client.LastName + "-" + "קבלה" + "-" + DateTime.Now.ToString("dd_MM_yyyy") + ".pdf");
                attachment = new System.Net.Mail.Attachment(savepath);
                mail.Attachments.Add(attachment);
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ryosofts7@gmail.com", "Ryo12345678");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SendEmailRestPass(string password, string email)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("האימל שלך");
                mail.To.Add(email);
                mail.Subject = "Rest your Password " + password;
                mail.Body = "Your initial password is :" + password + " you must change this password after you signin\n";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("האימל שלך", "הסיסמא שלך");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SendEmailUserInsert(Manager manager, Seller seller, int managerOrSeller, string password)
        {
            if (managerOrSeller == 0)
            {
                return ManagerInsertEmail(manager, password);
            }
            else
            {
                    return SellerInsertEmail(seller, password);
            }
        }
        private bool ManagerInsertEmail(Manager manager, string password)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("האימל שלך");
                mail.To.Add(manager.Email);
                mail.Subject = "RyoSofts Account Activation";
                mail.Body = "Dear " + manager.Name + "\n We’re so glad that you’ve joined our community! \n" +
                    "RyoSofts Email: " + manager.Email + "\n" +
                    "UserName:" + manager.UserName + "\n" +
                    "Your initial password is :" + password + " you must change this password after you signin";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("האימל שלך", "הסיסמא שלך");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private bool SellerInsertEmail(Seller seller, string password)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("האימל שלך");
                mail.To.Add(seller.Email);
                mail.Subject = "RyoSofts Account Activation";
                mail.Body = "Dear " + seller.Name + "\n We’re so glad that you’ve joined our community! \n" +
                    "RyoSofts Email: " + seller.Email + "\n" +
                    "UserName:" + seller.UserName + "\n" +
                    "Your initial password is :" + password + " you must change this password after you signin";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("האימל שלך", "הסיסמא שלך");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SendEmailWorksHours(Seller seller,string email,string date)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("האימל שלך");
                System.Net.Mail.Attachment attachment;
                mail.To.Add(email);
                mail.Subject = "Employees Works Hours";
                mail.Body = "Hi,\n I have attached to you the working hours of my employees\n";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("האימל שלך", "הסיסמא שלך");
                SmtpServer.EnableSsl = true;
                string savepath = System.IO.Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "WorkingHours",
                seller.IdNumber + "-" + seller.Name + "-" + date + ".xlsx");
                attachment = new System.Net.Mail.Attachment(savepath);
                mail.Attachments.Add(attachment);
                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool SendEmailAllFiles(FileInfo[] files,string email)
        {
            try
            {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress("האימל שלך");
                    System.Net.Mail.Attachment attachment;
                    mail.To.Add(email);
                    mail.Subject = "Employees Works Hours";
                    mail.Body = "Hi,\n I have attached to you the working hours of my employees\n";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("האימל שלך", "הסיסמא שלך");
                    SmtpServer.EnableSsl = true;
                foreach (FileInfo file in files)
                {
                    string savepath = System.IO.Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName,
                        "WorkingHours", file.Name);
                    attachment = new System.Net.Mail.Attachment(savepath);
                    mail.Attachments.Add(attachment);
                }
                    SmtpServer.Send(mail);

                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void SendEmailUpdate(Manager manager, Seller seller, int managerOrSeller)
        {
            if (managerOrSeller == 0)
            {
                SendEmailManagerUpdate(manager);
            }
            else
            {
                SendEmailSellerUpdate(seller);
            }
        }
        private void SendEmailManagerUpdate(Manager manager)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("האימל שלך");
                mail.To.Add(manager.Email);
                mail.Subject = "Account details Updated";
                mail.Body = "Dear " + manager.Name + "\n  We wanted to let you know that some changes have been made to your details \n" +
                    "RyoSofts Email: " + manager.Email + "\n" +
                    "UserName:" + manager.UserName + "\n";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("האימל שלך", "הסיסמא שלך");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SendEmailSellerUpdate(Seller seller)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("האימל שלך");
                mail.To.Add(seller.Email);
                mail.Subject = "Account details Updated";
                mail.Body = "Dear " + seller.Name + "\n We wanted to let you know that some changes have been made to your details \n" +
                    "RyoSofts Email: " + seller.Email + "\n" +
                    "UserName:" + seller.UserName + "\n";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("האימל שלך", "הסיסמא שלך");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

}
