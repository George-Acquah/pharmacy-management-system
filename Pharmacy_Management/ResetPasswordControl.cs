using Pharmacy_Management.auth;
using Pharmacy_Management.utils.connections;
using Pharmacy_Management.utils.contexts;
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

namespace Pharmacy_Management
{
    public partial class ResetPasswordControl : UserControl
    {
        private static string oldPass = "Old Password";
        private static string newPass = "New Password";
        private static string confPass = "Confirm Password";
        public ResetPasswordControl()
        {
            InitializeComponent();
        }

        private void ResetPasswordControl_Load(object sender, EventArgs e)
        {

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            string oldPassword = old_pass.Text;
            string newPassword = new_pass.Text;
            string confirmNewPassword = conf_pass.Text;

            // Validate the old password against the stored password
            if (!IsOldPasswordValid(oldPassword))
            {
                MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the new password against your requirements
            if (!IsNewPasswordValid(newPassword))
            {
                MessageBox.Show("New password does not meet the requirements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the new password and confirm password match
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the user's password in your data storage (e.g., database)
            UpdatePassword(newPassword);

            

            // Close the form or perform any other action after successful password update
        }

        private bool IsOldPasswordValid(string oldPassword)
        {
            string loggedPass = MyAppContext.UserPass;
            Console.WriteLine(loggedPass);
            string hashedPass = HashPasswords.HashFunction(oldPassword);
            Console.WriteLine(hashedPass);
            if (loggedPass == hashedPass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsNewPasswordValid(string newPassword)
        {
            return newPassword.Length >= 4;
        }

private void UpdatePassword(string newPassword)
    {
        string connectionString = DbConfigs.connectionString; // Replace this with your actual database connection string
            string userId = MyAppContext.EmpID;
            string hashedPass = HashPasswords.HashFunction(newPassword);

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Assuming you have a table called 'Users' with a 'Password' column to store passwords
                // Replace 'Your_Users_Table' and 'Your_Password_Column' with the actual table and column names
                string updateQuery = "UPDATE Employee_tb SET EmpPassword = @EmpPassword WHERE EmpId = @EmpId";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Replace 'Your_UserId_Value' with the actual user ID of the user whose password you want to update
                    command.Parameters.AddWithValue("@EmpId", userId);
                    command.Parameters.AddWithValue("@EmpPassword", hashedPass);

                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the password was updated successfully
                    if (rowsAffected > 0)
                    {
                            // Password updated successfully
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    else
                    {
                        // Failed to update the password
                        MessageBox.Show("An error occurred while updating the password: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        connection.Close();
                }
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions that may occur during the database update
            MessageBox.Show("An error occurred while updating the password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

        private void view_old_pass_Click(object sender, EventArgs e)
        {
            old_pass.isPassword = false;
        }

        private void view_new_pass_Click(object sender, EventArgs e)
        {
            new_pass.isPassword = false;
        }

        private void view_conf_pass_Click(object sender, EventArgs e)
        {
            conf_pass.isPassword = false;
        }

        private void old_pass_Enter(object sender, EventArgs e)
        {
            string text = old_pass.Text;
            if (text == oldPass)
            {
                old_pass.Text = "";
            }
            else
            {
                old_pass.Text = text;
            }
        }

        private void old_pass_Leave(object sender, EventArgs e)
        {
            string text = old_pass.Text;
            if (text == "")
            {
                old_pass.Text = oldPass;
            }
            else
            {
                old_pass.Text = text;
            }
        }

        private void new_pass_Enter(object sender, EventArgs e)
        {
            string text = new_pass.Text;
            if (text == newPass)
            {
                new_pass.Text = "";
            }
            else
            {
                new_pass.Text = text;
            }
        }

        private void new_pass_Leave(object sender, EventArgs e)
        {
            string text = new_pass.Text;
            if (text == "")
            {
                new_pass.Text = newPass;
            }
            else
            {
                new_pass.Text = text;
            }
        }

        private void conf_pass_Enter(object sender, EventArgs e)
        {
            string text = conf_pass.Text;
            if (text == confPass)
            {
                conf_pass.Text = "";
            }
            else
            {
                conf_pass.Text = text;
            }
        }

        private void conf_pass_Leave(object sender, EventArgs e)
        {
            string text = conf_pass.Text;
            if (text == "")
            {
                conf_pass.Text = confPass;
            }
            else
            {
                conf_pass.Text = text;
            }
        }
    }
}
