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
        private CustomerFeedback customerFeedback;

        public cFeedBack()
        {
        
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void cFeedBack_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(txtCustomerID.Text);
            string feedback = textFeedback.Text;

            bool success = customerFeedback.AddFeedback(customerId, feedback);
            if (success)
            {
                MessageBox.Show("Feedback submitted successfully!");
            }
            else
            {
                MessageBox.Show("Failed to submit feedback.");
            }
        }

        private void feedtext(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
                List<Feedback> feedbackList = customerFeedback.GetFeedback();

                foreach (var feedback in feedbackList)
                {
                    // Display feedback in your form (e.g., add to a ListView or DataGridView)
                    Console.WriteLine($"FeedbackID: {feedback.FeedbackID}, CustomerID: {feedback.CustomerID}, Feedback: {feedback.FeedbackText}");
                }
            
        }

        private void CustomerFeedback_Click(object sender, EventArgs e)
        {

        }
    }
}
