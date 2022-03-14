//Rayan Halabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//מחלקת מנהל
namespace FVPROJECT
{
    public class Manager : Person
    {
        string userName, password;
        DateTime entryDate;
        public Manager()
        {
            
        }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public DateTime EntryDate { get => entryDate; set => entryDate = value; }
    }
}
