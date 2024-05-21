﻿using Resturant.Admin;
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
            txtPassword.Text = "";
            txtEmail.Text = "";
            rdoChef.Checked = false;
            rdoCustomer.Checked = false;
            rdoManager.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserType = "";

            if(txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show($"Please Fill All User Infromation");
            }

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
            bool is_created = User.RegisterUser(txtUsername.Text, txtPassword.Text, txtEmail.Text, UserType);
            if (is_created)
            {
                MessageBox.Show($"New User With {UserType} Role Has Been Added !");
                this.EmptyAllFields();
            }
            else
            {
                MessageBox.Show("User Information is not Correct or User Exsist");
            }
            
            



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
    }
}

