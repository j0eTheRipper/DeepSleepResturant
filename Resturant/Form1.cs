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
        private User user;
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

        private void txtBox_Leave(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text == "")
            {
                txtBox.PasswordChar = '\0';
                txtBox.Text = txtBox.Name.Remove(0, 3);
                txtBox.ForeColor= Color.Gray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (user != null)
                MessageBox.Show(user.role);
        }

        private void btnLoginBehaviour(object sender, EventArgs e)
        {
            bool fieldsUnedited = txtPassword.Text == "" || txtPassword.Text == "Password" || txtUsername.Text == "Username" || txtUsername.Text == "";
            user = User.Login(txtUsername.Text, txtPassword.Text);
            if (fieldsUnedited || user == null)
            {
                Random rnd = new Random();
                if (btnLogin.Location.X >= 500)
                {
                    btnLogin.Location = new Point(rnd.Next(0, 300), rnd.Next(299, 482));
                }
                else
                    btnLogin.Location = new Point(rnd.Next(500, 719), rnd.Next(299, 482));
            }
        }
    }
}