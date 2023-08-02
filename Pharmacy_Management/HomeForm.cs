using Guna.UI2.WinForms.Suite;
using Pharmacy_Management.logging;
using Pharmacy_Management.utils.contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management
{
	public partial class HomeForm : Form
	{
		public HomeForm()
		{
			InitializeComponent();
		}

		private void HomeForm_Load(object sender, EventArgs e)
		{
			FormManager.RegisterForm("HomeForm", this);
			FormManager.RegisterForm("MedicineForm", new MedicineForm());
			FormManager.RegisterForm("Company", new Company());
			FormManager.RegisterForm("Employee", new Employee());
			FormManager.RegisterForm("BillingForm", new BillingForm());
			FormManager.RegisterForm("LoginForm", new Login());
			FormManager.RegisterForm("OptionsForm", new OptionsForm());
			FormManager.RegisterForm("LogHistory", new LogHistoryForm());

            string userRole = MyAppContext.UserRole;
			string employeeId = MyAppContext.EmpID;
			string userName = MyAppContext.userName;
			int logCount = MyAppContext.LoginCount;

			Console.WriteLine("log count: " + logCount);



            if (userName == null || userName == "" || userRole == null || userRole == "")
            {
                Console.WriteLine("Null checker working");
                FormManager.NavigateTo("LoginForm");
                this.Hide();
            }
			else
			{
                home_role_lbl.Text = userRole;
            }
            Console.WriteLine(employeeId);
			Console.WriteLine(userName);
            


			//// Implement role-based logic here
			//if (userRole == "admin")
			//{
			//    // Show admin features
			//    lblUserRole.Text = "Admin";
			//    // ... additional admin logic ...
			//}
			//else if (userRole == "staff")
			//{
			//    // Show staff features
			//    lblUserRole.Text = "Staff";
			//    // ... additional staff logic ...
			//}
			//else
			//{
			//    // Handle invalid or unrecognized user roles
			//    lblUserRole.Text = "Unknown";
			//    MessageBox.Show("Invalid user role.");
			//    // Close the application or take appropriate action
			//    Application.Exit();
			//}
		}

		private void exit_icon_Click(object sender, EventArgs e)
		{
			DialogResult exitDialog = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNoCancel);
			if (exitDialog == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void medicine_icon_Click(object sender, EventArgs e)
		{
			FormManager.NavigateTo("MedicineForm");
			this.Hide();
		}

		private void companies_icon_Click(object sender, EventArgs e)
		{
			FormManager.NavigateTo("Company");
			this.Hide();
		}

		private void employees_icon_Click(object sender, EventArgs e)
		{
			FormManager.NavigateTo("Employee");
			this.Hide();
		}

		private void billing_icon_Click(object sender, EventArgs e)
		{
			FormManager.NavigateTo("BillingForm");
			this.Hide();
		}

		private void logout_icon_Click(object sender, EventArgs e)
		{
            string employeeId = MyAppContext.EmpID;
            DialogResult exitDialog = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNoCancel);
			if (exitDialog == DialogResult.Yes)
			{
				FormManager.NavigateTo("LoginForm");
				EmployeeActivityLogger.LogLogout(employeeId);
				this.Hide();
			}
		}

		private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//base.OnFormClosing(e);

			//if (e.CloseReason == CloseReason.UserClosing)
			//{
			//    e.Cancel = true;
			//    Hide();
			//} 
		}   

		private void home_back_icon_Click(object sender, EventArgs e)
		{
			FormManager.GoBack();
			this.Hide();
		}

		private void home_options_MouseEnter(object sender, EventArgs e)
		{
			home_options.Size = new Size(home_options.Width + 10, home_options.Height + 10);
		}
		private void home_options_MouseLeave(object sender, EventArgs e)
		{
			home_options.Size = new Size(home_options.Width - 10, home_options.Height - 10);
		}

		private void logout_icon_MouseEnter(object sender, EventArgs e)
		{
			
			logout_icon.Size = new Size(logout_icon.Width + 10, logout_icon.Height + 10);
		}

		private void logout_icon_MouseLeave(object sender, EventArgs e)
		{
			
			logout_icon.Size = new Size(logout_icon.Width - 10, logout_icon.Height - 10);
		}

		private void billing_icon_MouseEnter(object sender, EventArgs e)
		{
			billing_icon.Size = new Size(billing_icon.Width + 10, billing_icon.Height + 10);
		}

		private void billing_icon_MouseLeave(object sender, EventArgs e)
		{
			billing_icon.Size = new Size(billing_icon.Width - 10, billing_icon.Height - 10);
		}

		private void employees_icon_MouseEnter(object sender, EventArgs e)
		{
			employees_icon.Size = new Size(employees_icon.Width + 10, employees_icon.Height + 10);
		}

		private void employees_icon_MouseLeave(object sender, EventArgs e)
		{
			employees_icon.Size = new Size(employees_icon.Width - 10, employees_icon.Height - 10);
		}

		private void medicine_icon_MouseEnter(object sender, EventArgs e)
		{
			medicine_icon.Size = new Size(medicine_icon.Width + 10, medicine_icon.Height + 10);
		}

		private void medicine_icon_MouseLeave(object sender, EventArgs e)
		{
			medicine_icon.Size = new Size(medicine_icon.Width - 10, medicine_icon.Height - 10);
		}

		private void companies_icon_MouseEnter(object sender, EventArgs e)
		{
			companies_icon.Size = new Size(companies_icon.Width + 10, companies_icon.Height + 10);
		}

		private void companies_icon_MouseLeave(object sender, EventArgs e)
		{
			companies_icon.Size = new Size(companies_icon.Width - 10, companies_icon.Height - 10);
		}

		private void home_options_Click(object sender, EventArgs e)
		{
			FormManager.NavigateTo("OptionsForm");
			this.Hide();
		}

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuCards1_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo("LogHistory");
            this.Hide();
        }

        private void bunifuGauge1_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo("LogHistory");
            this.Hide();
        }
    }
}
