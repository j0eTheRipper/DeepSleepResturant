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
using System.Data.SqlClient;

namespace Resturant.Admin
{
    public partial class Feed___Back : Form
    {

        
        public Feed___Back()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            

            listViewFb.View = View.Details;
            listViewFb.GridLines = true;
            listViewFb.Columns.Clear();
            listViewFb.Items.Clear();

            listViewFb.Columns.Add("ID", 50);
            listViewFb.Columns.Add("Feedback", 200);
            listViewFb.Columns.Add("Username", 90);
            listViewFb.Columns.Add("Service", 90);
            listViewFb.Columns.Add("Satisfied", 90);

            List<ListViewItem> items = User.GetFeedbackData();
            foreach (ListViewItem item in items)
            {
                listViewFb.Items.Add(item);
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
    }
}
