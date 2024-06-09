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
    
    public partial class view_sales2 : Form
    {
        public view_sales2()
        {
            InitializeComponent();
        }

        private void btn_show_sales_Click(object sender, EventArgs e)
        {
            listView_2.View = View.Details;
            listView_2.GridLines = true;
            listView_2.Columns.Clear();
            listView_2.Items.Clear();
            listView_2.Columns.Add("ItemID", 100);
            listView_2.Columns.Add("Customer", 100);
            listView_2.Columns.Add("Chef", 100);
            listView_2.Columns.Add("Total Price", 100);
            listView_2.Columns.Add("Category", 100);
            listView_2.Columns.Add("Month", 100);
            //listView_2.Columns.Add("ItemID", 100);

            List<ListViewItem> items = User.GetSalesData();
            foreach (ListViewItem item in items)
            {
                listView_2.Items.Add(item);
            }
        }

        private void listView_2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var options = new Options();
            options.Show();
            this.Hide();
        }
    }
}
