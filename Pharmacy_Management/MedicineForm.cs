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
using Pharmacy_Management.utils.functions;
using Pharmacy_Management.utils.connections;
using Pharmacy_Management.utils.constants;
using Pharmacy_Management.utils.contexts;

namespace Pharmacy_Management
{
    public partial class MedicineForm : Form
    {
        SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString);

        string medPriceErrorMessage = MedicineConstants.medPriceErrorMessage;
        string medQtyErrorMessage = MedicineConstants.medQtyErrorMessage;
        string medPKIdErrorMessage = MedicineConstants.medPKIdErrorMessage;
        string invalidQuantity = MedicineConstants.invalidQuantity;

        string wrongOperation = Shared.wrongOperation("Medicine");
        string updateSuccess = Shared.updateSuccess("Medicine");
        string addSuccess = Shared.addSuccess("Medicine");
        string deleteSuccess = Shared.deleteSuccess("Medicine");
        string noSelection_update = Shared.noSelection("medicine", "update");
        string noSelection_delete = Shared.noSelection("medicine", "delete");
        string missingData = Shared.missingData;


        string medNameText = MedicineConstants.medNameText;
        string medQtyText = MedicineConstants.medQtyText;
        string medBPText = MedicineConstants.medBPText;
        string medSPText = MedicineConstants.medSPText;

        readonly string userRole = MyAppContext.UserRole;


        private string getSelectedCompany()
        {
            string selectedCompany = string.Empty;

            if (companycb.SelectedItem is DataRowView selectedRow)
            {
                selectedCompany = selectedRow["CompName"].ToString();
                return selectedCompany;
            }
            else if (companycb.SelectedItem == null)
            {
                MessageBox.Show("You did not select any company...");
                return string.Empty;
            }
            else
            {
                selectedCompany = companycb.SelectedItem.ToString();
                return selectedCompany;
            }
        }
        public void populate()
        {
            dbConnection.Open();
            string Myquery = "select * from Medicine_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, dbConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            MedicineGridView.ReadOnly = true;
            MedicineGridView.DataSource = ds.Tables[0];
            dbConnection.Close();
        }

        public MedicineForm()
        {
            InitializeComponent();
        }

