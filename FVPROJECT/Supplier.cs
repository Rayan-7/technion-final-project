//Rayan Halabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//מחלקת הספקים
namespace FVPROJECT
{
    public class Supplier
    {
        private string id, name, phoneNumber, contactName, email, address;
        public Supplier()
        {

        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string ContactName { get => contactName; set => contactName = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
    }
}
