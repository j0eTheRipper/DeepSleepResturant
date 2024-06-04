using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Resturant.Customer
{
    internal class ClOrder
    {
        private int orderID, customerID, totalPrice, itemID;
        private string stauts;
        private string date;

        public ClOrder(int orderID, int CustomerID, int totalPrice,int itemID, string stauts, string date)
        {
            this.orderID = orderID;
            customerID = CustomerID;
            this.totalPrice = totalPrice;
            this.stauts = stauts;
            this.date = date;
            this.itemID = itemID;
        }

        public int AddOrder()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {

                SqlCommand cmd = new SqlCommand($"SELECT Item. ");

            }


        }


    }
}
