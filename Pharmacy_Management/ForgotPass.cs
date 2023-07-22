using Pharmacy_Management.utils.constants;
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
    public partial class ForgotPass : Form
    {
        string id_name = "Emp Id";
        string name_text = "Emp Name";
        string empRole = MyAppContext.UserRole;
        UserManager userManager = new UserManager();

        public ForgotPass()
        {
            InitializeComponent();
        }

        private void id_name_text_Enter(object sender, EventArgs e)
        {
            string text = id_text.Text;
            if (text == id_name)
            {
                id_text.Text = "";
            }
            else
            {
                id_text.Text = text;
            }
        }

        
        private void id_name_text_Leave(object sender, EventArgs e)
        {
            string text = id_text.Text;
            if (text == "")
            {
                id_text.Text = id_name;
            }
            else
            {
                id_text.Text = text;
            }
        }

        private void id_name_text_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void employeeRequestReset()
        {
            if (id_text.Text == id_name || id_text.Text == "")
            {
                id_name_err.Text = "Please input valid employee id or name";
                id_name_err.Visible = true;
            }
            else
            {
                string empId = id_text.Text != null ? id_text.Text.ToString() : "";
                string empName = emp_name_text.Text != null  ? emp_name_text.Text.ToString() : "";

                bool resetRequested = userManager.RequestPasswordReset(empId, empName);
                if (resetRequested)
                {
                    MessageBox.Show("Password reset requested successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User not found or password reset already requested!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {

                employeeRequestReset();
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

        }

        private void emp_name_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                reset_btn_Click(sender, e);
            }
        }

        private void emp_name_text_Enter(object sender, EventArgs e)
        {
            string text = emp_name_text.Text;
            if (text == name_text)
            {
                emp_name_text.Text = "";
            }
            else
            {
                emp_name_text.Text = text;
            }
        }

        private void emp_name_text_Leave(object sender, EventArgs e)
        {
            string text = emp_name_text.Text;
            if (text == "")
            {
                emp_name_text.Text = name_text;
            }
            else
            {
                emp_name_text.Text = text;
            }
        }

        private void exit_icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
