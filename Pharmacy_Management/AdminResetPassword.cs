using Pharmacy_Management.utils.connections;
using Pharmacy_Management.utils.contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management
{
    public partial class AdminResetPassword : UserControl
    {
        private UserManager userManager;
        SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString);
        public AdminResetPassword()
        {
            InitializeComponent();
            userManager = new UserManager();

            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            dbConnection.Open();
            string Myquery = "select * from PasswordResetRequests";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, dbConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            ResetResquestsGridView.DataSource = ds.Tables[0];
            dbConnection.Close();
        }

        private void ResetResquestsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ResetResquestsGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ResetResquestsGridView.SelectedRows[0];
                User selectedUser = selectedRow.DataBoundItem as User;

                // Display user details in text boxes or labels on the form
                if (selectedUser != null)
                {
                    usernameTextBox.Text = selectedUser.Username;
                    temporaryPasswordTextBox.Text = selectedUser.TemporaryPassword;
                }
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked");
            if (ResetResquestsGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ResetResquestsGridView.SelectedRows[0];
                User selectedUser = selectedRow.DataBoundItem as User;

                if (selectedUser != null)
                {
                    Console.WriteLine("found");
                    string newPassword;
                    // Get new password from admin (you can show an input box for admin to enter the new password)
                    if (admin_pass_text.Text == "Password" || admin_pass_text.Text == "")
                    {
                        newPassword = "NewPassword123";
                    }
                    else
                    {
                        newPassword = admin_pass_text.Text;
                    }

                    bool resetSuccess = userManager.ResetPassword(selectedUser.ID, selectedUser.Username, newPassword);

                    if (resetSuccess)
                    {
                        // Password reset successfully
                        // Notify the admin or show a success message
                        MessageBox.Show("Password reset successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh DataGridView to remove the user from the list after password reset
                        PopulateDataGridView();
                    }
                    else
                    {
                        // User not found or password reset not requested
                        // Notify the admin or show an error message
                        MessageBox.Show("Password reset failed. User not found or password reset not requested.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ResetResquestsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            usernameTextBox.Text = ResetResquestsGridView.SelectedRows[0].Cells[1].Value.ToString();
            temporaryPasswordTextBox.Text = ResetResquestsGridView.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