        private void reset()
        {
            mednametb.Text = ResetTextFields.resetInputs(medNameText);
            qtytb.Text = ResetTextFields.resetInputs(medQtyText);
            bptb.Text = ResetTextFields.resetInputs(medBPText);
            sptb.Text = ResetTextFields.resetInputs(medSPText);
        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mednametb.Text = MedicineGridView.SelectedRows[0].Cells[0].Value.ToString();
            bptb.Text = MedicineGridView.SelectedRows[0].Cells[1].Value.ToString();
            sptb.Text = MedicineGridView.SelectedRows[0].Cells[2].Value.ToString();
            qtytb.Text = MedicineGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                if (mednametb.Text == "" || mednametb.Text == medNameText)
                {
                    MessageBox.Show(wrongOperation);
                }
                else
                {
                    DialogResult exitDialog = MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo);
                    if (exitDialog == DialogResult.Yes)
                    {
                        try
                        {
                            dbConnection.Open();
                            string query = "DELETE FROM Medicine_tbl WHERE MedName = '" + mednametb.Text + "';";
                            SqlCommand cmd = new SqlCommand(query, dbConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show(deleteSuccess);
                            dbConnection.Close();
                            populate();
                            reset();
                        }
                        catch (Exception ex)
                        {
                            string errMessage = ex.Message.ToString();
                            MessageBox.Show(noSelection_delete);
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
        public void fillComboBox()
        {
            dbConnection.Open();
            string mySql = "select CompName from Company_tbl";
            SqlCommand cmd = new SqlCommand(mySql, dbConnection);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CompName", typeof(string));
            dt.Load(rdr);
            companycb.ValueMember = "CompName";
            companycb.DataSource = dt;
            dbConnection.Close();
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            FormManager.RegisterForm("MedicineForm", this);
            FormManager.RegisterForm("Company", new Company());
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
                fillComboBox();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                if (mednametb.Text == "" || mednametb.Text == medNameText)
                {
                    MessageBox.Show(wrongOperation);
                }
                else
                {
                    try
                    {
                        med_bp_err.Visible = false;
                        med_sp_err.Visible = false;
                        med_name_err.Visible = false;
                        sh_comp_tt.Visible = false;

                        
                        if (Convert.ToInt32(qtytb.Text) == 0)
                        {
                            sh_comp_tt.Text = invalidQuantity;
                            sh_comp_tt.Visible = true;
                        }

                        else if (mednametb.Text == "" || sptb.Text == "" || bptb.Text == "" || companycb.SelectedItem == null || Convert.ToString(companycb.SelectedItem) == "")
                        {
                            MessageBox.Show(missingData);
                        }
                        else
                        {
                            try
                            {
                                dbConnection.Open();
                                String Myquery = "UPDATE Medicine_tbl SET Bprice = '" + bptb.Text + "', Sprice = '" + sptb.Text + "', MedQty = '" + qtytb.Text + "', ExpDate = '" + ExpireDate.Text + "', Company = '" + getSelectedCompany() + "' WHERE MedName = '" + mednametb.Text + "';";
                                SqlCommand cmd = new SqlCommand(Myquery, dbConnection);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show(updateSuccess);
                                dbConnection.Close();
                                populate();
                                reset();
                            }
                            catch (Exception ex)
                            {
                                string errMessage = ex.Message.ToString();
                                Console.WriteLine(errMessage);
                                dbConnection.Close();
                                if (errMessage.Contains("Quantity"))
                                {
                                    sh_comp_tt.Text = medQtyErrorMessage;
                                    sh_comp_tt.Visible = true;
                                }

                                if (errMessage.Contains("Buying"))
                                {
                                    med_bp_err.Text = medPriceErrorMessage;
                                    med_bp_err.Visible = true;
                                }

                                if (errMessage.Contains("Selling"))
                                {
                                    med_sp_err.Text = medPriceErrorMessage;
                                    med_sp_err.Visible = true;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        string errMessage = ex.Message.ToString();
                        MessageBox.Show(noSelection_update);
                        dbConnection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Only an admin can perform this action. Please contact your admin.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (userRole == "Admin")
            {
                if (mednametb.Text == "" || sptb.Text == "" || bptb.Text == "" || companycb.SelectedItem == null)
                {
                    MessageBox.Show(missingData);
                }
                else
                {
                    try
                    {
                        med_bp_err.Visible = false;
                        med_sp_err.Visible = false;
                        med_name_err.Visible = false;
                        sh_comp_tt.Visible = false;

                        if (mednametb.Text == medNameText)
                        {
                            med_name_err.Text = medPKIdErrorMessage;
                            med_name_err.Visible = true;
                        }
                        else
                        {
                            try
                            {
                                dbConnection.Open();
                                SqlCommand cmd = new SqlCommand("insert into Medicine_tbl values('" + mednametb.Text + "','" + bptb.Text + "','" + sptb.Text + "','" + qtytb.Text + "','" + ExpireDate.Text + "','" + getSelectedCompany() + "')", dbConnection);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show(addSuccess);
                                dbConnection.Close();
                                populate();
                                reset();
                            }
                            catch (Exception ex)
                            {
                                string errMessage = ex.Message.ToString();
                                Console.WriteLine(errMessage);
                                dbConnection.Close();
                                if (errMessage.Contains("Quantity"))
                                {
                                    sh_comp_tt.Text = medQtyErrorMessage;
                                    sh_comp_tt.Visible = true;
                                }

                                if (errMessage.Contains("Buying"))
                                {
                                    med_bp_err.Text = medPriceErrorMessage;
                                    med_bp_err.Visible = true;
                                }

                                if (errMessage.Contains("Selling"))
                                {
                                    med_sp_err.Text = medPriceErrorMessage;
                                    med_sp_err.Visible = true;
                                }

                                if (errMessage.Contains("PRIMARY KEY"))
                                {
                                    med_name_err.Text = medPKIdErrorMessage;
                                    med_name_err.Visible = true;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unknown err: " + ex.Message.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Only an admin can perform this action. Please contact your admin.");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo("HomeForm");
            this.Hide();
        }

        private void mednametb_Enter(object sender, EventArgs e)
        {
            string text = mednametb.Text;
            if (text == medNameText)
            {
                mednametb.Text = "";
            }
            else
            {
                mednametb.Text = text;
            }
        }

        private void mednametb_Leave(object sender, EventArgs e)
        {
            string text = mednametb.Text;
            if (text == "")
            {
                mednametb.Text = medNameText;
            }
            else
            {
                mednametb.Text = text;
            }
        }

        private void bptb_Enter(object sender, EventArgs e)
        {
            string text = bptb.Text;
            if (text == medBPText)
            {
                bptb.Text = "";
            }
            else
            {
                bptb.Text = text;
            }
        }

        private void bptb_Leave(object sender, EventArgs e)
        {
            string text = bptb.Text;
            if (text == "")
            {
                bptb.Text = medBPText;
            }
            else
            {
                bptb.Text = text;
            }
        }

        private void sptb_Enter(object sender, EventArgs e)
        {
            string text = sptb.Text;
            if (text == medSPText)
            {
                sptb.Text = "";
            }
            else
            {
                sptb.Text = text;
            }
        }

        private void sptb_Leave(object sender, EventArgs e)
        {
            string text = sptb.Text;
            if (text == "")
            {
                sptb.Text = medSPText;
            }
            else
            {
                sptb.Text = text;
            }
        }

        private void qtytb_Enter(object sender, EventArgs e)
        {
            string text = qtytb.Text;
            if (text == medQtyText)
            {
                qtytb.Text = "";
            }
            else
            {
                qtytb.Text = text;
            }
        }

        private void qtytb_Leave(object sender, EventArgs e)
        {
            string text = qtytb.Text;
            if (text == "")
            {
                qtytb.Text = medQtyText;
            }
            else
            {
                qtytb.Text = text;
            }
        }

        private void MedicineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //base.OnFormClosing(e);

            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = true;  // Cancel the form closing
            //    Hide();  // Hide the form instead of disposing it
            //}
        }

        private void view_comp_icon_MouseEnter(object sender, EventArgs e)
        {
            sh_comp_tt.Visible = true;
        }

        private void view_comp_icon_MouseLeave(object sender, EventArgs e)
        {
            sh_comp_tt.Visible = false;
        }

        private void view_comp_icon_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo("Company");
            this.Hide();
        }

        private void med_back_icon_Click(object sender, EventArgs e)
        {
            FormManager.GoBack();
            this.Hide();
        }

        private void MedicineForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                guna2Button1_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.U)
            {
                guna2Button2_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.Back)
            {
                med_back_icon_Click(sender, e);
            }
            if (e.Control && (e.KeyCode == Keys.Home || e.KeyCode == Keys.H))
            {
                guna2Button4_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.Delete)
            {
                guna2Button3_Click(sender, e);
            }
            if (e.Control && e.Alt && e.KeyCode == Keys.V)
            {
                view_comp_icon_Click(sender, e);
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.Delete)
            {
                reset();
            }
        }

        private void med_clear_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
