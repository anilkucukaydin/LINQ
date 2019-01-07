using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        //navigation property -- aşağıda customera git bak onun bilgilerini al anlamına geliyor
        public Customer Customer { get; set; } 
        public static List<Order> GetOrders()
        {
            //veritabanından order tablosundaki verileri çekip
            //bir liste olarak döndürelim 
            List<Order> orders = new List<Order>();
            string query = ("SELECT o.CustomerID,o.EmployeeID,o.OrderID,o.OrderDate,(SELECT ContactName FROM Customers WHERE CustomerID = o.CustomerID) FROM Orders o");
            DataTable dt = new DataTable();
            foreach (DataRow item in dt.Rows)
            {
                Order o = new Order();
                o.OrderID = (int)item["OrderID"];
                o.CustomerID = (string)item["CustomerID"];
                o.EmployeeID = (int)item["EmployeeID"];
                o.OrderDate = (DateTime)item["OrderDate"];
                o.Customer= new Customer();
                o.Customer.ContactName = item["ContactName"].ToString();
                o.Customer.CustomerID = (string)item["CustomerID"];
                orders.Add(o);
            }
            return orders;
        }
        public static DataTable GetDataTable(string query)
        {
            string cs = (@"Server=Wissen\SQLEXPRESS;Database=NORTHWND;User ID = Section1;Trusted_Connection=true;");
            SqlDataAdapter sda = new SqlDataAdapter(query, cs);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }

    class Customer
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public List<Order> Orders { get; set; }
        public int OrderCount
        {
            get
            {
                return Orders.Count;
            }
        }
    }
}

