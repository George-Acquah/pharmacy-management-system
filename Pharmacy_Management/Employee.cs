using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Pharmacy_Management.auth;
using Pharmacy_Management.utils.constants;
using Pharmacy_Management.utils.functions;
using Pharmacy_Management.utils.connections;
using Pharmacy_Management.utils.contexts;

namespace Pharmacy_Management
{
    public partial class Employee : Form
    {
        SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString);

        string empSalaryErrorMessage = EmployeeConstants.empSalaryErrorMessage;
        string empAgeErrorMessage = EmployeeConstants.empAgeErrorMessage;
        string empPKIdErrorMessage = EmployeeConstants.empPKIdErrorMessage;

        readonly string userRole = MyAppContext.UserRole;

        public void populate()
        {
            dbConnection.Open();
            string Myquery = "select * from Employee_tb";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, dbConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            EmployeeDataGridView.DataSource = ds.Tables[0];
            dbConnection.Close();
        }
        private void reset()
        {
            empidtb.Text = ResetTextFields.resetInputs(EmployeeConstants.empIdText);
            empnametb.Text = ResetTextFields.resetInputs(EmployeeConstants.empNameText);
            empsaltb.Text = ResetTextFields.resetInputs(EmployeeConstants.empSalText);
            empagetb.Text = ResetTextFields.resetInputs(EmployeeConstants.empAgeText);
            empphonetb.Text = ResetTextFields.resetInputs(EmployeeConstants.empPhoneText);
            emppasstb.Text = ResetTextFields.resetInputs(EmployeeConstants.empPassText);    
        }

        private string getSelectedCompany()
        {
            string selectedRole = string.Empty;

            if (rolescb.SelectedItem is DataRowView selectedRow)
            {
                selectedRole = selectedRow["RoleName"].ToString();
                return selectedRole;
            }
            else
            {
                selectedRole = rolescb.SelectedItem != null  ? rolescb.SelectedItem.ToString() : null;
                return selectedRole;
            }
        }

        public void fillComboBox()
        {
            dbConnection.Open();
            string mySql = "select RoleName from Roles_tbl";
            SqlCommand cmd = new SqlCommand(mySql, dbConnection);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoleName", typeof(string));
            dt.Load(rdr);
            rolescb.ValueMember = "RoleName";
            rolescb.DataSource = dt;
            dbConnection.Close();
        }
        public Employee()
        {
            InitializeComponent();
        }


        //BEGIN VALUE CHANGE HANDLERS
        private void bptb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void sptb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empphonetb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empidtb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void empsaltb_OnValueChanged(object sender, EventArgs e)
        {

        }
        //END VALUE CHANGE HANDLERS



