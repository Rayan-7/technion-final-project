//Rayan Halabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//מחלקת מוכר שיורשת מחלקת האבא
namespace FVPROJECT
{
    public class Seller : Person
    {
        string userName, password,startDay,endDay;
        DateTime entryDate;
        double businessHours;
        public Seller()
        {
            
        }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public DateTime EntryDate { get => entryDate; set => entryDate = value; }
        public double BusinessHours { get => businessHours; set => businessHours = value; }
        public string StartDay { get => startDay; set => startDay = value; }
        public string EndDay { get => endDay; set => endDay = value; }
    }
}
