using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Customer
{
    public partial class cFeedBack : Form
    {
        private object txtFeedback;
        private Feedback cFeedBack;

        public cFeedBack()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customerId;
            if (int.TryParse(txtCustomerId.Text, out CustomerId) && !String.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                cFeedBack = new Feedback
                {
                    CustomerID = customerId,
                    FeedbackText = txtFeddback.Text
                };

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