        //BEGIN CLICK HANDLERS 
        private void addempbtn_Click(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                if (empidtb.Text == "" || empnametb.Text == "" || empsaltb.Text == "" || empagetb.Text == "" || empphonetb.Text == "" || emppasstb.Text == "")
                {
                    MessageBox.Show("Wrong Inputs... Fill All the Information");
                }
                else
                {
                    med_sal_err.Visible = false;
                    med_age_err.Visible = false;
                    emp_id_err.Visible = false;

                    try
                    {
                        string enteredPass = emppasstb.Text;
                        string hashedPass = HashPasswords.HashFunction(enteredPass);
                        dbConnection.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Employee_tb values('" + empnametb.Text + "'," + empsaltb.Text + ",'" + empagetb.Text + "','" + empphonetb.Text + "','" + hashedPass + "','" + getSelectedCompany() + "')", dbConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Successfully Added");
                        dbConnection.Close();
                        populate();
                        reset();
                    }
                    catch (Exception ex)
                    {
                        string errMessage = ex.Message.ToString();
                        Console.WriteLine(errMessage);
                        dbConnection.Close();
                        if (errMessage.Contains("Salary"))
                        {
                            med_sal_err.Text = empSalaryErrorMessage;
                            med_sal_err.Visible = true;
                        }

                        if (errMessage.Contains("Employee Age"))
                        {
                            med_age_err.Text = empAgeErrorMessage;
                            med_age_err.Visible = true;
                        }

                        if (errMessage.Contains("PRIMARY KEY"))
                        {
                            emp_id_err.Text = empPKIdErrorMessage;
                            emp_id_err.Visible = true;
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Only an admin can perform this action. Please contact your admin.");
            }
        }

        private void updateempbtn_Click(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                if (empnametb.Text == "" || empnametb.Text == "Employee Name")
                {
                    MessageBox.Show("Wrong Operation... Click on the employee to be Updated");
                }
                else
                {
                    try
                    {
                        dbConnection.Open();
                        String myQuery = "UPDATE Employee_tb SET  EmpName = '" + empnametb.Text + "', EmpSalary = " + empsaltb.Text + ", EmpAge = " + empagetb.Text + ", EmpPhone = '" + empphonetb.Text + "', EmpPassword = '" + emppasstb.Text + "', EmpRole = '" + getSelectedCompany() + "' WHERE EmpId = '" + empidtb.Text + "';";
                        SqlCommand cmd = new SqlCommand(myQuery, dbConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Updated Successfully");
                        dbConnection.Close();
                        populate();
                        reset();
                    }
                    catch (Exception ex)
                    {
                        string errMessage = ex.Message.ToString();
                        MessageBox.Show("Please select an employee to update...");
                        dbConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Only an admin can perform this action. Please contact your admin.");
            }
        }

        private void deleteempbtn_Click(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                if (empnametb.Text == "" || empnametb.Text == "Employee Name")
                {
                    MessageBox.Show("Wrong Operation... Click on the employee to be Deleted");
                }
                else
                {
                    DialogResult exitDialog = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo);
                    if (exitDialog == DialogResult.Yes)
                    {
                        dbConnection.Open();
                        string query = "DELETE FROM Employee_tb WHERE EmpName = '" + empnametb.Text + "';";
                        Console.WriteLine(query);
                        SqlCommand cmd = new SqlCommand(query, dbConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Deleted Successfully");
                        dbConnection.Close();
                        populate();
                        reset();
                    }
                }
            }
            else
            {
                MessageBox.Show("Only an admin can perform this action. Please contact your admin.");
            }
        }

        private void backempbtn_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo("HomeForm");
            this.Hide();
        }
        //END CLICK HANDLERS

        private void Employee_Load(object sender, EventArgs e)
        {
            FormManager.RegisterForm("Employee", this);
            FormManager.RegisterForm("RolesForm", new RolesForm());
            FormManager.RegisterForm("HomeForm", new HomeForm());

            FormManager.RegisterForm("Login", new Login());

            string userRole = MyAppContext.UserRole;
            string userName = MyAppContext.userName;

            if (userName == null || userName == "" || userRole == null || userRole == "")
            {
                Console.WriteLine("Null checker working");
                FormManager.NavigateTo("Login");
                this.Hide();
            }
            else
            {
                populate();
                fillComboBox();
            }
            populate();
            fillComboBox();
        }

        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            empidtb.Text = EmployeeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            empnametb.Text = EmployeeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            empsaltb.Text = EmployeeDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            empagetb.Text = EmployeeDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            empphonetb.Text = EmployeeDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            emppasstb.Text = EmployeeDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        //BEGIN FOCUS HANDLERS
        private void empidtb_Enter(object sender, EventArgs e)
        {
            emp_id_err.Text = "This field is auto generated";
            emp_id_err.Visible = true;
            string text = empidtb.Text;
            if (text == EmployeeConstants.empIdText)
            {
                empidtb.Text = "";
            }
            else
            {
                empidtb.Text = text;
            }
        }

        private void empidtb_Leave(object sender, EventArgs e)
        {
            emp_id_err.Text = "";
            emp_id_err.Visible = false;
            string text = empidtb.Text;
            if (text == "")
            {
                empidtb.Text = EmployeeConstants.empIdText;
            }
            else
            {
                empidtb.Text = text;
            }
        }

        private void empnametb_Enter(object sender, EventArgs e)
        {
            string text = empnametb.Text;
            if (text == EmployeeConstants.empNameText)
            {
                empnametb.Text = "";
            }
            else
            {
                empnametb.Text = text;
            }
        }

        private void empnametb_Leave(object sender, EventArgs e)
        {
            string text = empnametb.Text;
            if (text == "")
            {
                empnametb.Text = EmployeeConstants.empNameText;
            }
            else
            {
                empnametb.Text = text;
            }
        }

        private void empagetb_Enter(object sender, EventArgs e)
        {
            string text = empagetb.Text;
            if (text == EmployeeConstants.empAgeText)
            {
                empagetb.Text = "";
            }
            else
            {
                empagetb.Text = text;
            }
        }

        private void empagetb_Leave(object sender, EventArgs e)
        {
            string text = empagetb.Text;
            if (text == "")
            {
                empagetb.Text = EmployeeConstants.empAgeText;
            }
            else
            {
                empagetb.Text = text;
            }
        }

        private void empsaltb_Enter(object sender, EventArgs e)
        {
            string text = empsaltb.Text;
            if (text == EmployeeConstants.empSalText)
            {
                empsaltb.Text = "";
            }
            else
            {
                empsaltb.Text = text;
            }
        }

        private void empsaltb_Leave(object sender, EventArgs e)
        {
            string text = empsaltb.Text;
            if (text == "")
            {
                empsaltb.Text = EmployeeConstants.empSalText;
            }
            else
            {
                empsaltb.Text = text;
            }
        }

        private void empphonetb_Enter(object sender, EventArgs e)
        {
            string text = empphonetb.Text;
            if (text == EmployeeConstants.empPhoneText)
            {
                empphonetb.Text = "";
            }
            else
            {
                empphonetb.Text = text;
            }
        }

        private void empphonetb_Leave(object sender, EventArgs e)
        {
            string text = empphonetb.Text;
            if (text == "")
            {
                empphonetb.Text = EmployeeConstants.empPhoneText;
            }
            else
            {
                empphonetb.Text = text;
            }
        }

        private void emppasstb_Enter(object sender, EventArgs e)
        {
            string text = emppasstb.Text;
            if (text == EmployeeConstants.empPassText)
            {
                emppasstb.Text = "";
            }
            else
            {
                emppasstb.Text = text;
            }
        }

        private void emppasstb_Leave(object sender, EventArgs e)
        {
            string text = emppasstb.Text;
            if (text == "")
            {
                emppasstb.Text = EmployeeConstants.empPassText;
            }
            else
            {
                emppasstb.Text = text;
            }
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            //base.OnFormClosing(e);

            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;  // Cancel the form closing
            //    Hide();  // Hide the form instead of disposing it
            //}
        }

        private void view_roles_icon_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo("RolesForm");
            this.Hide();
        }

        private void emp_back_icon_Click(object sender, EventArgs e)
        {
            FormManager.GoBack();
            this.Hide();
        }

        private void view_roles_icon_MouseEnter(object sender, EventArgs e)
        {
            sh_roles_tt.Visible = true;
        }

        private void view_roles_icon_MouseLeave(object sender, EventArgs e)
        {
            sh_roles_tt.Visible = false;
        }

        private void Employee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                addempbtn_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.U)
            {
                updateempbtn_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.Back)
            {
                emp_back_icon_Click(sender, e);
            }
            if (e.Control && (e.KeyCode == Keys.Home || e.KeyCode == Keys.H))
            {
                backempbtn_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.Delete)
            {
                deleteempbtn_Click(sender, e);
            }
            if (e.Control && e.Alt && e.KeyCode == Keys.V)
            {
                view_roles_icon_Click(sender, e);
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.Delete)
            {
                reset();
            }
        }

        private void emp_clear_Click(object sender, EventArgs e)
        {
            reset();
        }

        //END FOCUS HANDLERS
    }
}
