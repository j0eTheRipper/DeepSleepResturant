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

namespace Resturant.Customer
{
    public partial class CWidgetMenu : UserControl
    {

        public event EventHandler OnSelect = null;

        

        public CWidgetMenu()
        {
            InitializeComponent();
        }
        public CWidgetMenu(string name, string price, string catagory, Image icon)
        {
            InitializeComponent();
            lblItemName.Text = name;
            lblPrice.Text = price;
            picItem.Image = icon;
            lblTag.Text = catagory;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void lblTag_Click(object sender, EventArgs e)
        {

        }

        private void lblItemName_Click(object sender, EventArgs e)
        {

        }

        private void picItem_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
