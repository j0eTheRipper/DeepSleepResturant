using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Resturant.Admin
{
    public partial class FeedBack1 : Form
    {
        public FeedBack1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FeedBack1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFeedBack.Text = string.Empty;
            txtService.Text = string.Empty;
            rdoVerySatisfied.Checked = false;
            rdoSatisfied.Checked = false;
            rdoNeutral.Checked = false;
            rdoUnsatisfied.Checked = false;
            rdoVeryUnsatisfied.Checked = false;
        }


        private string GetSelectedSatisfaction()
        {
            if (rdoVerySatisfied.Checked)
                return "VerySatisfied";
            else if (rdoSatisfied.Checked)
                return "Satisfied";
            else if (rdoNeutral.Checked)
                return "Neutral";
            else if (rdoUnsatisfied.Checked)
                return "Unsatisfied";
            else if (rdoVeryUnsatisfied.Checked)
                return "VeryUnsatisfied";
            return string.Empty;
        }
        private void btnSumbit_Click(object sender, EventArgs e)

        {

            string feedback = txtFeedBack.Text;
            string username = txtUsername.Text;
            string service = txtService.Text;
            string satisfaction = GetSelectedSatisfaction();

            bool isAdded = User.AddFeedback(feedback, username, service, satisfaction);

            if (isAdded)
            {
                MessageBox.Show("Feedback added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add feedback. Please try again.");
            }
        }





        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFeedBack.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtService.Text = string.Empty;
            rdoVerySatisfied.Checked = false;
            rdoSatisfied.Checked = false;
            rdoNeutral.Checked = false;
            rdoUnsatisfied.Checked = false;
            rdoVeryUnsatisfied.Checked = false;
        }











    }
}


