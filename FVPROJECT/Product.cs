//Rayan Halabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//מחלקת המוצר
namespace FVPROJECT
{
   public class Product
    {
        private string id, name, type, entrydate, supplierName,supplierId;
        private int count;
        private double price;
        public Product()
        {

        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public int Count { get => count; set => count = value; }
        public double Price { get => price; set => price = value; }
        public string EntryDate { get => entrydate; set => entrydate = value; }
        public string SupplierId { get => supplierId; set => supplierId = value; }
    }
}
