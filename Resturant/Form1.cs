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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text == "Username" || txtBox.Text == "Password")
            {
                txtBox.Text = "";
                txtBox.ForeColor = Color.Black;
            }
            if (txtBox.Name == "txtPassword")
                txtBox.PasswordChar = '*';
        }

        private void txtBox_Leave(TextBox txtBox, string defaultText)
        {
            if (txtBox.Text == "")
            {
                txtBox.PasswordChar = '\0';
                txtBox.Text = defaultText;
                txtBox.ForeColor= Color.Gray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtBox_Leave(txtPassword, "Password");
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            txtBox_Leave(txtUsername, "Username");
        }
    }
}