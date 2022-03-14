//Rayan Halabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//מחלקת האבא שיורשות ממנה שאר המחלקות
namespace FVPROJECT
{
    public abstract class Person
    {
        private string id,name,lastName,phoneNumber,address,email;
        public Person()
        {

        }
        public string IdNumber { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
    }
}
