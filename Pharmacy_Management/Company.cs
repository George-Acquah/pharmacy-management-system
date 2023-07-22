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
using Pharmacy_Management.utils.constants;
using Pharmacy_Management.utils.functions;
using Pharmacy_Management.auth;
using Pharmacy_Management.utils.connections;
using Pharmacy_Management.utils.contexts;

namespace Pharmacy_Management
{
    public partial class Company : Form
    {
        SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString);

        string compPKIdErrorMessage = CompanyConstants.compPKIdErrorMessage;
        string compPhoneErrorMessage = CompanyConstants.compPhoneErrorMessage;
        readonly string userRole = MyAppContext.UserRole;

        public void populate()
        {
            dbConnection.Open();
            string Myquery = "select * from Company_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, dbConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            CompanyDataGridView.DataSource = ds.Tables[0];
            dbConnection.Close();
        }

        private void reset()
        {
            companyidtb.Text = ResetTextFields.resetInputs(CompanyConstants.compIdText);
            compnametb.Text = ResetTextFields.resetInputs(CompanyConstants.compNameText);
            compphonetb.Text = ResetTextFields.resetInputs(CompanyConstants.compPhoneText);
            compaddrtb.Text = ResetTextFields.resetInputs(CompanyConstants.compAddrText);
        }
        public Company()
        {
            InitializeComponent();
        }

