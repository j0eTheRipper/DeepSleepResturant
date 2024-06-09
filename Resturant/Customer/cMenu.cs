using Resturant.manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Resturant.Customer
{
    public partial class cMenu : Form
    {
        int customerID;
        public cMenu(string username)
        {
            InitializeComponent();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand("SELECT customerID FROM Customer WHERE username=@username;", conn);
                cmd.Parameters.AddWithValue("username", username);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                customerID = reader.GetInt32(0);
            }
        }

        private void menuFilter2_Load(object sender, EventArgs e)
        {

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> itemInfo = menuFilter1.GetItemInfo();
            foreach (DataGridViewRow row in GridItems.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;

                if (row.Cells[0].Value.ToString() == itemInfo["name"])
                {
                    int.TryParse(row.Cells[1].Value.ToString(), out int quantity);
                    quantity += 1;
                    row.Cells[1].Value = quantity;
                    row.Cells[2].Value = quantity * double.Parse(row.Cells[2].Value.ToString());
                    return;
                }
            }
            GridItems.Rows.Add(itemInfo["name"], 1, itemInfo["price"]);
        }

        private void GridItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> itemInfo = menuFilter1.GetItemInfo();
            foreach (DataGridViewRow row in GridItems.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;

                if (row.Cells[0].Value.ToString() == itemInfo["name"])
                {
                    int.TryParse(row.Cells[1].Value.ToString(), out int quantity);
                    if (quantity == 1)
                    {
                        GridItems.Rows.Remove(row);
                        return;
                    }
                    quantity -= 1;
                    row.Cells[1].Value = quantity;
                    row.Cells[2].Value = quantity * double.Parse(itemInfo["price"]);
                    return;
                }
            }
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void cMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblcount_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> itemInfo = menuFilter1.GetItemInfo();
            lblcount.Text = "0";
            for (int i = 0; i < GridItems.Rows.Count; i++)
            {
                if (GridItems.Rows[i].Cells[0].Value != null)
                    lblcount.Text = Convert.ToString(double.Parse(lblcount.Text) + double.Parse(GridItems.Rows[i].Cells[2].Value.ToString()));
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            GridItems.Rows.Clear();
            Dictionary<string, string> itemInfo = menuFilter1.GetItemInfo();
            itemInfo.Clear();

            lblcount.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal totalPrice = decimal.Parse(lblcount.Text);
            List<int> itemIDs = new List<int>();
            foreach (DataGridViewRow row in GridItems.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder
                manage.MenuItem item = new manage.MenuItem(row.Cells[0].Value.ToString());
                itemIDs.Add(item.ItemID);
            }
            ClOrder _Orderto = new ClOrder(customerID, totalPrice, itemIDs);
            _Orderto.AddOrder();
            foreach (int itemID in itemIDs)
            {
                _Orderto.AddItems(itemID);
            }
            MessageBox.Show("The Order Send");
            GridItems.Rows.Clear();
        }

        private void menuFilter1_Load(object sender, EventArgs e)
        {
         
           
        }

        private void lblOrderS_Click(object sender, EventArgs e)
        {

        }

        private void btn2SeeORder_Click(object sender, EventArgs e)
        {
            string OrderStatus = GetOrderStatus();
            lblOrderS.Text = $"Your Order Status is: {OrderStatus}";
        }


        private string GetOrderStatus()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                {
                    SqlCommand cmd = new SqlCommand("SELECT name, totalPrice, status FROM [Order] join Items2Order on Items2Order.OrderID = [Order].orderID join Item on Items2Order.itemID = Item.itemID;", connection);
                    //cmd.Parameters.AddWithValue("@status", status);
                    string OrderStatus = "inProgress";

                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        OrderStatus = "Ready";
                    }
                    reader.Close();

                    return OrderStatus;
                }
            }
        }
    }
}
