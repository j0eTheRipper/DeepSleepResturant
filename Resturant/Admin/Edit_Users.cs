using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Resturant.Admin
{
    public partial class Edit_Users : Form
    {
        
       
        
        public Edit_Users()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\alial\\source\\repos\\Ali1767\\DeepSleepResturant v3\\DeepSleepResturant\\Resturant\\Database1.mdf\";Integrated Security=True";
          
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Users_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_info_Click(object sender, EventArgs e)
        {
           
        }

        private void rdoCustomer_CheckedChanged(object sender, EventArgs e)
        {
            //labelYearofexperince.Hide(); txtnewExperienece.Hide();
            //labelSalary.Hide(); txtnewSalary.Hide();
            //labelSpecility.Hide(); txtoldspeciality.Hide();
            //label14.Show(); txtoldemail.Show();
            //label13.Show(); txtDateBirth.Show();
            //label3.Show(); txtMobile.Show();
            //label17.Hide(); txtoldsalary.Hide();
            //label16.Hide(); txtOLDEXEPER.Hide();
            //label18.Hide(); txtnewSpeciality.Hide();
            //label19.Show(); txtOFBIRTH.Show();
            //label20.Show(); txtNewMobile.Show();
        }

        private void rdoChef_CheckedChanged(object sender, EventArgs e)
        {
            //label13.Hide(); txtDateBirth.Hide();
            //label3.Hide(); txtoldemail.Hide();
            //label14.Hide(); txtMobile.Hide();
            //labelYearofexperince.Hide(); txtnewExperienece.Hide();
            //labelSalary.Show();
            //labelSpecility.Show();
            //txtnewSalary.Show();
            //txtoldspeciality.Show();
            //label17.Show(); txtoldsalary.Show();
            //label19.Hide(); txtOFBIRTH.Hide();
            //label18.Show(); txtnewSpeciality.Show();
            //label20.Hide(); txtNewMobile.Hide();
            //label3.Show(); txtoldemail.Show();
            //label16.Hide(); txtOLDEXEPER.Hide();
        }

        private void rdoManager_CheckedChanged(object sender, EventArgs e)
        {
            //labelYearofexperince.Show(); txtnewExperienece.Show();
            //labelSalary.Show(); txtnewSalary.Show();
            //labelSpecility.Hide(); txtoldspeciality.Hide();
            //label13.Hide(); txtDateBirth.Hide();
            //label3.Hide(); txtoldemail.Hide();
            //label14.Hide(); txtMobile.Hide();
            //label3.Show(); txtoldemail.Show();
            //label18.Hide(); txtnewSpeciality.Hide();
            //label19.Hide(); txtOFBIRTH.Hide();
            //label20.Hide(); txtNewMobile.Hide();
            //label17.Show(); txtoldsalary.Show();
            //label16.Show(); txtOLDEXEPER.Show();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNEWMOBILE_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtOFBIRTH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_user_Click(object sender, EventArgs e)
        {

        }

        private void SaveChange_Click(object sender, EventArgs e)
        {
            if(managerOldRad.Checked == true)
            {
                List<string> colNames = new List<string>();
                Dictionary<string,string> colValues = new Dictionary<string, string>();

                if (txtnewEmail.Text != string.Empty)
                {
                    bool is_update_manager_profile = User.UpdateUsersProfile("ManagersInfo", usernameGet.Text, "email", txtnewEmail.Text);
                    if (!is_update_manager_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Manager Email !");
                    }

                    bool is_update_customer = User.UpdateUsersProfile("Users", usernameGet.Text, "email", txtnewEmail.Text);
                    if (!is_update_customer)
                    {
                        MessageBox.Show("We Are not Able to Update Customer Email !");
                    }
                    txtoldEmail.Text = txtnewEmail.Text;

                }
                if (txtnewExperienece.Text != string.Empty)
                {
                    bool is_update_manager_profile = User.UpdateUsersProfile("ManagersInfo", usernameGet.Text, "yearOfExper", txtnewExperienece.Text);
                    if (!is_update_manager_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Manager Year Of Experince !");
                    }
                    txtoldExperienece.Text = txtnewExperienece.Text;
                }
                if (txtnewSalary.Text != string.Empty)
                {
                    bool is_update_manager_profile = User.UpdateUsersProfile("ManagersInfo", usernameGet.Text, "salary", txtnewSalary.Text);
                    if (!is_update_manager_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Manager Year Of Experince  !");
                    }
                    txtoldSalary.Text = txtnewSalary.Text;

                }
                if (txtnewUsername.Text != string.Empty)
                {
                    bool is_update_manager_profile = User.UpdateUsersProfile("ManagersInfo", usernameGet.Text, "username", txtnewUsername.Text);
                    if (!is_update_manager_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Manager User Name !");
                    }

                    bool is_update_customer = User.UpdateUsersProfile("Users", usernameGet.Text, "username", txtnewUsername.Text);
                    if (!is_update_customer)
                    {
                        MessageBox.Show("We Are not Able to Update Customer User Name !");
                    }
                    txtoldUsername.Text = txtnewUsername.Text;

                }

            }
            else if (customeroldRad.Checked == true)
            {
                List<string> colNames = new List<string>();
                Dictionary<string, string> colValues = new Dictionary<string, string>();

                if (txtnewEmail.Text != string.Empty)
                {
                    bool is_update_customer_profile = User.UpdateUsersProfile("Customer", usernameGet.Text, "email", txtnewEmail.Text);
                    if (!is_update_customer_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Customer Email !");
                    }

                    bool is_update_customer = User.UpdateUsersProfile("Users", usernameGet.Text, "email", txtnewEmail.Text);
                    if (!is_update_customer)
                    {
                        MessageBox.Show("We Are not Able to Update Customer Email !");
                    }
                    txtoldEmail.Text = txtnewEmail.Text;

                }
                if (txtOFBIRTH.Text != string.Empty)
                {
                    bool is_update_customer_profile = User.UpdateUsersProfile("Customer", usernameGet.Text, "DateOfBirth", txtOFBIRTH.Text);
                    if (!is_update_customer_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Customer Year Of Birth !");
                    }
                    txtoldofBirth.Text = txtOFBIRTH.Text;
                }

                if (txtNewMobile.Text != string.Empty)
                {
                    bool is_update_customer_profile = User.UpdateUsersProfile("Customer", usernameGet.Text, "mobile", txtNewMobile.Text);
                    if (!is_update_customer_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Customer Mobile  !");
                    }
                    txtoldSalary.Text = txtnewSalary.Text;

                }
                if (txtnewUsername.Text != string.Empty)
                {
                    bool is_update_manager_profile = User.UpdateUsersProfile("Customer", usernameGet.Text, "username", txtnewUsername.Text);
                    if (!is_update_manager_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Customer User Name !");
                    }

                    bool is_update_customer = User.UpdateUsersProfile("Users", usernameGet.Text, "username", txtnewUsername.Text);
                    if (!is_update_customer)
                    {
                        MessageBox.Show("We Are not Able to Update Customer User Name !");
                    }
                    txtoldUsername.Text = txtnewUsername.Text;

                }
            }
            else if (chefoldRad.Checked == true)
            {
                if (txtnewEmail.Text != string.Empty)
                {
                    bool is_update_chef_profile = User.UpdateUsersProfile("ChefInfo", usernameGet.Text, "email", txtnewEmail.Text);
                    if (!is_update_chef_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Chef Email !");
                    }

                    bool is_update_customer = User.UpdateUsersProfile("Users", usernameGet.Text, "email", txtnewEmail.Text);
                    if (!is_update_customer)
                    {
                        MessageBox.Show("We Are not Able to Update Customer Email !");
                    }
                    txtoldEmail.Text = txtnewEmail.Text;

                }
                if (txtnewSpeciality.Text != string.Empty)
                {
                    bool is_update_chef_profile = User.UpdateUsersProfile("ChefInfo", usernameGet.Text, "speciality", txtnewSpeciality.Text);
                    if (!is_update_chef_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Chef Speciality!");
                    }
                    txtoldSpeciality.Text = txtnewSpeciality.Text;
                }

                if (txtnewSalary.Text != string.Empty)
                {
                    bool is_update_chef_profile = User.UpdateUsersProfile("ChefInfo", usernameGet.Text, "salary", txtnewSalary.Text);
                    if (!is_update_chef_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Chef Salary !");
                    }
                    txtoldSalary.Text = txtnewSalary.Text;

                }
                if (txtnewUsername.Text != string.Empty)
                {
                    bool is_update_chef_profile = User.UpdateUsersProfile("ChefInfo", usernameGet.Text, "username", txtnewUsername.Text);
                    if (!is_update_chef_profile)
                    {
                        MessageBox.Show("We Are not Able to Update Customer User Name !");
                    }

                    bool is_update_customer = User.UpdateUsersProfile("Users", usernameGet.Text, "username", txtnewUsername.Text);
                    if (!is_update_customer)
                    {
                        MessageBox.Show("We Are not Able to Update Customer User Name !");
                    }
                    txtoldUsername.Text = txtnewUsername.Text;

                }
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
          var opthns = new Options();
            opthns.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameGet.Text != "")
            {
                Dictionary<string, string> userInfo = User.GetSpecificUsers(usernameGet.Text);
                if (userInfo.ContainsKey("role") && userInfo["role"] == "manager")
                {

                    txtoldUsername.Text = userInfo["username"];

                    if (userInfo.ContainsKey("email"))
                    {
                        txtoldEmail.Text = userInfo["email"];
                    }
                    if (userInfo.ContainsKey("salary"))
                    {
                        txtoldSalary.Text = userInfo["salary"];
                    }
                    if (userInfo.ContainsKey("yearOfExper"))
                    {
                        txtoldExperienece.Text = userInfo["yearOfExper"];
                    }

                    managerOldRad.Checked = true;
                    usernameGet.Enabled = false;

                }
                else if (userInfo.ContainsKey("role")  && userInfo["role"] == "chef")
                {
                    txtoldUsername.Text = userInfo["username"];
                    if (userInfo.ContainsKey("email"))
                    {
                        txtoldEmail.Text = userInfo["email"];
                    }
                    if (userInfo.ContainsKey("salary"))
                    {
                        txtoldSalary.Text = userInfo["salary"];
                    }
                    if (userInfo.ContainsKey("speciality"))
                    {
                        txtoldSpeciality.Text = userInfo["speciality"];
                    }
                    chefoldRad.Checked = true;
                    usernameGet.Enabled = false;
                }
                else if (userInfo.ContainsKey("role")  && userInfo["role"] == "customer")
                {
                    txtoldUsername.Text = userInfo["username"];
                    if (userInfo.ContainsKey("email"))
                    {
                        txtoldEmail.Text = userInfo["email"];
                    }
                    if (userInfo.ContainsKey("mobile"))
                    {
                        txtoldMobile.Text = userInfo["mobile"];
                    }
                    if (userInfo.ContainsKey("dateOfBirth"))
                    {
                        txtoldofBirth.Text = userInfo["dateOfBirth"];
                    }
                    customeroldRad.Checked = true;
                    usernameGet.Enabled = false;

                }
                else
                {
                    MessageBox.Show("User Not Found");
                }
                
            }
            else
            {
                MessageBox.Show("You Have To Enter User Name");
            }



        }

        private void managerOldRad_CheckedChanged(object sender, EventArgs e)
        {
            laboldYearExper.Show();
            txtoldExperienece.Show();
            labnewYearExper.Show();
            txtnewExperienece.Show();
            laboldSalary.Show();
            txtoldSalary.Show();
            labnewSalary.Show();
            txtnewSalary.Show();
            laboldSpeciality.Hide();
            txtoldSpeciality.Hide();
            labnewSpeciality.Hide();
            txtnewSpeciality.Hide();
            laboldDateOfBirth.Hide();
            txtoldofBirth.Hide();
            labnewDateOfBirth.Hide();
            txtOFBIRTH.Hide();
            laboldMobile.Hide();
            txtoldMobile.Hide();
            labnewMobile.Hide();
            txtNewMobile.Hide(); 
            customeroldRad.Checked = false;
            chefoldRad.Checked = false;


        }

        private void chefoldRad_CheckedChanged(object sender, EventArgs e)
        {
            laboldYearExper.Hide();
            txtoldExperienece.Hide();
            labnewYearExper.Hide();
            txtnewExperienece.Hide();
            laboldSalary.Show();
            txtoldSalary.Show();
            labnewSalary.Show();
            txtnewSalary.Show();
            laboldSpeciality.Show();
            txtoldSpeciality.Show();
            labnewSpeciality.Show();
            txtnewSpeciality.Show();
            laboldDateOfBirth.Hide();
            txtoldofBirth.Hide();
            labnewDateOfBirth.Hide();
            txtOFBIRTH.Hide();
            laboldMobile.Hide();
            txtoldMobile.Hide();
            labnewMobile.Hide();
            txtNewMobile.Hide();
            managerOldRad.Checked = false;
            customeroldRad.Checked = false;

        }

        private void customeroldRad_CheckedChanged(object sender, EventArgs e)
        {
            laboldYearExper.Hide();
            txtoldExperienece.Hide();
            labnewYearExper.Hide();
            txtnewExperienece.Hide();
            laboldSalary.Hide();
            txtoldSalary.Hide();
            labnewSalary.Hide();
            txtnewSalary.Hide();
            laboldSpeciality.Hide();
            txtoldSpeciality.Hide();
            labnewSpeciality.Hide();
            txtnewSpeciality.Hide();
            laboldDateOfBirth.Show();
            txtoldofBirth.Show();
            labnewDateOfBirth.Show();
            txtOFBIRTH.Show();
            laboldMobile.Show();
            txtoldMobile.Show();
            labnewMobile.Show();
            txtNewMobile.Show();
            managerOldRad.Checked = false;
            chefoldRad.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtoldUsername.Text = string.Empty;
            txtoldEmail.Text = string.Empty;
            txtoldExperienece.Text = string.Empty;
            txtoldSalary.Text = string.Empty;
            txtoldSpeciality.Text = string.Empty;
            txtoldofBirth.Text = string.Empty;
            txtoldMobile.Text = string.Empty;
            usernameGet.Text = string.Empty;
            usernameGet.Enabled = true;
            txtnewUsername.Text = string.Empty;
            txtnewEmail.Text = string.Empty;
            txtnewSalary.Text = string.Empty;
            txtnewSpeciality.Text = string.Empty;
            txtnewExperienece.Text = string.Empty;
            txtOFBIRTH.Text = string.Empty;
            txtNewMobile.Text = string.Empty;



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtoldMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