        private void companyidtb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void compnametb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void compphonetb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void compaddrtb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void addcompbtn_Click(object sender, EventArgs e)
        {
            if(userRole == "Admin")
            {
                if (compnametb.Text == "" || compphonetb.Text == "" || compaddrtb.Text == "")
                {
                    MessageBox.Show("Wrong Inputs.Fill All the Information");
                }
                else
                {
                    comp_name_err.Visible = false;
                    comp_pn_err.Visible = false;
                    comp_id_err.Visible = false;

                    try
                    {
                        if (compphonetb.Text.Length != 10)
                        {
                            comp_pn_err.Text = compPhoneErrorMessage;
                            comp_pn_err.Visible = true;
                        }
                        else
                        {
                            dbConnection.Open();
                            SqlCommand cmd = new SqlCommand("INSERT INTO Company_tbl values('" + compnametb.Text + "','" + compphonetb.Text + "','" + compaddrtb.Text + "')", dbConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Company Successfully Added");
                            dbConnection.Close();
                            populate();
                            reset();
                        }
                    }
                    catch (Exception ex)
                    {
                        string errMessage = ex.Message.ToString();
                        dbConnection.Close();
                        if (errMessage.Contains("PRIMARY KEY"))
                        {
                            comp_id_err.Text = compPKIdErrorMessage;
                            comp_id_err.Visible = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Only an admin can perform this action. Please contact your admin.");
            }
        }

            private void updatecompbtn_Click(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                if (compnametb.Text == "" || compnametb.Text == "Company Name")
                {
                    MessageBox.Show("Wrong Operation... Click on the company to be Updated");
                }
                else
                {
                    try
                    {
                        if (companyidtb.Text == "" || compnametb.Text == "" || compphonetb.Text == "" || compaddrtb.Text == "")
                        {
                            MessageBox.Show("Please fill all forms to update");
                        }
                        if (compphonetb.Text.Length != 10)
                        {
                            comp_pn_err.Text = compPhoneErrorMessage;
                            comp_pn_err.Visible = true;
                        }
                        else
                        {
                            dbConnection.Open();
                            String myQuery = "UPDATE Company_tbl SET  CompName = '" + compnametb.Text + "', CompPhone = '" + compphonetb.Text + "', CompAddress = '" + compaddrtb.Text + "' WHERE CompId = '" + companyidtb.Text + "';";
                            SqlCommand cmd = new SqlCommand(myQuery, dbConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Company Updated Successfully");
                            dbConnection.Close();
                            populate();
                            reset();
                        }
                    }
                    catch (Exception ex)
                    {
                        string errMessage = ex.Message.ToString();
                        MessageBox.Show("Please select a company to update...");
                        dbConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Only an admin can perform this action. Please contact your admin.");
            }
        }

        private void deletcomppbtn_Click(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                if (compnametb.Text == "" || compnametb.Text == "Company Name")
                {
                    MessageBox.Show("Wrong Operation.Click on the company to be Deleted");
                }
                else
                {
                    DialogResult exitDialog = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo);
                    if (exitDialog == DialogResult.Yes)
                    {
                        try
                        {
                            dbConnection.Open();
                            string query = "DELETE FROM Company_tbl WHERE CompName = '" + compnametb.Text + "';";
                            SqlCommand cmd = new SqlCommand(query, dbConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Company Deleted Successfully");
                            dbConnection.Close();
                            populate();
                            reset();
                        }
                        catch (Exception ex)
                        {
                            string errMessage = ex.Message.ToString();
                            MessageBox.Show("Please select a company to delete...");
                            dbConnection.Close();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Only an admin can perform this action. Please contact your admin.");
            }
        }

        private void backcompbtn_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo("HomeForm");
            this.Hide();
        }


        private void Company_Load(object sender, EventArgs e)
        {
            FormManager.RegisterForm("Company", this);
            FormManager.RegisterForm("HomeForm", new HomeForm());

            FormManager.RegisterForm("Login", new Login());

            string userRole = MyAppContext.UserRole;
            string userName = MyAppContext.userName;

            if (userName == null || userName == "" || userRole == null || userRole == "")
            {
                Console.WriteLine("Null checker working");
                FormManager.NavigateTo("Login");
                this.Close();
            }
            else
            {
                populate();
            }
        }

        private void CompanyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            companyidtb.Text = CompanyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            compnametb.Text = CompanyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            compphonetb.Text = CompanyDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            compaddrtb.Text = CompanyDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        //BEGIN FOCUS HANDLERS
        private void companyidtb_Enter(object sender, EventArgs e)
        {
            string text = companyidtb.Text;
            if (text == "Company Id")
            {
                companyidtb.Text = "";
            }
            else
            {
                companyidtb.Text = text;
            }
        }

        private void companyidtb_Leave(object sender, EventArgs e)
        {
            string text = companyidtb.Text;
            if (text == "")
            {
                companyidtb.Text = "Company Id";
            }
            else
            {
                companyidtb.Text = text;
            }
        }

        private void compnametb_Enter(object sender, EventArgs e)
        {
            string text = compnametb.Text;
            if (text == "Company Name")
            {
                compnametb.Text = "";
            }
            else
            {
                compnametb.Text = text;
            }
        }

        private void compnametb_Leave(object sender, EventArgs e)
        {
            string text = compnametb.Text;
            if (text == "")
            {
                compnametb.Text = "Company Name";
            }
            else
            {
                compnametb.Text = text;
            }
        }

        private void compphonetb_Enter(object sender, EventArgs e)
        {
            string text = compphonetb.Text;
            if (text == "Phone Number")
            {
                compphonetb.Text = "";
            }
            else
            {
                compphonetb.Text = text;
            }
        }

        private void compphonetb_Leave(object sender, EventArgs e)
        {
            string text = compphonetb.Text;
            if (text == "")
            {
                compphonetb.Text = "Phone Number";
            }
            else
            {
                compphonetb.Text = text;
            }
        }

        private void compaddrtb_Enter(object sender, EventArgs e)
        {
            string text = compaddrtb.Text;
            if (text == "Address")
            {
                compaddrtb.Text = "";
            }
            else
            {
                compaddrtb.Text = text;
            }
        }

        private void compaddrtb_Leave(object sender, EventArgs e)
        {
            string text = compaddrtb.Text;
            if (text == "")
            {
                compaddrtb.Text = "Address";
            }
            else
            {
                compaddrtb.Text = text;
            }
        }

        private void Company_FormClosing(object sender, FormClosingEventArgs e)
        {
            //base.OnFormClosing(e);

            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;  // Cancel the form closing
            //    Hide();  // Hide the form instead of disposing it
            //}
        }

        private void comp_back_icon_Click(object sender, EventArgs e)
        {
            FormManager.GoBack();
            this.Hide();
        }

        private void med_clear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void Company_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                addcompbtn_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.U)
            {
                updatecompbtn_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.Back)
            {
                comp_back_icon_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.Delete)
            {
                deletcomppbtn_Click(sender, e);
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.Delete)
            {
                reset();
            }
        }

        //END FOCUS HANDLERS


    }
}
