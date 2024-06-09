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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Resturant.Customer
{
    public partial class cFeedback : Form
    {
        int customerID;
        public cFeedback(string username)
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YoussefConnection))
            {
                SqlCommand cmd = new SqlCommand($"SELECT CustomerID FROM Customer WHERE username=@name;", connection);
                cmd.Parameters.AddWithValue("name", username);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                customerID = reader.GetInt32(0);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string feedback = txtFeedBack.Text;
            string service = txtService.Text;
            string satisfaction =  GetSelectedSatisfaction();

            bool isAdded = CustomerFeedback.AddFeedBack(feedback, service, satisfaction, this.customerID);
            
            if(isAdded)
            {
                MessageBox.Show("Feedback added successfully");
            }
            else
            {
                MessageBox.Show("Failed to add feedback. Please try again");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFeedBack.Text = string.Empty;
            txtService.Text = string.Empty;
            rdoVerySatisfied.Checked = false;
            rdoSatisfied.Checked = false;
            rdoNeutral.Checked = false;
            rdoUnsatisfied.Checked = false;
            rdoVeryUnsatisfied.Checked = false;

        }

        private void cFeedback_Load(object sender, EventArgs e)
        {

        }
    }
}
