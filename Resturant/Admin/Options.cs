﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Admin
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            AddUser  addUser = new AddUser();
            addUser.Show();
            this.Hide();
            
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.Show();
            this.Hide();
        }
    }
}
