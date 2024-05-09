using Resturant.Admin;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdoChef.Checked)
                User.RegisterUser(txtUsername.Text, txtPassword.Text, txtEmail.Text, "chef");
            else if (rdoManager.Checked)
                User.RegisterUser(txtUsername.Text, txtPassword.Text, txtEmail.Text, "manager");
            else if (rdoCustomer.Checked)
                User.RegisterUser(txtUsername.Text, txtPassword.Text, txtEmail.Text, "customer");

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Options options = new Options();
            options.Show();
            this.Hide();
        }

        private void rdoManager_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
