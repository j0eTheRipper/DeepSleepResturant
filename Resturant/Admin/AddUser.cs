using Resturant.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;



namespace Resturant
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        public void EmptyAllFields()
        {
            txtUsername.Text = "";
            txtEmail.Text = "";
            rdoChef.Checked = false;
            rdoCustomer.Checked = false;
            rdoManager.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtEmail.Text == "")
            {
                // Checks if the fields are empty.
                MessageBox.Show("Please Fill All User Information");
                return;
            }

            string UserType = "";
            if (rdoChef.Checked)
            {
                UserType = "chef";
            }
            else if (rdoManager.Checked)
            {
                UserType = "manager";
            }
            else if (rdoCustomer.Checked)
            {
                UserType = "customer";
            }

            if (UserType == "manager")
            {
                string salary = txtSalary.Text;
                string yearOfExper = txtExperienece.Text;
                string email = txtEmail.Text;

                // Add manager info
                bool is_manager_info_added = User.AddManagerInfo(txtUsername.Text,"ABC1234",UserType,salary,yearOfExper,email);

                if (is_manager_info_added)
                {
                    MessageBox.Show($"New user with {UserType} role has been added!");
                }
                else
                {
                    MessageBox.Show("We Are not Able to Create Manager Profile");
                }
            }
            else if (UserType == "chef")
            {
                string salary = txtSalary.Text;
                string speciality = txtspeciality.Text;
                string email = txtEmail.Text;

                // Add chef info
                bool is_chef_info_added = User.AddChefInfo(txtUsername.Text, "ABC1234", UserType,speciality,salary,email);

                if (is_chef_info_added)
                {
                    MessageBox.Show($"New user with {UserType} role has been added!");
                }
                else
                {
                    MessageBox.Show("We Are not Able to Create Chef Profile");
                }
            }
            else if (UserType == "customer")
            {
                string dateOfBirth = txtDateBirth.Text;
                string mobile = txtMobile.Text;
                string email = txtEmail.Text;

                // Add chef info
                bool is_customer_info_added = User.AddCustomerInfo(txtUsername.Text,"ABC1234", UserType, dateOfBirth, mobile, email);

                if (is_customer_info_added)
                {
                    MessageBox.Show($"New user with {UserType} role has been added!");
                }
                else
                {
                    MessageBox.Show("We Are not Able to Create Customer Profile");
                }
            }
            else
            {

                // If the user is not a manager or chef
                // Register the user
                bool is_created = User.RegisterUser(txtUsername.Text, "ABC1234", txtEmail.Text, UserType);

                if (is_created)
                {
                    MessageBox.Show($"New user with {UserType} role has been added!");
                }

                MessageBox.Show("User information is not correct or user exists.");

            }

            // Clear the fields after successful operation
            this.EmptyAllFields();
        }


        private void button2_Click(object sender, EventArgs e)
        {
           Options options = new Options();
            options.Show();
            this.Hide();
        }

        private void rdoManager_CheckedChanged(object sender, EventArgs e)
        {
            labelYearofexperince.Show(); txtExperienece.Show();
            labelSalary.Show(); txtSalary.Show();
            labelSpecility.Hide(); txtspeciality.Hide();
            label13.Hide(); txtDateBirth.Hide();
            label3.Show(); txtEmail.Show();
            label14.Hide(); txtMobile.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            if (rdoChef.Checked == true)
            {
                rdoCustomer.Checked = false;
                rdoManager.Checked = false;
            }
            else if (rdoCustomer.Checked == true)
            {
                rdoManager.Checked = false;
                rdoChef.Checked = false;
            }
            else if (rdoManager.Checked == true)
            {
                rdoCustomer.Checked = false;
                rdoChef.Checked = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
            
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            rdoCustomer.Checked = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoChef_CheckedChanged(object sender, EventArgs e)
        {

            label13.Hide(); txtDateBirth.Hide();
            label3.Show(); txtEmail.Show();
            label14.Hide(); txtMobile.Hide();
            labelYearofexperince.Hide(); txtExperienece.Hide();
            labelSalary.Show();
            labelSpecility.Show();
            txtSalary.Show();
            txtspeciality.Show();
            
            


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rdoCustomer_CheckedChanged(object sender, EventArgs e)
        {

            labelYearofexperince.Hide(); txtExperienece.Hide();
            labelSalary.Hide(); txtSalary.Hide();
            labelSpecility.Hide(); txtspeciality.Hide();
            label14.Show(); txtEmail.Show();
            label13.Show(); txtDateBirth.Show();
            label3.Show(); txtMobile.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}

