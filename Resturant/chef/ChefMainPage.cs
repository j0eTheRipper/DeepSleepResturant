using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.chef
{
    public partial class ChefMainPage : Form
    {
        public ChefMainPage()
        {
            InitializeComponent();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            View_Orders VOrders = new View_Orders();
            VOrders.Show();
            this.Hide();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            Manage_Orders ManageOrders = new Manage_Orders();
            ManageOrders.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Ingredient_Inventory inventory = new Ingredient_Inventory();
            inventory.Show();
            this.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ChefMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
