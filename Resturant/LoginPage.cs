using Resturant.Admin;
using Resturant.chef;
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
    public partial class LoginPage : Form
    {
        private User user;
        public LoginPage()
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

        private void btnLoginClick(object sender, EventArgs e)
        {
            user = User.Login(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                Hide();
                if (user.role == "admin")
                {
                    Options admin_user = new Options();
                    admin_user.ShowDialog();
                }
                else if (user.role == "customer")
                {
                    CustomerMainPage customer_user = new CustomerMainPage(txtUsername.Text);
                    customer_user.ShowDialog();
                }
                else if (user.role == "manager")
                {
                    ManagerMainPage managerMain = new ManagerMainPage();
                    managerMain.ShowDialog();
                } else if (user.role == "chef")
                {
                    ChefMainPage chefMainPage = new ChefMainPage();
                    chefMainPage.ShowDialog();
                }
                Show();
            }

        }

        private void btnLoginBehaviour(object sender, EventArgs e)
        {
            bool fieldsUnedited = txtPassword.Text == "" || txtPassword.Text == "Password" || txtUsername.Text == "Username" || txtUsername.Text == "";
            user = User.Login(txtUsername.Text, txtPassword.Text);
            if (fieldsUnedited || user == null)
            {
                Point newLocation;
                if (btnLogin.Location.X >= 500)
                {
                    newLocation = new Point(0, 299);
                }
                else
                    newLocation = new Point(719, 299);

                animateLoginbtn(newLocation);
            }
        }

        private void animateLoginbtn(Point newLocation)
        {
            while (newLocation != btnLogin.Location)
            {
                if (newLocation.X > btnLogin.Location.X)
                    btnLogin.Location = new Point(btnLogin.Location.X + 1, 299);
                else
                    btnLogin.Location = new Point(btnLogin.Location.X - 1, 299);
            }
        }

        private void onRightCredentials(object sender, EventArgs e)
        {
            user = User.Login(txtUsername.Text,txtPassword.Text);
            if (user != null)
            {
                animateLoginbtn(new Point(371, 299));
            }
        }

        private void chbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chbxShowPassword.Checked ? '\0' : '*';
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("please enter your username and password");
                return;
            }
            bool x = User.RegisterUser(txtUsername.Text, txtPassword.Text, $"{txtUsername.Text}@deepsleep.com", "customer");
            if (x) MessageBox.Show("success");
            else MessageBox.Show("Please try again with another username");
        }
    }
}