using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMainPage home1 = new AdminMainPage();
            home1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user;
            if (rdoChef.Checked)
            {
                user = User.RegisterUser(txtUsername.Text, txtPassword.Text, txtEmail.Text, "chef");
            }
            else if (rdoManager.Checked) 
            {
                user = User.RegisterUser(txtUsername.Text, txtPassword.Text, txtEmail.Text, "manager");
            }
            else if (rdoCustomer.Checked) {
                user = User.RegisterUser(txtUsername.Text, txtPassword.Text, txtEmail.Text, "customer");
            }

           
        }
    }
}
