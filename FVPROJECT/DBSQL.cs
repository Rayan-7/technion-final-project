//Rayan Halabi
using FVPROJECT;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.Rest.Trunking.V1;

//מחלקה לבסיס נתונים שמקושרת עם אקסס שיש בה הרבה פעולות ,הוספה,עריכה,מחיקה ועוד..
namespace FVPROJECT
{
    class DBSQL : DbAccess
    {
        private static string conString;
        private static DBSQL instance;
        private DBSQL(string conString) : base(conString)
        { }
        public static DBSQL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBSQL(conString);
                }
                return instance;
            }
        }
        public static string ConnectionString
        {
            get { return conString; }
            set
            {
                conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + value + ";Persist Security Info=False;";
            }
        }
        ////////////////////////////////////
        ///Insert
        //פרוצודורה שמכניסה מוצר חדש לבסיס הנתונים וגם בודקת אם הוא קיים במערכת ואם התוכנית אם הוא קיים אז מעדכנים את המוצר אם לא מוסיפים אותו
        public bool InsertProduct(Product product)
        {
            //אם המוצר קיים במערכת מחזירה שקר
            if (CheckProduct(product.Id) > 0)
            {
                return false;
            }
            else
            {
                //שאילתה שמאפשרת הכנסת מוצר לבסיס הנתונים
                string cmdStr = "INSERT INTO Products (ProductID,Name,TypeId,SupplierId,ProductCount,Price,EntryDate,Status) VALUES" +
                 " (@product.Id,@product.Name,@product.Type,@product.SupplierId,@product.Count,@product.Price,@product.EntryDate,@Status)";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    //הכנסת הנתונים לפי הסדר
                    command.Parameters.AddWithValue("@ProductID", product.Id);
                    command.Parameters.AddWithValue("@Name", product.Name);
                    //קוד סוג
                    command.Parameters.AddWithValue("@TypeId", product.Type);
                    //קוד ספק   
                    command.Parameters.AddWithValue("@SupplierId", product.SupplierName);
                    command.Parameters.AddWithValue("@ProductCount", product.Count);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@EntryDate", product.EntryDate);
                    command.Parameters.AddWithValue("@Status", true);
                    base.ExecuteSimpleQuery(command);
                }
            }
            return true;
        }
        private int CheckProduct(string productId)
        {
            //שאילתה שסופרת כמה מוצרים יש לפי קוד מוצר
            int result;
            string cmdStr = "SELECT COUNT (ProductID) FROM (Products) " +
                "WHERE ProductID = '"+ productId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@ProductID", productId);
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        //פונקציה  שמכניסה סוג חדש לבסיס הנתונים וגם בודקת אם הוא קיים במערכת ואם התוכנית הצליחה מחזירה אמת 
        //אם לא מחזירה שקר
        public bool InsertType(Type type)
        {
            if (CheckType(type.Name) > 0)
                return false;
            //שאילתה שמאפשרת הכנסת סוג חדש לבסיס הנתונים
           string cmdStr = "INSERT INTO ProductTypes (TypeName,Color,Status) " +
                "VALUES (@type.Name,@type.Color.Name,@Status)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@TypeName", type.Name);
                command.Parameters.AddWithValue("@Color", type.Color);
                command.Parameters.AddWithValue("@Status",true);
                base.ExecuteSimpleQuery(command);
            }
            return true;
        }
        //פונק" מחזירה כמה קטגוריות יש מאותו שם
        private int CheckType(string typeName)
        {
            //שאילתה שסופרת כמה סוגים יש לפי שם קטוגוריה
            int result;
            string cmdStr = "SELECT COUNT (TypeName) FROM (ProductTypes)" +
                " WHERE TypeName = '"+typeName+"'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@typeName", typeName);
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        //פונקציה שמבצעת בדיקה אם קיים במערכת קוד ספק,מספר טלפון ,מייל אם לא קיים מבצע הוספה למערכת
        public bool InsertSupplier(Supplier supplier)
        {
            //בדיקה אם קיים ספק במערכת
            if (CheckSupplier(supplier) > 0)
            {
                return false;
            }

            //שאילתה שמאפשרת הכנסת ספק חדש לבסיס הנתונים
            string cmdStr = "INSERT INTO Suppliers (SupplierID,Name,PhoneNumber,ContactName,Address,Email,Status) VALUES" +
                " (@supplier.Id,@supplier.Name,@supplier.PhoneNumber,@supplier.ContactName,@supplier.Address,@supplier.Email,@Status)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@SupplierID", supplier.Id);
                command.Parameters.AddWithValue("@Name", supplier.Name);
                command.Parameters.AddWithValue("@PhoneNumber", supplier.PhoneNumber);
                command.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                command.Parameters.AddWithValue("@Address", supplier.Address);
                command.Parameters.AddWithValue("@Email", supplier.Email);
                command.Parameters.AddWithValue("@Status", true);
                base.ExecuteSimpleQuery(command);
            }
            return true;
        }
        private int CheckSupplier(Supplier supplier)
        {
            int result;
            //לבדוק אם הספק קיים במערכת ופעיל
            string cmdStr = "SELECT COUNT (*) FROM (Suppliers)" +
             "WHERE ((SupplierId = @id) OR (PhoneNumber = @phoneNumber) OR (Email = @email))";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", supplier.Id);
                command.Parameters.AddWithValue("@phoneNumber", supplier.PhoneNumber);
                command.Parameters.AddWithValue("@email", supplier.Email);
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        //הכנסת לקוח חדש
        public bool InsertClient(Client client)
        {
            //לבדוק קיום לקוח
            if (CheckClient(client) > 0)
            {
                return false;
            }
            else
            {
                //שאילתה שמאפשרת הכנסת לקוח חדש לבסיס הנתונים
                string cmdStr = "INSERT INTO Clients (ClientID,Name,LastName,PhoneNumber,Address,Email,Status) VALUES" +
                    "(@client.IdNumber,@client.Name,@client.LastName,@client.PhoneNumber,@client.Address,@client.Email,@Status)";
                using (OleDbCommand command = new OleDbCommand(cmdStr))
                {
                    //הכנסת הנתונים לפי הסדר
                    command.Parameters.AddWithValue("@ClientID", client.IdNumber);
                    command.Parameters.AddWithValue("@Name", client.Name);
                    command.Parameters.AddWithValue("@LastName", client.LastName);
                    command.Parameters.AddWithValue("@PhoneNumber", client.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", client.Address);
                    command.Parameters.AddWithValue("@Email", client.Email);
                    command.Parameters.AddWithValue("@Status", true);
                    base.ExecuteSimpleQuery(command);
                }
                return true;
            }

        }
        //לספור כמה לקוחות יש בבסיס נתונים
        private int CheckClient(Client client)
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM (Clients)" +
                "WHERE (ClientId = @client.IdNumber) OR (PhoneNumber = @client.PhoneNumber) OR (Email = @client.Email)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@ClientId", client.IdNumber);
                command.Parameters.AddWithValue("@PhoneNumber", client.PhoneNumber);
                command.Parameters.AddWithValue("@Email", client.Email);
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        //הוספת מנהל
        public bool InsertManager(Manager manager)
        {
            if (CheckManager(manager) > 0)
            {
                return false;
            }
            //שאילתה שמאפשרת הכנסת מנהל חדש לבסיס הנתונים
            string cmdStr = "INSERT INTO Users (UserId,UserRealName,UserLastName,UserPhoneNumber,UserAddress,UserEmail,UserName,UserPassword,UserEntryDate,Status,RestPass,ManagerOrSeller) VALUES" +
                      "(@manager.IdNumber,@manager.Name,@manager.LastName,@manager.PhoneNumber,@manager.Address,@manager.Email,@manager.UserName,@manager.Password,@manager.EntryDate,@Status,@RestPass,@ManagerOrSeller)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@UserId", manager.IdNumber);
                command.Parameters.AddWithValue("@UserRealName", manager.Name);
                command.Parameters.AddWithValue("@UserLastName", manager.LastName);
                command.Parameters.AddWithValue("@UserPhoneNumber", manager.PhoneNumber);
                command.Parameters.AddWithValue("@UserAddress", manager.Address);
                command.Parameters.AddWithValue("@UserEmail", manager.Email);
                command.Parameters.AddWithValue("@UserName", manager.UserName);
                command.Parameters.AddWithValue("@UserPassword", manager.Password);
                command.Parameters.AddWithValue("@UserEntryDate", manager.EntryDate);
                command.Parameters.AddWithValue("@Status", true);
                command.Parameters.AddWithValue("@RestPass", true);
                command.Parameters.AddWithValue("@ManagerOrSeller", false);
                base.ExecuteSimpleQuery(command);
            }
            return true;

        }
        private int CheckManager(Manager manager)
        {
            int result;
            //לבדוק אם המוכר קיים במערכת
            string cmdStr = "SELECT COUNT (*) FROM (Users)" +
             "WHERE ((UserId = @UserId) OR (UserPhoneNumber = @UserPhoneNumber) OR " +
             "(UserEmail=@UserEmail) OR (UserName = @UserName))";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@UserId", manager.IdNumber);
                command.Parameters.AddWithValue("@UserPhoneNumber", manager.PhoneNumber);
                command.Parameters.AddWithValue("@UserEmail", manager.Email);
                command.Parameters.AddWithValue("@UserName", manager.UserName);
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        //הוספת מוכר
        public bool InsertSeller(Seller seller)
        {
            if (CheckSeller(seller) > 0)
            {
                return false;
            }
            //שאילתה שמאפשרת הכנסת מנהל חדש לבסיס הנתונים
            string cmdStr = "INSERT INTO Users (UserId,UserRealName,UserLastName,UserPhoneNumber,UserAddress,UserEmail,UserName,UserPassword,UserEntryDate,UserWorkHours,Status,RestPass,ManagerOrSeller) VALUES" +
                     "(@seller.IdNumber,@seller.Name,@seller.LastName,@seller.PhoneNumber,@seller.Address,@seller.Email,@seller.UserName,@seller.Password,@seller.EntryDate,@SellerWorkHours,@Status,@RestPass,@ManagerOrSeller)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@UserId", seller.IdNumber);
                command.Parameters.AddWithValue("@UserRealName", seller.Name);
                command.Parameters.AddWithValue("@UserLastName", seller.LastName);
                command.Parameters.AddWithValue("@UserPhoneNumber", seller.PhoneNumber);
                command.Parameters.AddWithValue("@UserAddress", seller.Address);
                command.Parameters.AddWithValue("@UserEmail", seller.Email);
                command.Parameters.AddWithValue("@UserName", seller.UserName);
                command.Parameters.AddWithValue("@UserPassword", seller.Password);
                command.Parameters.AddWithValue("@UserEntryDate", seller.EntryDate);
                command.Parameters.AddWithValue("@UserWorkHours", 0);
                command.Parameters.AddWithValue("@Status", true);
                command.Parameters.AddWithValue("@RestPass", true);
                command.Parameters.AddWithValue("@ManagerOrSeller", true);
                base.ExecuteSimpleQuery(command);
            }
            return true;
        }

        private int CheckSeller(Seller seller)
        {
            int result;
            //לבדוק אם המוכר קיים במערכת
            string cmdStr = "SELECT COUNT (*) FROM (Users)" +
             "WHERE ((UserId = @UserId) OR (UserPhoneNumber = @UserPhoneNumber) OR (UserEmail=@UserEmail) OR (UserName = @UserName))";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@UserId", seller.IdNumber);
                command.Parameters.AddWithValue("@UserPhoneNumber", seller.PhoneNumber);
                command.Parameters.AddWithValue("@UserEmail", seller.Email);
                command.Parameters.AddWithValue("@UserName", seller.UserName);
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        public void InsertOrderDetails(Order order,int orderDetailsId)
        {

            //שאילתה שמאפשרת הכנסת הזמנה חדשה לבסיס הנתונים
                 string cmdStr = "INSERT INTO OrdersDetails (Id,OrderId,ProductId,ProductCount) VALUES" +
                " (@orderDetailsId,@order.Id,@order.ProductId,@order.ProductCount)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@Id", orderDetailsId);
                command.Parameters.AddWithValue("@OrderId", order.Id);
                command.Parameters.AddWithValue("@ProductId", order.ProductId);
                command.Parameters.AddWithValue("@ProductCount", order.ProductCount);
                base.ExecuteSimpleQuery(command);
            }

        }

        public void InsertOrder(Order order)
        {

            //שאילתה שמאפשרת הכנסת הזמנה חדשה לבסיס הנתונים
           string cmdStr = "INSERT INTO Orders (OrderId,ClientId,DatePlacing,TotalPrice) VALUES" +
          " (@order.Id,@order.ClientId,@order.DatePlacingOrder,@order.TotalPrice)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@OrderId", order.Id);
                command.Parameters.AddWithValue("@ClientId", order.ClientId);
                command.Parameters.AddWithValue("@DatePlacing", order.DatePlacingOrder);
                command.Parameters.AddWithValue("@TotalPrice", order.TotalPrice);
                base.ExecuteSimpleQuery(command);
            }

        }





        /////////////////////////////////////////////
        //Select Functions
        //פונקציה שמעלה את המוצרים מבסיס הנתונים
        public Product[] SelectProducts(string valueToSearch)
        {
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = "SELECT ProductID,Products.Name,ProductTypes.TypeName,Suppliers.Name,ProductCount,Price,EntryDate,Suppliers.SupplierId FROM Suppliers " +
                "INNER JOIN (ProductTypes INNER JOIN Products ON ProductTypes.TypeCode = Products.TypeId) ON Suppliers.SupplierId = Products.SupplierId" + " WHERE " +
                "(ProductID + ' ' + Products.Name like '%" + valueToSearch + "%') AND Products.Status=True";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tProduct in dt.Rows)
            {
                ProductsFillArray(tProduct, products);
            }
            return (Product[])products.ToArray(typeof(Product));//החזרת את המוצרים
        }
        //פונ" שממלא את הרישמה במוצרים
        private void ProductsFillArray(DataRow tProduct, ArrayList products)
        {
            Product productsData = new Product();
            productsData.Id = tProduct[0].ToString();
            productsData.Name = tProduct[1].ToString();
            productsData.Type = tProduct[2].ToString();
            productsData.SupplierName = tProduct[3].ToString();
            productsData.Count = Convert.ToInt32(tProduct[4].ToString());
            productsData.Price = Convert.ToDouble(tProduct[5].ToString());
            if (tProduct[6].ToString() == "")
            {
                productsData.EntryDate = tProduct[6].ToString();
            }
            else
            {
                productsData.EntryDate = tProduct[6].ToString().Substring(0, 10);
            }
            productsData.SupplierId = tProduct[7].ToString();
            products.Add(productsData);
        }
        //פונקציה שמעלה רק את המוצרים שהכמות שלהם גדולה מ0
        public Product[] SelectProductsView(string valueToSearch)
        {
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = "SELECT * FROM Products WHERE (ProductID + ' ' + Name like '%" + valueToSearch + "%') AND Status=True" +
                " AND ProductCount>0";//שאילתה שלוקחת את המוצרים שהכמות שלהם גדולה מ0
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tProduct in dt.Rows)
            {
                ProductViewFillArray(tProduct, products);
            }
            return (Product[])products.ToArray(typeof(Product));//החזרת את המוצרים
        }
        //פרו" שממלא את הרשימה
        private void ProductViewFillArray(DataRow tProduct, ArrayList products)
        {
            Product productsData = new Product();
            productsData.Id = tProduct[0].ToString();
            productsData.Name = tProduct[1].ToString();
            productsData.Type = tProduct[2].ToString();
            productsData.SupplierName = tProduct[3].ToString();
            productsData.Count = Convert.ToInt32(tProduct[4].ToString());
            productsData.Price = Convert.ToDouble(tProduct[5].ToString());
            if (tProduct[6].ToString() == "")
            {
                productsData.EntryDate = tProduct[6].ToString();
            }
            else
            {
                productsData.EntryDate = tProduct[6].ToString().Substring(0, 10);
            }

            products.Add(productsData);
        }

        //העלאת הספקים מבסיס הנתונים
        public Supplier[] SelectSuppliers(string valueToSearch)
        {
            DataSet ds = new DataSet();
            ArrayList suppliers = new ArrayList();
            string cmdStr = "SELECT * FROM Suppliers WHERE (SupplierId + ' ' + " +
                "Name + ' ' + PhoneNumber + ' ' + Email like '%" + valueToSearch + "%') AND Status=True";//שאילתה שלוקחת את כל הספקים
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tsupplier in dt.Rows)
            {
                SuppliersFillArray(tsupplier, suppliers);
            }
            return (Supplier[])suppliers.ToArray(typeof(Supplier));//החזרת את הספקים
        }
        private void SuppliersFillArray(DataRow tsupplier, ArrayList suppliers)
        {
            Supplier supplierData = new Supplier();
            supplierData.Id = tsupplier[0].ToString();
            supplierData.Name = tsupplier[1].ToString();
            supplierData.PhoneNumber = tsupplier[2].ToString();
            supplierData.ContactName = tsupplier[3].ToString();
            supplierData.Address = tsupplier[4].ToString();
            supplierData.Email = tsupplier[5].ToString();
            suppliers.Add(supplierData);
        }
        public Client[] selectClients(string valueToSearch)
        {
            DataSet ds = new DataSet();
            ArrayList clients = new ArrayList();
            string cmdStr = "SELECT * FROM Clients WHERE (ClientId + ' ' + " +
                "Name + ' ' + LastName + ' ' + PhoneNumber + ' ' + Email like '%" + valueToSearch + "%') AND Status=True";//שאילתה שלוקחת את כל הלקוחות
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tclient in dt.Rows)
            {
                ClientFillArray(tclient, clients);
            }
            return (Client[])clients.ToArray(typeof(Client));//החזרת את הלקוחות
        }
        private void ClientFillArray(DataRow tclient, ArrayList clients)
        {
            Client clientData = new Client();
            clientData.IdNumber = tclient[0].ToString();
            clientData.Name = tclient[1].ToString();
            clientData.LastName = tclient[2].ToString();
            clientData.PhoneNumber = tclient[3].ToString();
            clientData.Address = tclient[4].ToString();
            clientData.Email = tclient[5].ToString();
            clients.Add(clientData);
        }
        
        public Order[] SelectOrders(DateTime datePlacingOrdermin, DateTime datePlacingOrderMax, string valueToSearch)
        {
            datePlacingOrderMax = datePlacingOrderMax.AddDays(1);
            DataSet ds = new DataSet();
            ArrayList orders = new ArrayList();
            string cmdStr = "SELECT OrderId,Clients.ClientId,Orders.DatePlacing,TotalPrice,Clients.Name,Clients.LastName FROM Orders INNER JOIN Clients ON Orders.ClientId=Clients.ClientId WHERE " +
                "(((Orders.DatePlacing)>=#"+datePlacingOrdermin.ToString("ss:mm:hh yyyy/MM/dd") + "# And (Orders.DatePlacing)<=#" + datePlacingOrderMax.ToString("ss:mm:hh yyyy/MM/dd") +"#)) AND " +
                "(Clients.ClientId + ' ' + " +
                "Clients.Name + ' ' + Clients.LastName like '%" + valueToSearch + "%')";//שאילתה שלוקחת את כל  הזמנות לפי תאריך 
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tOrder in dt.Rows)
            {
                OrderFillArray(tOrder, orders);
            }
            return (Order[])orders.ToArray(typeof(Order));//החזרת את ההזמנות
        }
        private void OrderFillArray(DataRow tOrder, ArrayList orders)
        {
            Order orderData = new Order();
            orderData.Id = Convert.ToInt32(tOrder[0]);
            orderData.ClientId = tOrder[1].ToString();
            orderData.DatePlacingOrder = Convert.ToDateTime(tOrder[2].ToString());
            orderData.TotalPrice = Convert.ToDouble(tOrder[3]);
            orderData.ClientName = tOrder[4].ToString();
            orderData.ClientLastName = tOrder[5].ToString();
            orders.Add(orderData);
        }
        public Product[] SelectOrderDetails(int orderId)
        {
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = "SELECT Products.ProductID,Products.Name,Products.Price,OrdersDetails.ProductCount FROM OrdersDetails " +
                "INNER JOIN Products ON OrdersDetails.ProductId=Products.ProductID" +
                " WHERE OrderId="+orderId;
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tOrder in dt.Rows)
            {
                Product orderData = new Product();
                orderData.Id = tOrder[0].ToString();
                orderData.Name = tOrder[1].ToString();
                orderData.Price = Convert.ToDouble(tOrder[2]);
                orderData.Count = Convert.ToInt32(tOrder[3]);
                products.Add(orderData);
            }
            return (Product[])products.ToArray(typeof(Product));//החזרת את ההזמנות
        }
        public Seller[] UserWorkDetails(string userId)
        {
            DataSet ds = new DataSet();
            ArrayList sellers = new ArrayList();
            string cmdStr = "SELECT UsersWork.EntryDay,UsersWork.EndDay,UsersWork.HoursWork FROM Users " +
                "INNER JOIN UsersWork ON Users.UserId = UsersWork.UserId" +
                " WHERE UsersWork.UserId='" + userId+"'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tOrder in dt.Rows)
            {
                Seller sellerData = new Seller();
                sellerData.StartDay = tOrder[0].ToString();
                sellerData.EndDay = tOrder[1].ToString();
                sellerData.BusinessHours = Convert.ToDouble(tOrder[2]);
                sellers.Add(sellerData);
            }
            return (Seller[])sellers.ToArray(typeof(Seller));//החזרת את הנתונים הרלוונטים
        }

        public Client selectClientsSearchId(string id)
        {
            DataSet ds = new DataSet();
            Client client = new Client();
            string cmdStr = "SELECT * FROM Clients WHERE ClientId='" + id + "' AND Status=True";//שאילתה שלוקחת את כל הלקוחות
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tclient in dt.Rows)
            {
                client.IdNumber = tclient[0].ToString();
                client.Name = tclient[1].ToString();
                client.LastName = tclient[2].ToString();
                client.PhoneNumber = tclient[3].ToString();
                client.Address = tclient[4].ToString();
                client.Email = tclient[5].ToString();
            }
            return client;//החזרת את הלקוחות
        }



        //פונקציה שמעלה את הסוגים מבסיס הנתונים
        public Type[] SelectTypes()
        {
            DataSet ds = new DataSet();
            ArrayList types = new ArrayList();
            string cmdStr = "SELECT * FROM ProductTypes WHERE Status=True";//שאילתה שלוקחת את כל הסוגים
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tType in dt.Rows)
            {
                Type typesData = new Type();
                typesData.Id = Convert.ToInt32(tType[0].ToString());
                typesData.Name = tType[1].ToString();
                types.Add(typesData);
            }
            return (Type[])types.ToArray(typeof(Type));//החזרת את המערך
        }

      

       


        //העלאת המנהלים לא כולל המנהל שנכנס למערכת
        public Manager[] SelectManagers(string valueToSearch,String userName)
        {
            DataSet ds = new DataSet();
            ArrayList managers = new ArrayList();
            string cmdStr = "SELECT UserId,UserRealName,UserLastName,UserPhoneNumber,UserAddress,UserEmail,UserName,UserEntryDate" +
                " FROM (Users) WHERE (UserId + ' ' + UserName + ' ' + UserLastName +" +
                " ' ' + UserPhoneNumber + ' ' + UserEmail like '%" + valueToSearch + "%') AND Status=True AND UserName <> '" + userName+ "' AND ManagerOrSeller=False";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tManager in dt.Rows)
            {
                ManagerFillArray(tManager, managers);
            }
            return (Manager[])managers.ToArray(typeof(Manager));//החזרת את המנהל
        }
        private void ManagerFillArray(DataRow tManager, ArrayList managers)
        {
            Manager managerData = new Manager();
            managerData.IdNumber = tManager[0].ToString();
            managerData.Name = tManager[1].ToString();
            managerData.LastName = tManager[2].ToString();
            managerData.PhoneNumber = tManager[3].ToString();
            managerData.Address = tManager[4].ToString();
            managerData.Email = tManager[5].ToString();
            managerData.UserName = tManager[6].ToString();
            managerData.EntryDate = Convert.ToDateTime(tManager[7]);
            managers.Add(managerData);
        }
        //העלאת מנהל יחיד לפי שם משתמש או מייל
        public Manager SelectManager(string userName)
        {
            DataSet ds = new DataSet();
            Manager managerData = new Manager();
            string cmdStr = "SELECT * FROM (Users) WHERE (((UserName='" + userName + "'"+ ") OR (UserEmail='"+ userName+"')) AND Status=True AND ManagerOrSeller=False)";//את המנהל שיש לו את השם משתמש הזה
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tManager in dt.Rows)
            {
                managerData.IdNumber = tManager[0].ToString();
                managerData.Name = tManager[1].ToString();
                managerData.LastName = tManager[2].ToString();
                managerData.PhoneNumber = tManager[3].ToString();
                managerData.Address = tManager[4].ToString();
                managerData.Email = tManager[5].ToString();
                managerData.UserName = tManager[6].ToString();
                managerData.Password = tManager[7].ToString();
            }
            return managerData;
        }
        //העלאת כל המוכרים הפעילים
        public Seller[] SelectSellers(string valueToSearch)
        {
            DataSet ds = new DataSet();
            ArrayList sellers = new ArrayList();
            string cmdStr = "SELECT UserId,UserRealName,UserLastName,UserPhoneNumber,UserAddress,UserEmail,UserName," +
                "UserEntryDate,UserWorkHours" +
                " FROM (Users) WHERE (UserId + ' ' + UserName + ' ' + UserLastName +" +
                " ' ' + UserPhoneNumber + ' ' + UserEmail like '%" + valueToSearch + "%') AND Status=True AND ManagerOrSeller=True";//שאילתה מעלה את את כל המוכרים שהם פעילים
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tSeller in dt.Rows)
            {
                SellerFillArray(tSeller, sellers);
            }
            return (Seller[])sellers.ToArray(typeof(Seller));//החזרת את כל המוכרים הפעילים
        }
        private void SellerFillArray(DataRow tSeller, ArrayList sellers)
        {
            Seller sellerData = new Seller();
            sellerData.IdNumber = tSeller[0].ToString();
            sellerData.Name = tSeller[1].ToString();
            sellerData.LastName = tSeller[2].ToString();
            sellerData.PhoneNumber = tSeller[3].ToString();
            sellerData.Address = tSeller[4].ToString();
            sellerData.Email = tSeller[5].ToString();
            sellerData.UserName = tSeller[6].ToString();
            sellerData.EntryDate = Convert.ToDateTime(tSeller[7]);
            sellerData.BusinessHours = Convert.ToDouble(tSeller[8]);
            sellers.Add(sellerData);
        }
        //העלאת מוכר לפי שם משתמש או מייל
        public Seller SelectSeller(string userName)
        {
            DataSet ds = new DataSet();
            Seller seller = new Seller();
            string cmdStr = "SELECT * FROM (Users) WHERE (((UserName='" + userName + "') OR (UserEmail='" + userName + "') OR (UserId='"+userName+"'))" +
                " AND Status=true AND ManagerOrSeller=True)";//להוציא את המוכר שיש לו את השם משתמש הזה
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tSeller in dt.Rows)
            {
                return sellerData(seller,tSeller);
            }
            return seller;
        }
        private Seller sellerData(Seller seller, DataRow tSeller)
        {
            seller.IdNumber = tSeller[0].ToString();
            seller.Name = tSeller[1].ToString();
            seller.LastName = tSeller[2].ToString();
            seller.PhoneNumber = tSeller[3].ToString();
            seller.Address = tSeller[4].ToString();
            seller.Email = tSeller[5].ToString();
            seller.UserName = tSeller[6].ToString();
            seller.Password = tSeller[7].ToString();
            seller.EntryDate = Convert.ToDateTime(tSeller[8].ToString());
            seller.BusinessHours = Convert.ToDouble(tSeller[9]);
            return seller;
        }
        public Supplier SelectSupplier(string supplierId)
        {
            DataSet ds = new DataSet();
            Supplier supplierData = new Supplier();
            string cmdStr = "SELECT * FROM (Suppliers) WHERE SupplierId='" + supplierId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tSupplier in dt.Rows)
            {
                supplierData.Id = tSupplier[0].ToString();
                supplierData.Name = tSupplier[1].ToString();
                supplierData.PhoneNumber= tSupplier[2].ToString();
                supplierData.ContactName = tSupplier[3].ToString();
                supplierData.Address = tSupplier[4].ToString();
                supplierData.Email = tSupplier[5].ToString();
            }
            return supplierData;
        }

        ////////////////////
        ///select Names
        public string[] SelectCitiesNames()
        {
            int i = 0;
            DataSet ds = new DataSet();
            int countCities = CountCities();
            string[] citiesNames = new string[countCities];
            string cmdStr = "SELECT CitiesNames FROM Cities";//שאילתה שלוקחת את כל הערים
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tCities in dt.Rows)
            {
                citiesNames[i++] = tCities[0].ToString();
            }
            return citiesNames;
        }
        //להוציא את הת.ז של הלקוח
        public Client[] SelectClientsIdName()
        {
            int i = 0;
            DataSet ds = new DataSet();
            ArrayList clients = new ArrayList();
            string cmdStr = "SELECT ClientId,Name FROM Clients WHERE Status=True";//שאילתה שלוקחת את כל הלקוחות
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tClients in dt.Rows)
            {
                Client clientsIdName = new Client();
                clientsIdName.IdNumber = tClients[0].ToString();
                clientsIdName.Name = tClients[1].ToString();
                clients.Add(clientsIdName);
            }
            return (Client[])clients.ToArray(typeof(Client)); ;
        }



        //להוציא רק את השמות של הסוגים
        public string[] SelectTypesNamesId()
        {
            int i = 0;
            DataSet ds = new DataSet();
            int countTypes = CountTypes();
            string[] typesNames = new string[countTypes];
            string cmdStr = "SELECT TypeCode,TypeName FROM ProductTypes WHERE Status=true";//שאילתה שלוקחת את כל המוצרים
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tTypes in dt.Rows)
            {
                typesNames[i++] = tTypes[1].ToString()+"-"+ tTypes[0].ToString();
            }
            return typesNames;
        }

        //להוציא רק את השמות והקוד של הספקים
        public string[] SelectSuppliersNamesId()
        {
            int i = 0;
            DataSet ds = new DataSet();
            int countSuppliers = CountSuppliers();
            string[] suppliersNamesId = new string[countSuppliers];
            string cmdStr = "SELECT SupplierId,Name FROM Suppliers WHERE Status=True";//שאילתה שלוקחת את כל הספקים
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tSupplier in dt.Rows)
            {
                suppliersNamesId[i++] = tSupplier[1].ToString()+"-"+ tSupplier[0].ToString();
            }
            return suppliersNamesId;
        }

        public string SelectProductColorButton(string typeId)
        {
            string cmdStr = "SELECT Color FROM ProductTypes WHERE TypeCode="+ typeId;
            DataSet ds = new DataSet();
            string color;
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                color = ExecuteScalarStringQuery(command);
            }
            return color;
        }

        

        //הפונקציה מיבא את המוצר שבחר המוכר למכור
        public Product SelectProduct(string productId)
        {
            int i = 0;
            DataSet ds = new DataSet();
            int countProducts = CountProducts();
            Product product = new Product();
            string cmdStr = "SELECT ProductID,Name,Price,ProductCount FROM Products WHERE ProductID='"+ productId+"' AND Status=True";//שאילתה שמיבא רק את מוצר אחד 
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tProduct in dt.Rows)
            {
                product.Id = tProduct[0].ToString();
                product.Name = tProduct[1].ToString();
                product.Price = Convert.ToDouble(tProduct[2]);
                product.Count = Convert.ToInt32(tProduct[3]);
            }
            return product;
        }
        

        ////////////////////////////
        ///login

        //המשתמש מתחבר למערכת
        public bool Login(string userName, string password)
        {
            int result;
            //לבדוק אם המשתמש קיים במערכת לפי השם משתמש או המייל וגם הסיסמא
            string cmdStr = "SELECT COUNT (*) FROM (Users)" +
             "WHERE ((UserName ='" + userName + "') OR (UserEmail ='" + userName + "')) AND (UserPassword ='" + password + "') AND Status=True";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@UserEmail", userName);
                command.Parameters.AddWithValue("@UserPassword", password);
                result = ExecuteScalarIntQuery(command);
            }
            if (result == 1)
                return true;
            else
                return false;
        }

        //המנהל מתחבר למערכת
        public bool LoginSeller(string userName, string password)
        {
            int result;
            //לבדוק אם המנהל קיים במערכת לפי השם משתמש או המייל וגם הסיסמא
            string cmdStr = "SELECT COUNT (*) FROM (Sellers)" +
             "WHERE ((SellerUserName ='" + userName + "') OR (SellerEmail ='" + userName + "')) AND (SellerPassword ='" + password + "')";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@SellerUserName", userName);
                command.Parameters.AddWithValue("@SellerEmail", userName);
                command.Parameters.AddWithValue("@SellerPassword", password);
                result = ExecuteScalarIntQuery(command);
            }
            if (result == 1)
                return true;
            else
                return false;
        }


        ///////////////////////////////////////////////////////
        //Select Count
        public int CountProducts()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Products WHERE Status=True";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        //כמות המוצרים שהכמות שלהם גדולה מ0
        public int CountProductView()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Products WHERE Status=True AND ProductCount>0";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        public int CountTypes()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM ProductTypes WHERE Status=True";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        public int CountSuppliers()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Suppliers WHERE Status=True";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        public int CountCities()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Cities";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        public int CountClients()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Clients WHERE Status=True";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        //לספור את כל ההזמנות
        public int CountOrders()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Orders";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        //כמות ההזמנות שהלקוח בצע
        public int CountOrdersDetails()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM OrdersDetails";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        
        public int CountWorkDetails(string userId)
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Users INNER JOIN UsersWork ON Users.UserId=UsersWork.UserId" +
                " WHERE Users.Status=true AND UsersWork.UserId='" + userId+"'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }


        //לספור רק את הפריטים שיש להם רק את הקוד הזה שקבלה הפונקציה
        public int CountOrderDetails(int orderId)
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM OrdersDetails WHERE OrderId="+orderId;
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        //כולל הכל
        public int CountManager()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Users WHERE Status=True AND ManagerOrSeller=False";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        //לא כולל המנהל הנוכחי
        public int CountManager(string userName)
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Users WHERE Status=True AND UserName <> '" + userName + "' AND ManagerOrSeller=False";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        public int CountSellers()
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM Users WHERE Status=True AND ManagerOrSeller=True";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
     

        /////////////////////////////////////////////////
        ///Update 
        public void UpdateProduct(Product product)
        {
            string cmdStr = "UPDATE Products SET Name=@product.Name,TypeId=@product.Type,SupplierId=@product.SupplierName," +
                "ProductCount=@product.Count,Price=@product.Price,EntryDate=@product.EntryDate,Status=True WHERE ProductID=@product.Id";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@TypeId", product.Type);
                //קוד ספק 
                command.Parameters.AddWithValue("@SupplierId", product.SupplierName);
                command.Parameters.AddWithValue("@ProductCount", product.Count);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@EntryDate", product.EntryDate);
                command.Parameters.AddWithValue("@ProductID", product.Id);
                base.ExecuteSimpleQuery(command);


            }
        }
        //עדכון פרטי הלקוח
        public bool UpdateClient(Client client)
        {
            //אם יש יותר מהלקוח הנכוחי עם הפרטים האלה אז לא יצליח להכניס, יהיה כפולות של פריטים חשובים
            if (CheckClient(client) > 1)
            {
                return false;
            }
            string cmdStr = "UPDATE Clients SET Name=@client.Name,LastName=@client.LastName,PhoneNumber=@client.PhoneNumber," +
                "Address=@client.Address,Email=@client.Email,Status=True WHERE ClientID=@client.IdNumber";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@Name", client.Name);
                command.Parameters.AddWithValue("@LastName", client.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", client.PhoneNumber);
                command.Parameters.AddWithValue("@Address", client.Address);
                command.Parameters.AddWithValue("@Email", client.Email);
                command.Parameters.AddWithValue("@ClientID", client.IdNumber);
                base.ExecuteSimpleQuery(command);
            }
            return true;
        }

        //עדכון פרטי הספק
        public bool UpdateSupplier(Supplier supplier)
        {
            //אם יש יותר מהספק הנכוחי עם הפרטים האלה אז לא יצליח להכניס, יהיה כפולות של פריטים חשובים
            if (CheckSupplier(supplier) > 1)
            {
                return false;
            }
            string cmdStr = "UPDATE suppliers SET Name=@supplier.Name,PhoneNumber=@supplier.PhoneNumber,ContactName=@supplier.ContactName," +
               "Address=@supplier.Address,Email=@supplier.Email,Status=True WHERE SupplierId=@supplier.Id";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@Name", supplier.Name);
                command.Parameters.AddWithValue("@PhoneNumber", supplier.PhoneNumber);
                command.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                command.Parameters.AddWithValue("@Address", supplier.Address);
                command.Parameters.AddWithValue("@Email", supplier.Email);
                command.Parameters.AddWithValue("@SupplierId", supplier.Id);
                base.ExecuteSimpleQuery(command);

            }
            return true;
        }
        //עדכון המוכר
        public bool UpdateSeller(Seller seller)
        {
            //אם יש יותר מהמוכר הנכוחי עם הפרטים האלה אז לא יצליח להכניס, יהיה כפולות של פריטים חשובים
            if (CheckSeller(seller) > 1)
            {
                return false;
            }
            string cmdStr = "UPDATE Users SET UserRealName=@seller.Name,UserLastName=@seller.LastName,UserPhoneNumber=@seller.PhoneNumber," +
               "UserAddress=@seller.Address,UserEmail=@seller.Email,UserName=@seller.UserName,Status=True WHERE UserId=@seller.IdNumber";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@UserRealName", seller.Name);
                command.Parameters.AddWithValue("@UserLastName", seller.LastName);
                command.Parameters.AddWithValue("@UserPhoneNumber", seller.PhoneNumber);
                command.Parameters.AddWithValue("@UserAddress", seller.Address);
                command.Parameters.AddWithValue("@UserEmail", seller.Email);
                command.Parameters.AddWithValue("@UserName", seller.UserName);
                command.Parameters.AddWithValue("@UserId", seller.IdNumber);
                base.ExecuteSimpleQuery(command);
            }
            return true;
        }

        public bool UpdateManager(Manager manager)
        {
            //אם יש יותר מהמנהל חוץ הנכוחי עם הפרטים האלה אז לא יצליח להכניס, יהיה כפולות של פריטים חשובים
            if (CheckManager(manager) > 1)
            {
                return false;
            }
            string cmdStr = "UPDATE Users SET UserRealName=@manager.Name,UserLastName=@manager.LastName,UserPhoneNumber=@manager.PhoneNumber," +
               "UserAddress=@manager.Address,UserEmail=@manager.Email,UserName=@manager.UserName,Status=True WHERE UserId=@manager.IdNumber";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@UserRealName", manager.Name);
                command.Parameters.AddWithValue("@UserLastName", manager.LastName);
                command.Parameters.AddWithValue("@UserPhoneNumber", manager.PhoneNumber);
                command.Parameters.AddWithValue("@UserAddress", manager.Address);
                command.Parameters.AddWithValue("@UserEmail", manager.Email);
                command.Parameters.AddWithValue("@UserName", manager.UserName);
                command.Parameters.AddWithValue("@UserId", manager.IdNumber);
                base.ExecuteSimpleQuery(command);
            }
            return true;
        }
        //לעדכן את הצבע של הסוג
        public void UpdateTypeColor(string color,long typeId)
        {
            string cmdStr = "UPDATE ProductTypes SET Color='"+ color+"' WHERE Status=True AND TypeCode="+ typeId;
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@Color", color);
                command.Parameters.AddWithValue("@TypeCode", typeId);
                base.ExecuteSimpleQuery(command);
            }
        }
        //להוריד את הכמות מהמלאי
        public void UpdateProductCountDown(string productId, int countProduct, int CountClient)
        {

            string cmdStr = "UPDATE Products SET ProductCount=@product.Count WHERE ProductID='" + productId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@ProductCount", countProduct - CountClient);
                command.Parameters.AddWithValue("@ProductID", productId);
                base.ExecuteSimpleQuery(command);

            }
        }

        // להוסיף למלאי
        public void UpdateProductCountUp(string productId, int countProduct)
        {
            int result;
            string cmdStr = "Select ProductCount From Products WHERE  ProductID='" + productId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            cmdStr = "UPDATE Products SET ProductCount=@product.Count WHERE ProductID='" + productId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@ProductCount", countProduct + result);
                command.Parameters.AddWithValue("@ProductID", productId);
                base.ExecuteSimpleQuery(command);

            }
        }
        //////////////////////////////////////////////
        ///אסור לי למחוק מידע מסיס הנתונים , כאילו אני מוחק את המידע אבל לא , אני משנה אותו ללא פעיל
        ///Delete 
        public void DeleteProduct(string productId)
        {
            //שאילתה שמאפשרת מחיקה מבסיס התונים
            string cmdStr = "UPDATE Products SET Status=False WHERE ProductID='" + productId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {

                base.ExecuteSimpleQuery(command);
            }
        }
        public void DeleteClient(string clientId)
        {
            //שאילתה שמאפשרת מחיקה מבסיס התונים
            string cmdStr = "UPDATE Clients SET Status=False WHERE ClientId='" + clientId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }
        public void DeleteSupplier(string supplierId)
        {
            //שאילתה שמאפשרת מחיקה מבסיס התונים
            string cmdStr = "UPDATE Suppliers SET Status=False WHERE SupplierId='" + supplierId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {

                base.ExecuteSimpleQuery(command);
            }

        }
        //מחיקת מוכר
        public void DeleteSeller(string sellerId)
        {
            //שאילתה שמאפשרת מחיקה מבסיס התונים
            string cmdStr = "UPDATE Users SET Status=False WHERE UserId='" + sellerId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {

                base.ExecuteSimpleQuery(command);
            }

        }
        //מחיקת מנהל
        public void DeleteManager(string managerId)
        {
            //שאילתה שמאפשרת מחיקה מבסיס התונים
            string cmdStr = "UPDATE Users SET Status=False WHERE UserId='" + managerId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {

                base.ExecuteSimpleQuery(command);
            }

        }

        public void DeleteType(string typeName)
        {
            //שאילתה שמאפשרת מחיקה מבסיס התונים
            string cmdStr = "UPDATE ProductTypes SET Status=False WHERE TypeName='" + typeName + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }

        public void DeleteWorkHours(string userId)
        {
            //שאילתה שמאפשרת מחיקה מבסיס התונים
            string cmdStr = "DELETE FROM UsersWork WHERE UserId='"+userId+"'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                base.ExecuteSimpleQuery(command);
            }
        }




        /////////////////////////////////////////////
        ///Special Update 
        /// האיפוס סיסמא 

        //אם הוא פעיל אז המשתמש צריך לאפס את הסיסמא
        public void RestPassUserTrue(string userId)
        {
            //שאילתה שמאפשרת שינוי סטטוס
            string cmdStr = "UPDATE Users SET RestPass=True WHERE UserId='" + userId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {

                base.ExecuteSimpleQuery(command);
            }

        }

        //הפונקציה מקבלת את שם המשתמש של המשתמש ובודקת אם הוא צריך לאפס את הסיסמא או לא
        public bool RestPassCheckTorFUser(string userName)
        {
            //אם הוא הסטטוס של האיפוס סיסמא פעיל
            int result = 0;
            string cmdStr = "SELECT count(*) FROM Users WHERE ((UserName ='" + userName + "') OR (UserEmail='"+ userName+"')) AND RestPass=True";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            if (result > 0)
            {
                return true;
            }
            return false;
        }
         //בדיקה אם הוא מנהל
        public bool CheckManager(string userName)
        {
           
            int result = 0;
            string cmdStr = "SELECT count(*) FROM Users WHERE (((UserName = '" + userName + "') OR (UserEmail='"+ userName+"')) AND Status=True AND ManagerOrSeller=False)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        //בדיקה אם הוא מוכר
        public bool CheckSeller(string userName)
        {
            //אם הוא הסטטוס של האיפוס סיסמא פעיל
            int result = 0;
            string cmdStr = "SELECT count(*) FROM Users WHERE (((UserName ='" + userName + "') OR (UserEmail='"+ userName+"')) AND Status=True AND ManagerOrSeller=True)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            if (result > 0)
            {
                return true;
            }
            return false;
        }
        //איפוס סיסמא
        public void RestPassUser(string userName, string password)
        {
            //שאילתה שמאפשרת שינוי סטטוס
            string cmdStr = "UPDATE Users SET UserPassword='" + password + "',RestPass=False WHERE (UserEmail='" + userName + "' OR UserName='"+ userName+"')";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@UserPassword", password);
                command.Parameters.AddWithValue("@UserName", userName);
                base.ExecuteSimpleQuery(command);
            }
        }
        //שחזור סיסמא
        public bool RestPassUserEmail(string userEmail, string password)
        {
            int result;
            string cmdStr = "SELECT COUNT (*) FROM (Users) WHERE UserEmail='" + userEmail + "' AND Status=True";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@UserEmail", userEmail);
                result = ExecuteScalarIntQuery(command);
            }
            //אם הדואר האלקטרוני לא קיים במערכת מחזירה שקר
            if (result == 0)
            {
                return false;
            }

            //שאילתה שמאפשרת שינוי סטטוס
             cmdStr = "UPDATE Users SET UserPassword='" + password + "',RestPass=True WHERE UserEmail='" + userEmail + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@UserPassword", password);
                command.Parameters.AddWithValue("@UserEmail", userEmail);
                base.ExecuteSimpleQuery(command);
            }
            return true;
        }

        /////////////////////
        ///שעות עבודה
        //עדכון שעות עבודה של מוכר
        public void businessHours(Seller seller)
        {
            //שאילתה שמאפשרת שינוי סטטוס
            string cmdStr = "UPDATE Users SET UserWorkHours=UserWorkHours+@seller.BusinessHours WHERE UserEmail='" + seller.Email+"'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@UserWorkHours", seller.BusinessHours);
                command.Parameters.AddWithValue("@UserEmail", seller.Email);
                base.ExecuteSimpleQuery(command);
            }
        }
        //איפוס שעות המוכר
        public void businessHoursRest(string sellerId)
        {
            //שאילתה שמאפשרת איפוס שעות מוכר
            string cmdStr = "UPDATE Users SET UserWorkHours=0 WHERE UserId='" + sellerId + "'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@UserWorkHours", 0);
                command.Parameters.AddWithValue("@UserId", sellerId);
                base.ExecuteSimpleQuery(command);
            }
        }

        ///////////////////////////////////
        ///סטטיסטיקה
        public Product[] SelectstatisticsMax(DateTime minDate, DateTime maxDate)
        {
            maxDate=maxDate.AddDays(1);
            int result = 0;
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = CmdStringMaxStatstics(minDate, maxDate);
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tProduct in dt.Rows)
            {
                Product productsData = new Product();
                productsData.Id = tProduct[0].ToString();
                productsData.Name = tProduct[1].ToString();
                productsData.Count = Convert.ToInt32(tProduct[2]);
                products.Add(productsData);
            }
           
            return (Product[])products.ToArray(typeof(Product));//החזרת את המוצרים
        }
        private String CmdStringMaxStatstics(DateTime minDate, DateTime maxDate)
        {
            return "SELECT TOP 4 Products.ProductID,Products.Name,SUM(OrdersDetails.ProductCount) " +
                "FROM Products INNER JOIN (Orders INNER JOIN OrdersDetails ON Orders.OrderId = OrdersDetails.OrderId) ON Products.ProductID = OrdersDetails.ProductId" +
                " Where [Dateplacing] BETWEEN #" +
                minDate.ToString("yyyy-MM-dd") + "# AND #" + maxDate.ToString("yyyy-MM-dd") + "#" +
                " group by Products.ProductID,Products.Name " +
                "ORDER BY Sum(OrdersDetails.ProductCount) DESC";
        }
        public Product[] SelectstatisticsMin(DateTime minDate, DateTime maxDate)
        {
            maxDate=maxDate.AddDays(1);
            int result = 0;
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = CmdStringMinStatstics(minDate, maxDate);
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            //לולאה שמכניסה את הנתונים למערך מסודר
            foreach (DataRow tProduct in dt.Rows)
            {
                Product productsData = new Product();
                productsData.Id = tProduct[0].ToString();
                productsData.Name = tProduct[1].ToString();
                productsData.Count = Convert.ToInt32(tProduct[2]);
                products.Add(productsData);
            }
            return (Product[])products.ToArray(typeof(Product));//החזרת את המוצרים
        }
        private string CmdStringMinStatstics(DateTime minDate, DateTime maxDate)
        {
            return "SELECT TOP 4 Products.ProductID,Products.Name,SUM(OrdersDetails.ProductCount) " +
                "FROM Products INNER JOIN (Orders INNER JOIN OrdersDetails ON Orders.OrderId = OrdersDetails.OrderId) ON Products.ProductID = OrdersDetails.ProductId" +
                " Where [Dateplacing] BETWEEN #" +
                minDate.ToString("yyyy-MM-dd") + "# AND #" + maxDate.ToString("yyyy-MM-dd") + "#" +
                " group by Products.ProductID,Products.Name " +
                "ORDER BY Sum(OrdersDetails.ProductCount) ASC";
        }
        //////////////////
        ///count

        public int Countstatistics()
        {
            //אם הוא הסטטוס של האיפוס סיסמא פעיל
            int result = 0;
            string cmdStr = "SELECT count(*) FROM OrdersDetails group by ProductId";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }

        ////////////////
        ///count productsCount if count of product is zero
        public int CountProductZero()
        {
            int result = 0;
            string cmdStr = "SELECT count(*) FROM Products WHERE ProductCount="+0+" And Status=true";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                result = ExecuteScalarIntQuery(command);
            }
            return result;
        }
        //פרו' שמכניסה לבסיס נתונים ת.ז של מוכר תאריך כניסה ותאריך יציאה ושעות העבודה
        public void StartEndDay(string UserId,DateTime startDay , DateTime endDay,double hoursWork)
        {
           
           string cmdStr = "INSERT INTO UsersWork (UserId,EntryDay,EndDay,HoursWork) VALUES (@UserId,@EntryDay,@EndDay,@HoursWork)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                //הכנסת הנתונים לפי הסדר
                command.Parameters.AddWithValue("@UserId", UserId);
                command.Parameters.AddWithValue("@EntryDay", startDay.ToString("yyyy/MM/dd HH:mm:ss"));
                command.Parameters.AddWithValue("@EndDay", endDay.ToString("yyyy/MM/dd HH:mm:ss"));
                command.Parameters.AddWithValue("@HoursWork",hoursWork);
                base.ExecuteSimpleQuery(command);
            }
            
        }

    }



}






