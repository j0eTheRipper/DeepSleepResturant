using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Resturant.User;

namespace Resturant
{
    internal class User
    {
        public string username, password, email, role;




                                                                                                   


        private static string connectionString = Properties.Settings.Default.YoussefConnection;
        private User()
        {
            
        }
        private User(string username, string password, string email, string role )
        { 
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        

           
        }

     
        internal class User1
        { }


        public static bool RegisterUser(string username, string password, string email, string role)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (username, password, email, role) VALUES (@username, @password, @Email, @role)";
                    using (SqlCommand addNewUser = new SqlCommand(query, connection))
                    {
                        addNewUser.Parameters.AddWithValue("@username", username);
                        addNewUser.Parameters.AddWithValue("@password", password);
                        addNewUser.Parameters.AddWithValue("@Email", email);
                        addNewUser.Parameters.AddWithValue("@role", role);

                        int rowsAffected = addNewUser.ExecuteNonQuery();
                        return rowsAffected == 1;
                    }
                }
            }
            catch (Exception ex)
            {
             
                return false;
            }
        }

       // The code below it shows the Feedback sent by Customers 
        public static List<ListViewItem> GetFeedbackData()
        {
           var items = new List<ListViewItem>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from Feedback", conn))
                {
                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        var item = new ListViewItem(da[0].ToString());
                        item.SubItems.Add(da[1].ToString());
                        item.SubItems.Add(da[2].ToString());
                        item.SubItems.Add(da[3].ToString());
                        item.SubItems.Add(da[4].ToString());
                        items.Add(item);
                    }
                }
            }
            return items;
        }


    // The code below  To get the View  sales from multiple tables by using inner join //   
          public static List<ListViewItem> GetSalesData()
        {
            List<ListViewItem> items = new List<ListViewItem>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT
                    o.customer,
                    o.chef,
                    o.totalPrice,
                    o.date AS month,
                    i.itemID,
                    i.catagory AS category
                FROM [Order] o
                JOIN [Item] i ON o.customer = i.name;";

                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ItemID"].ToString());
                        item.SubItems.Add(reader["customer"].ToString());
                        item.SubItems.Add(reader["chef"].ToString());
                        item.SubItems.Add(reader["totalPrice"].ToString());
                        item.SubItems.Add(reader["category"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["month"]).ToString("MM/yyyy"));
                       
                        items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching sales data: " + ex.Message);

                }
                finally
                {
                    connection.Close();
                }
            }
            return items;
        }




        // Delete Users from the Database
        public static bool DeleteUser(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand deleteUser = new SqlCommand($"Delete from Users where username = '{username}' ;", connection);
                int x = deleteUser.ExecuteNonQuery();
                SqlCommand deleteChefinfo = new SqlCommand($"Delete from ChefInfo where username = '{username}' ;", connection);
                int isChefdeleted = deleteChefinfo.ExecuteNonQuery();
                SqlCommand deleteManagerInfo = new SqlCommand($"Delete from ManagersInfo where username = '{username}';",connection);
                int isdeleteManagerInfo = deleteManagerInfo.ExecuteNonQuery();
                SqlCommand deleteCustomerInfo = new SqlCommand($"Delete from Customer where username = '{username}';", connection);
                int isdeleteCustomerInfo = deleteCustomerInfo.ExecuteNonQuery();
                

                if (x == 1)
                    return true;
                return false;
            }
        }






        public static bool UpdateUserName(string oldUserName, string newUserName)
        {

           
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET UserName = @NewUserName WHERE UserName = @OldUserName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewUserName", newUserName);
                        cmd.Parameters.AddWithValue("@OldUserName", oldUserName);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception ( the error)
                return false;
            }
        }

        public static bool UpdatePassword(string oldPassword, string newPassword)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET Password = @NewPassword WHERE Password = @OldPassword";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        cmd.Parameters.AddWithValue("@OldPassword", oldPassword);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception ( log the error)
                return false;
            }
        }

        public static bool UpdateEmail(string oldEmail, string newEmail)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET Email = @NewEmail WHERE Email = @OldEmail";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewEmail", newEmail);
                        cmd.Parameters.AddWithValue("@OldEmail", oldEmail);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
                return false;
            }
        }

        public static User Login(string userID, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand query = new SqlCommand($"SELECT email, role FROM Users WHERE (username='{userID}' or email='{userID}') and password='{password}';", connection);
                connection.Open();
                SqlDataReader info = query.ExecuteReader();
                if (info.Read())
                    return new User(userID, password, info["email"].ToString(), info["role"].ToString());
                return null;
            }
        }


        public static Dictionary<string, string> GetSpecificUsers(string username)
        {
            bool is_found = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand query = new SqlCommand($"SELECT username, email, role FROM Users where (username='{username}')", connection);
                connection.Open();
                SqlDataReader info = query.ExecuteReader();
                var userInfo = new Dictionary<string, string>();
                while (info.Read())
                {
                    string usernamev = info.IsDBNull(0) ? null : info.GetString(0);
                    string email = info.IsDBNull(1) ? null : info.GetString(1);
                    string role = info.IsDBNull(2) ? null : info.GetString(2);

                    userInfo.Add("username", usernamev);
                    userInfo.Add("email", email);
                    userInfo.Add("role", role);
                    is_found = true;
                }
                connection.Close();
               
                if (userInfo.ContainsKey("role") && userInfo["role"] == "manager")
                {
                    SqlCommand queryManager = new SqlCommand($"SELECT username, yearOfExper, salary FROM ManagersInfo where (username='{username}')", connection);
                    connection.Open();
                    SqlDataReader infoManager = queryManager.ExecuteReader();
                    while (infoManager.Read())
                    {

                        string yearOfExper = infoManager.IsDBNull(1) ? null : infoManager.GetString(1);
                        string salary = infoManager.IsDBNull(2) ? null : infoManager.GetString(2);

                        userInfo.Add("yearOfExper", yearOfExper);
                        userInfo.Add("salary", salary);
                    }
                    connection.Close();
                }
                else if (userInfo.ContainsKey("role") && userInfo["role"] == "chef")
                {
                    SqlCommand queryChef = new SqlCommand($"SELECT username, speciality, salary FROM ChefInfo where (username='{username}')", connection);
                    connection.Open();
                    SqlDataReader infoChef = queryChef.ExecuteReader();
                    while (infoChef.Read())
                    {
                        string speciality = infoChef.IsDBNull(1) ? null : infoChef.GetString(1);
                        string salary = infoChef.IsDBNull(2) ? null : infoChef.GetString(2);

                        userInfo.Add("speciality", speciality);
                        userInfo.Add("salary", salary);

                    }
                    connection.Close();

                }
                else if (userInfo.ContainsKey("role")  && userInfo["role"] == "customer")
                {
                    SqlCommand querCustomer = new SqlCommand($"SELECT username,DateOfBirth,mobile,email FROM Customer where (username='{username}')", connection);
                    connection.Open();
                    SqlDataReader infoCUstomer = querCustomer.ExecuteReader();
                    while (infoCUstomer.Read())
                    {
                        string dateOfBirth = infoCUstomer.IsDBNull(1) ? null : infoCUstomer.GetString(1);
                        string mobile = infoCUstomer.IsDBNull(2) ? null : infoCUstomer.GetString(2);

                        userInfo.Add("dateOfBirth", dateOfBirth);
                        userInfo.Add("mobile", mobile);

                    }
                    connection.Close();
                }
                return userInfo;
            }
        }

        public static List<User> GetAllUsers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand query = new SqlCommand($"SELECT username, email, role FROM Users", connection);
                connection.Open();
                SqlDataReader info = query.ExecuteReader();
                List<User> users = new List<User>();
                while (info.Read())
                {
                    User user = new User
                    {
                        username = info.GetString(0), 
                        email = info.GetString(1),    
                        role = info.GetString(2)      
                    };
                    users.Add(user);
                }
                connection.Close();
                return users;
            }
        }

      


       
        public static bool AddManagerInfo(string username, string password, string role, string salary, string yearOfExper, string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand registerUserInfo = new SqlCommand($"INSERT INTO Users (username, password, email, role) VALUES ('{username}', '{password}', '{email}', '{role}')", connection);
                    int isUserCreated = registerUserInfo.ExecuteNonQuery();
                    SqlCommand addManagerInfo = new SqlCommand($"INSERT INTO ManagersInfo (username, salary, yearOFExper, email) VALUES ('{username}','{salary}', '{yearOfExper}', '{email}')", connection);
                    int isManagerProfileCreated = addManagerInfo.ExecuteNonQuery();
                    connection.Close();
                    return isManagerProfileCreated == 1;
                }
            }
            catch (Exception ex)
            {
            
                return false;
            }
        }

        public static bool AddChefInfo(string username,string password,string role, string speciality, string salary, string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand registerUserInfo = new SqlCommand($"INSERT INTO Users (username, password, email, role) VALUES ('{username}', '{password}', '{email}', '{role}')", connection);
                    int isUserCreated = registerUserInfo.ExecuteNonQuery();
                    SqlCommand addChefInfo = new SqlCommand($"INSERT INTO ChefInfo (username, speciality, salary, email) VALUES ('{username}', '{speciality}', '{salary}', '{email}')", connection);
                    int isChefProfileCreated = addChefInfo.ExecuteNonQuery();
                    return isChefProfileCreated == 1;
                }
            }
            catch (Exception ex)
            {
              
                return false;
            }
        }

        public static bool AddCustomerInfo(string username, string password, string role, string dateOfBirth, string mobile, string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand registerUserInfo = new SqlCommand($"INSERT INTO Users (username, password, email, role) VALUES ('{username}', '{password}', '{email}', '{role}')", connection);
                    int isUserCreated = registerUserInfo.ExecuteNonQuery();
                    SqlCommand addCustomerInfo = new SqlCommand($"INSERT INTO Customer (username, DateOfBirth, mobile, email) VALUES ('{username}', '{dateOfBirth}', '{mobile}', '{email}')", connection);
                    int isCustomerProfileCreated = addCustomerInfo.ExecuteNonQuery();
                    connection.Close();
                    return isCustomerProfileCreated == 1;
                }
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        public static bool UpdateUsersProfile(string tabelname, string username, string colname, string colvalue)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"UPDATE {tabelname} SET {colname} = '{colvalue}' where username = '{username}'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();
                        return rowsAffected > 0;
                    }
                   
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
