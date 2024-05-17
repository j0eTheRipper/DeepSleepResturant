using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Resturant
{
    internal class User
    {
        public string username, password, email, role;
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\j0eTh\\source\\repos\\Resturant\\Resturant\\Database1.mdf;Integrated Security=True";
        private User()
        {
            
        }
        private User(string username, string password, string email, string role)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }

        public static bool RegisterUser(string username, string password, string email, string role)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand addNewUser = new SqlCommand($"INSERT INTO Users VALUES ('{username}', '{password}', '{email}', '{role}');", connection);
                try
                {
                    int x = addNewUser.ExecuteNonQuery();
                    if (x == 1)
                        return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                return false;
            }
        }
        public static bool DeleteUser(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand deleteUser = new SqlCommand($"Delete from Users where username = '{username}' ;", connection);
                int x = deleteUser.ExecuteNonQuery();
                if (x == 1)
                    return true;
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
    }
}
