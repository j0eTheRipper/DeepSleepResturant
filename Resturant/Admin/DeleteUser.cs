using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Admin
{


    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }
       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userListView.SelectedItems.Count > 0)
            {
                txtUsername.Text = userListView.SelectedItems[0].Text;
            }

        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            userListView.View = View.Details;
            userListView.Columns.Add("User Name");
            userListView.Columns.Add("Email");
            userListView.Columns.Add("Role");
            userListView.Columns.Add("Password");
            List<User> users = new List<User>();
            users = User.GetAllUsers();
            foreach (User user in users)
            {
                userListView.Items.Add(new ListViewItem(new string[] { user.username, user.email, user.role, user.password }));
            }
            userListView.GridLines = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_user_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "")
            {
                bool isDeleted = User.DeleteUser(txtUsername.Text);
                if (isDeleted)
                {
                    MessageBox.Show($"User {txtUsername.Text} Has Been Deleted !");
                    userListView.Columns.Clear();
                    userListView.Items.Clear();
                    this.DeleteUser_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("We Are Not Able to Delete the User");
                }


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
