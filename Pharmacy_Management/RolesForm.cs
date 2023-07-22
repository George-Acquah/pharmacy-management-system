using Pharmacy_Management.auth;
using Pharmacy_Management.utils.connections;
using Pharmacy_Management.utils.constants;
using Pharmacy_Management.utils.contexts;
using Pharmacy_Management.utils.functions;
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
    public partial class RolesForm : Form
    {
        SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString);

        private string roleId = "Role Id";
        private string roleName = "Role Name";

        readonly string userRole = MyAppContext.UserRole;
        public void populate()
        {
            dbConnection.Open();
            string Myquery = "select * from Roles_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, dbConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            RoleDataGridView.DataSource = ds.Tables[0];
            dbConnection.Close();
        }

        private void reset()
        {
            roleidlbl.Text = ResetTextFields.resetInputs(roleId);
            rolenamelbl.Text = ResetTextFields.resetInputs(roleName);
        }
        public RolesForm()
        {
            InitializeComponent();
        }

        private void add_role_btn_Click(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                if (rolenamelbl.Text == "" || rolenamelbl.Text == "Role Name")
                {
                    MessageBox.Show("Please input Role to proceed...");
                }
                else
                {
                    role_id_err.Visible = false;
                    role_name_err.Visible = false;

                    try
                    {

                        dbConnection.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Roles_tbl values('" + rolenamelbl.Text + "')", dbConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Role Successfully Added");
                        dbConnection.Close();
                        populate();
                        reset();
                    }
                    catch (Exception ex)
                    {
                        string errMessage = ex.Message.ToString();
                        dbConnection.Close();
                        if (errMessage.Contains("PRIMARY KEY"))
                        {
                            role_id_err.Text = "A Primary Key Error Occured...";
                            role_id_err.Visible = true;
                        }
                        else if (errMessage.Contains("Name"))
                        {
                            role_id_err.Text = "A Role Name Error Occured...";
                            role_id_err.Visible = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Only an admin can perform this action. Please contact your admin.");
            }
        }

        private void update_role_btn_Click(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                if (rolenamelbl.Text == "" || rolenamelbl.Text == "Role Name")
                {
                    MessageBox.Show("Wrong Operation... Click on the role to be Updated");
                }
                else
                {
                    DialogResult updateDialog = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo);
                    if (updateDialog == DialogResult.Yes)
                    {
                        try
                        {
                            if (roleidlbl.Text == "" || rolenamelbl.Text == "")
                            {
                                MessageBox.Show("Please fill all forms to update");
                            }

                            dbConnection.Open();
                            String myQuery = "UPDATE Roles_tbl SET  RoleName = '" + rolenamelbl.Text + "', RoleId = '" + roleId + "';";
                            SqlCommand cmd = new SqlCommand(myQuery, dbConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Role Updated Successfully");
                            dbConnection.Close();
                            populate();
                            reset();
                        }
                        catch (Exception ex)
                        {
                            string errMessage = ex.Message.ToString();
                            MessageBox.Show("Please select a role to update...");
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

        private void del_role_btn_Click(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                if (rolenamelbl.Text == "" || rolenamelbl.Text == "Role Name")
                {
                    MessageBox.Show("Wrong Operation... Click on the role to be Updated");
                }
                else
                {
                    DialogResult exitDialog = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo);
                    if (exitDialog == DialogResult.Yes)
                    {
                        try
                        {
                            dbConnection.Open();
                            string query = "DELETE FROM Roles_tbl WHERE RoleName = '" + rolenamelbl.Text + "';";
                            SqlCommand cmd = new SqlCommand(query, dbConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Role Deleted Successfully");
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

        private void home_btn_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo("HomeForm");
            this.Hide();
        }

        private void back_icon_Click_1(object sender, EventArgs e)
        {
            FormManager.GoBack();
            this.Hide();
        }

        private void rolenamelbl_Enter(object sender, EventArgs e)
        {
            string text = rolenamelbl.Text;
            if (text == roleName)
            {
                rolenamelbl.Text = "";
            }
            else
            {
                rolenamelbl.Text = text;
            }
        }

        private void rolenamelbl_Leave(object sender, EventArgs e)
        {
            string text = rolenamelbl.Text;
            if (text == "")
            {
                rolenamelbl.Text = roleName;
            }
            else
            {
                rolenamelbl.Text = text;
            }
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            FormManager.RegisterForm("RolesForm", this);
            FormManager.RegisterForm("Employee", new Employee());
            FormManager.RegisterForm("HomeForm", new HomeForm());
            populate();
        }

        private void RoleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roleidlbl.Text = RoleDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            rolenamelbl.Text = RoleDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void role_clear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void RolesForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                add_role_btn_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.U)
            {
                update_role_btn_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.Back)
            {
                back_icon_Click_1(sender, e);
            }
            if (e.Control && (e.KeyCode == Keys.Home || e.KeyCode == Keys.H))
            {
                home_btn_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.Delete)
            {
                del_role_btn_Click(sender, e);
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.Delete)
            {
                reset();
            }
        }
    }
}
