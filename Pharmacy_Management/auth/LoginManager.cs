using Pharmacy_Management.utils.connections;
using Pharmacy_Management.utils.constants;
using System;
using System.Data.SqlClient;

namespace Pharmacy_Management.auth
{
    public class LoginManager
    {
        private string connectionString = DbConfigs.connectionString;

        

        private bool IsFirstLoginOfTheDay(string userId)
        {
            // Get the current date
            DateTime currentDate = DateTime.Today;

            // Check if there is an entry for the user and current date in the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM LoginHistory_tbl WHERE EmpId = @EmpId AND LoginDate = @LoginDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmpId", userId);
                command.Parameters.AddWithValue("@LoginDate", currentDate);

                int count = (int)command.ExecuteScalar();

                return count == 0;
            }
        }

        private void StoreLoginTimestamp(string userId)
        {
            // Get the current date and time
            DateTime currentTimestamp = DateTime.Now;
            string lg_text = NewId.login;
            string loginId = NewId.UniqueId(lg_text);

            // Store the login timestamp in the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO LoginHistory_tbl (LoginId, EmpId, LoginDate, LoginTime) VALUES (@LoginId, @EmpId, @LoginDate, @LoginTime)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LoginId", loginId);
                command.Parameters.AddWithValue("@EmpId", userId);
                command.Parameters.AddWithValue("@LoginDate", currentTimestamp.Date);
                command.Parameters.AddWithValue("@LoginTime", currentTimestamp.TimeOfDay);

                command.ExecuteNonQuery();
            }
        }
    }
}
