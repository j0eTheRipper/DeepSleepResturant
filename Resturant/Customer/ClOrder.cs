using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Resturant.Customer
{
    internal class ClOrder
    {
        private int orderID, customerID;
        List<int>items;
        private decimal totalPrice;

        public ClOrder(int CustomerID, decimal totalPrice, List<int> items)
        {
            customerID = CustomerID;
            this.totalPrice = totalPrice;
            this.items = items;
        }

        public int AddOrder()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand newOrder = new SqlCommand($"INSERT INTO [Order] (customer, totalprice) values (@customerID, @price); SELECT CAST(scope_identity() as int); ", connection);
                newOrder.Parameters.AddWithValue("customerID", customerID);
                newOrder.Parameters.AddWithValue("price", totalPrice);
                connection.Open();
                SqlDataReader reader = newOrder.ExecuteReader();
                reader.Read();
                this.orderID = reader.GetInt32(0);
                return orderID;
            }
        }

        public void AddItems(int itemID)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand newOrder = new SqlCommand($"INSERT INTO [Items2Order] (OrderID, itemID) values (@orderID, @itemID); ", connection);
                newOrder.Parameters.AddWithValue("orderID", orderID);
                newOrder.Parameters.AddWithValue("itemID", itemID);
                connection.Open();
                newOrder.ExecuteNonQuery();
                
            }
        }
    }

}