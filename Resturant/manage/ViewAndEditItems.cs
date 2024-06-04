using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.manage
{
    public partial class ViewAndEditItems : Form
    {
        public ViewAndEditItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddNewItem frmItemAdder = new AddNewItem();
            frmItemAdder.ShowDialog();
            menuFilter1.FillMenuListBox();
        }
    }
}
