using Microsoft.VisualBasic.ApplicationServices;
using Pharmacy_Management.utils.connections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Management.utils.contexts
{
        public class UserManager
        {
            private List<User> users = new List<User>();
            private List<User> passwordResetRequests = new List<User>();

        SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString);

        // Constructor
        public UserManager()
        {
            AddUserFromDatabase(); // Call the method to populate the users list from the database
        }

        // Method to add a new user to the system
        public void AddUserFromDatabase()
        {
            // Connect to the database and retrieve all employee data
            using (SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString))
            {
                dbConnection.Open();

                string query = "SELECT EmpId, EmpName FROM Employee_tb";
                using (SqlCommand command = new SqlCommand(query, dbConnection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userId = reader["EmpId"].ToString();
                            string username = reader["EmpName"].ToString();

                            User newUser = new User();
                            newUser.ID = userId; // Set the user ID
                            newUser.Username = username;
                            newUser.PasswordResetRequested = false; // Set default value to false
                            newUser.TemporaryPassword = null; // Set default value to null
                            Console.WriteLine(newUser.ToString());
                            users.Add(newUser);
                            Console.WriteLine(users.Count);

                        }
                    }
                }

                dbConnection.Close();
            }
        }



        // Method to request password reset
        public bool RequestPasswordReset(string userId, string username)
        {
                User user = users.FirstOrDefault(u => u.ID.ToString() == userId);
                if (user != null)
            {

                user.PasswordResetRequested = true;

                // Generate a new temporary password (you can use your logic here)
                string temporaryPassword = GenerateTemporaryPassword();
                user.TemporaryPassword = temporaryPassword;


                try
                {
                    dbConnection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO PasswordresetRequests values('" + username + "'," + userId + ",'" + 1 + "','" + temporaryPassword + "')", dbConnection);
                    cmd.ExecuteNonQuery();
                    // Add user to password reset requests list
                    passwordResetRequests.Add(user);
                    dbConnection.Close();
                }
                catch (Exception ex)
                {
                    string errMessage = ex.Message.ToString();
                    Console.WriteLine(errMessage);
                }
                

                return true;
            }

            return false;
        }

        // Method to reset the user's password
        public bool ResetPassword(string username, string userId, string newPassword)
            {
            User user = users.FirstOrDefault(u => u.Username.ToLower() == username.ToLower() && u.ID.ToString() == userId); ;
                if (user != null && user.PasswordResetRequested)
                {
                    // Update the user's password
                    user.PasswordResetRequested = false;
                    user.TemporaryPassword = null;
                    // Your logic to update the password in the database
                    UpdatePasswordInDatabase(user, newPassword);

                    // Notify the user of the password reset
                    NotifyUserOfPasswordReset(user.Username, newPassword);

                    return true;
                }

                return false;
            }

            // Method to generate a temporary password
            private string GenerateTemporaryPassword()
            {
                // Your logic to generate a temporary password
                return "Reset123"; // Replace with your password generation logic
            }

        // Method to update the password in the database (you can replace this with your database logic)
        private void UpdatePasswordInDatabase(User user, string newPassword)
        {
            using (SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString))
            {
                dbConnection.Open();

                string query = "UPDATE Employee_tb SET EmpPassword = @NewPassword WHERE EmpId = @UserID";
                using (SqlCommand command = new SqlCommand(query, dbConnection))
                {
                    command.Parameters.AddWithValue("@NewPassword", newPassword);
                    command.Parameters.AddWithValue("@UserID", user.ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to notify the user of the password reset
        private void NotifyUserOfPasswordReset(string username, string newPassword)
            {
                // Your logic to notify the user of the password reset
                // You can show an in-app notification or a success message
            }

            // Method to get the list of users who have requested password reset
            public List<User> GetPasswordResetRequests()
            {
                return passwordResetRequests;
            }
        }
}
