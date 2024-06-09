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
            EditOrAddItem frmItemAdder = new EditOrAddItem();
            frmItemAdder.ShowDialog();
            menuFilter1.FillMenuListBox();
            menuFilter1.FillCatagories();
        }

        private void EditOrDelete(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;
            string itemName = menuFilter1.SelectedMenuItem;
            if (itemName == null)
            {
                MessageBox.Show("please select an item!");
                return;
            }
            if (btnClicked == btnEditItem)
            {
                EditOrAddItem frmNewItem = new EditOrAddItem(itemName);
                frmNewItem.ShowDialog();
            } 
            else
            {
                bool confirm = MessageBox.Show("Are you sure you want to delete this item?", "are you sure", MessageBoxButtons.YesNo) == DialogResult.Yes;
                if (!confirm)
                    return;
                MenuItem item = new MenuItem(itemName);
                bool success = item.Delete();
                if (success) MessageBox.Show("Deleted Item Successfully");
                else MessageBox.Show("Deletion Failed!");
            }

            menuFilter1.FillCatagories();
            menuFilter1.FillMenuListBox();
            menuFilter1.Clear();
        }
    }
}
