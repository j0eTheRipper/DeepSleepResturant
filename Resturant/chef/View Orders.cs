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
    public partial class View_Orders : Form
    {
        private OrderView orderView;       
        public View_Orders()    
        {
            InitializeComponent();
            orderView = new OrderView();    
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBackOrd_Click(object sender, EventArgs e)
        {
            ChefMainPage mainPage = new ChefMainPage();
            mainPage.Show();
            this.Hide();
        }


        private void View_Orders_Load(object sender, EventArgs e)
        {
            LoadOrders();                  
        }

        private void LoadOrders()
        {
            DataTable orders = orderView.GetOrders();   
            ViewList.DisplayMember = "OrderID";     
            ViewList.ValueMember = "OrderID";        
            ViewList.DataSource = orders;           //to fetch from the datatable for the orders
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (ViewList.SelectedItem != null)              
            {
                int selectedOrderId = (int)ViewList.SelectedValue;  //it retrieves the selectedvalue from the viewlist ,and assigns it to the variable selectedorderid
                DisplayOrderDetails(selectedOrderId);               // it calls the DisplayOrderDetails method and  passes the selectedOrderId as a parameter
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

      
        
        }

        private void DisplayOrderDetails(int orderId)
        {
            DataRow orderDetails = orderView.GetOrderDetails(orderId);      // it fetch from order details for the orderID from the database
            if (orderDetails != null)      
            {
                lblCustomerID.Text = orderDetails["customer"].ToString();   //to show the customerID from label lblCustomerID for order details
                lblTotalShow.Text = orderDetails["totalPrice"].ToString();  // to show the price from label lblTotalShow 
                lblshowDate.Text = Convert.ToDateTime(orderDetails["date"]).ToString("d"); // to show date from label lblShowDate and formatted ony for date
                lblStatusShow.Text = orderDetails["status"].ToString();                    // to show the order status from lblStatusShow 
            }
        }







    }






    public class OrderView
    {
        private string connect;

       
        public OrderView()
        {
            connect = Properties.Settings.Default.YoussefConnection;
        }

        public DataTable GetOrders()    // Method to get all orders from the database
        {
            DataTable dt = new DataTable(); 
            try
            {
                using (SqlConnection conn = new SqlConnection(connect))  
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT OrderID, customer, totalPrice, date, status FROM [Order]", conn);     
                    da.Fill(dt);   
                }
            }
            catch (Exception ex)    
            {
                MessageBox.Show("Error fetching orders: " + ex.Message);    
            }
            return dt;  
        }

        public DataRow GetOrderDetails(int orderId) // Method to get details of a specific order by order ID
        {
            DataTable dt = new DataTable();    
            try
            {
                using (SqlConnection conn = new SqlConnection(connect)) //create new SQL command and connects it to database
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT customer, totalPrice, date, status FROM [Order] WHERE OrderID = @OrderID", conn);   
                    da.SelectCommand.Parameters.AddWithValue("@OrderID", orderId); 
                    da.Fill(dt);    
                }
            }
            catch (Exception ex)    
            {
                MessageBox.Show("Error fetching order details: " + ex.Message); 
            }
            if (dt.Rows.Count > 0)  
            {
                return dt.Rows[0];  //returns the first row of the datatable, which contains the order details
            }
            return null;    
        }
    }

























}
