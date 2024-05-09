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
            Ingredients_Inventory inventory = new Ingredients_Inventory();
            inventory.Show();
            this.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Update_chef_profile ChefProfile = new Update_chef_profile();
            ChefProfile.Show();
            this.Hide();
        }
    }
}
