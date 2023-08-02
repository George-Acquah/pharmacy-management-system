using Pharmacy_Management.utils.connections;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Pharmacy_Management.logging
{
    public static class EmployeeActivityLogger
    {
        private static string logFilePath = "employee_activity_log.txt";
        private static SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString);

        public static void LogActivity(string employeeId, string activityDescription)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Employee: {employeeId} - Activity: {activityDescription}";

            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging employee activity: {ex.Message}");
            }
        }

        public static void LogLogin(string employeeId)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Employee: {employeeId} logged in";
            string type = "login";
            string date = $"{DateTime.Now:yyyy-MM-dd}";
            string time = $"{DateTime.Now:HH: mm: ss}";
            string query = "INSERT INTO LoginHistory_tbl values('" + employeeId + "','" + type + "', '" + date + "','" + time + "')";
            
            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging employee login: {ex.Message}");
            }

            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand(query, dbConnection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Log details Successfully Added");
                dbConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
                dbConnection.Close();
            }
        }

        public static void LogLogout(string employeeId)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Employee: {employeeId} logged out";
            string type = "logout";
            string date = $"{DateTime.Now:yyyy-MM-dd}";
            string time = $"{DateTime.Now:HH: mm: ss}";
            string query = "INSERT INTO LoginHistory_tbl values('" + employeeId + "','" + type + "', '" + date + "','" + time + "')";

            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging employee logout: {ex.Message}");
            }
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand(query, dbConnection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Log details Successfully Added");
                dbConnection.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
                dbConnection.Close();
            }
        }
    }
}
