using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Resturant
{
    internal class User
    {
        public string username, password, email, role;
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\alial\\source\\repos\\Ali1767\\DeepSleepResturant\\Resturant\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        private User(string username, string password, string email, string role)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }

        public User RegisterUser(string username, string password, string email, string role)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand addNewUser = new SqlCommand($"INSERT INTO Users VALUES ('{username}', '{password}', '{email}', '{role}');", connection);
                int x = addNewUser.ExecuteNonQuery();
                if (x == 1)
                    return new User(username, password, email, role);
                return null;
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
    }
}
