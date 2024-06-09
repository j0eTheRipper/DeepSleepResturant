using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.chef
{
    public partial class Manage_Orders : Form
    {
        private ChefOrders chefOrders;

        public Manage_Orders()
        {
            InitializeComponent();
            chefOrders = new ChefOrders();
        }

        private void Manage_Orders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            DataTable orders = chefOrders.GetOrders();               //this method loads the orders from database//
            DataOfOrders.DataSource = orders;                        //it will search orders from database, once it's found it will give data source to //                     
        }                                                            //datagridview//

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("In Progress");                                       //once the button is clicked it will call the method//
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Ready");
        }

        public void UpdateOrderStatus(string newStatus)
        {
            string orderNumberText = txtOrderId.Text;

            if (int.TryParse(orderNumberText, out int orderId))
            {
                bool orderFound = false;
                foreach (DataGridViewRow row in DataOfOrders.Rows) // 'foreach' loop repeats through each row in the DataGridView//
                                                                   //which displays the list of orders.//
                {
                    if (row.Cells["OrderID"].Value != null && Convert.ToInt32(row.Cells["OrderID"].Value) == orderId)
                    {
                        orderFound = true;
                        chefOrders.UpdateOrderStatus(orderId, newStatus);
                        LoadOrders();           

                        // Show message box based on newStatus
                        if (newStatus == "In Progress")
                        {
                            MessageBox.Show("The order is still In Progress. Please wait...");
                        }
                        else if (newStatus == "Ready")
                        {
                            MessageBox.Show("The order is Ready.");
                        }

                        break;
                    }
                }

                if (!orderFound)            // this show message is for the nonfound order//
                {
                    MessageBox.Show("Order not found. Please check the order number and try again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid order number.");
            }
        }

        private void btnBackManageOrders_Click(object sender, EventArgs e)
        {
            ChefMainPage mainPage = new ChefMainPage();
            mainPage.Show();
            this.Hide();
        }

        public class ChefOrders
        {
            private string connect;

            // Constructor
            public ChefOrders()
            {
                connect = Properties.Settings.Default.YoussefConnection;
            }

            public DataTable GetOrders()
            {
                DataTable DT = new DataTable();
                try
                {
                    using (SqlConnection conn = new SqlConnection(connect))
                    {
                        conn.Open();
                        SqlDataAdapter DA = new SqlDataAdapter("SELECT OrderID, customer, totalPrice, date, status FROM [Order]", conn); //create adapter with sql query//
                        DA.Fill(DT);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching orders: " + ex.Message);
                }
                return DT;
            }

            public void UpdateOrderStatus(int orderId, string newStatus)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connect))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE [Order] SET status = @status WHERE OrderID = @OrderID", conn);
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@OrderID", orderId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating order status: " + ex.Message);
                }
            }
        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataOfOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
