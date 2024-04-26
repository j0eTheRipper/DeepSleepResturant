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
    public partial class Edit1 : Form
    {
        public Edit1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit_2 edit_2 = new edit_2();
            edit_2.Show();
            this.Close();
        }
    }
}
