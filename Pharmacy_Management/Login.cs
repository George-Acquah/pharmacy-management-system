using Pharmacy_Management.auth;
using Pharmacy_Management.logging;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\Dev\C#\Databases\Pharmacy_DB.mdf;Integrated Security=True;Connect Timeout=30");

        int startTime = 0;

        private void UserId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            FormManager.RegisterForm("Login", this);
            FormManager.RegisterForm("HomeForm", new HomeForm());
            FormManager.RegisterForm("ForgotPass", new ForgotPass());
        }

        private string empid_query = "SELECT EmpId FROM Employee_tb WHERE EmpName = @Username AND EmpPassword = @Password";
        private string role_query = "SELECT EmpRole FROM Employee_tb WHERE EmpName = @Username AND EmpPassword = @Password";
        private string empname_query = "SELECT EmpName FROM Employee_tb WHERE EmpName = @Username AND EmpPassword = @Password";
        private string emppass_query = "SELECT EmpPassword FROM Employee_tb WHERE EmpName = @Username AND EmpPassword = @Password";

        private string GetEmpDetailsFromDatabase(string username, string password, string query)
        {
            SqlCommand command = new SqlCommand(query, dbConnection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            object result = command.ExecuteScalar();

            return result != null ? result.ToString() : null;
        }
        //public void ProcessLogin(string userId)
        //{
        //    // Check if it's the first login of the day
        //    if (IsFirstLoginOfTheDay(userId))
        //    {
        //        // Store the login timestamp in the database
        //        StoreLoginTimestamp(userId);
        //    }

        //    // Continue with the login process
        //    // ...
        //}

        private void _login_btn_Click(object sender, EventArgs e)
        {
            dbConnection.Open();
            string username = Username.Text;
            string enteredPass = Password.Text;
            string hashedPass = HashPasswords.HashFunction(enteredPass);

            string userRole = GetEmpDetailsFromDatabase(username, hashedPass, role_query);
            string employeeId = GetEmpDetailsFromDatabase(username, hashedPass, empid_query);
            string userName = GetEmpDetailsFromDatabase(username, hashedPass, empname_query);
            string userPass = GetEmpDetailsFromDatabase(username, hashedPass, emppass_query);


            if (userRole != null || (username ==  "Admin" && enteredPass == "admin"))
            {
                if (username == "Admin")
                {
                    MyAppContext.UserRole = "Admin";
                    MyAppContext.userName = "Admin";
                    MyAppContext.EmpID = "admin";
                    // Open the main form based on the user's role
                    FormManager.NavigateTo("HomeForm");
                    // Close the login form
                    this.Hide();
                }
                else
                {
                    MyAppContext.UserRole = userRole;
                    MyAppContext.EmpID = employeeId;
                    MyAppContext.userName = userName;
                    MyAppContext.UserPass = userPass;

                    // Open the main form based on the user's role
                    FormManager.NavigateTo("HomeForm");
                    // Close the login form
                    this.Hide();
                }
                EmployeeActivityLogger.LogLogin(employeeId);
                
            }
            else
            {
                MessageBox.Show("Wrong Credentials... Please input credentials again");
            }
            dbConnection.Close();
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            string text = Username.Text;
            if(text == "UserId")
            {
                Username.Text = "";
            }
            else
            {
                Username.Text = text;
            }
        }

        public void Username_Leave(object sender, EventArgs e)
        {
            string text = Username.Text;
            if (text == "")
            {
                Username.Text = "UserId";
            }
            else
            {
                Username.Text = text;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            string text = Password.Text;
            if (text == "Password")
            {
                Password.Text = "";
            }
            else
            {
                Password.Text = text;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            string text = Password.Text;
            if (text == "")
            {
                Password.Text = "Password";
            }
            else
            {
                Password.Text = text;
            }
        }

        private void show_hide_pass_Click(object sender, EventArgs e)
        {
            Password.isPassword = false;
            show_pass_timer.Start();
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                _login_btn_Click(sender, e);
            }
        }

        private void show_pass_timer_Tick(object sender, EventArgs e)
        {
            startTime += 1;
            if (startTime == 10)
            {
                Password.isPassword = true;
                startTime = 0;
            }
        }

        private void forgot_pass_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo("ForgotPass");
            this.Hide();
        }

        private void exit_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
