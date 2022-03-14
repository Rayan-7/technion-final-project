//Rayan Halabi
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//מחלקת הקטגוריות
namespace FVPROJECT
{
    class Type
    {
        private int id;
        private string name;
        private string color;
        public Type()
        {

        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
    }
}
