//Rayan Halabi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//מחלקת הזמנות
namespace FVPROJECT
{
    public class Order
    {
        private string clientId, clientName, clientLastName, productId, productName;
        private double productPrice,totalPrice;
        private int id,productCount;
        private DateTime datePlacingOrder;
        public Order()
        {

        }
        public int Id { get => id; set => id = value; }
        public string ClientId { get => clientId; set => clientId = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string ClientLastName { get => clientLastName; set => clientLastName = value; }
        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double ProductPrice { get => productPrice; set => productPrice = value; }
        public int ProductCount { get => productCount; set => productCount = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime DatePlacingOrder { get => datePlacingOrder; set => datePlacingOrder = value; }

    }
}
