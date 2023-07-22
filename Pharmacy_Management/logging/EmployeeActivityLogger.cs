using System;
using System.IO;

namespace Pharmacy_Management.logging
{
    public static class EmployeeActivityLogger
    {
        private static string logFilePath = "employee_activity_log.txt";

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
        }

        public static void LogLogout(string employeeId)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Employee: {employeeId} logged out";

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
        }
    }
}
