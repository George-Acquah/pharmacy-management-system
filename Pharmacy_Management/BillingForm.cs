using Pharmacy_Management.auth;
using Pharmacy_Management.utils.connections;
using Pharmacy_Management.utils.constants;
using Pharmacy_Management.utils.contexts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Management
{
    public partial class BillingForm : Form
    {
        SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString);
        private string myLastSaleIdQusery = BillingConstants.myLastSaleIdQusery;
        private string mySaleId = BillingConstants.saleId;
        private string query = "SELECT MedName from Medicine_tbl";

        public void populateComboBox()
        {
            string mySql = "select * from Medicine_tbl";
            SqlCommand cmd = new SqlCommand(mySql, dbConnection);
            SqlDataReader rdr;
            try
            {
                dbConnection.Open();
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("MedName", typeof(string));
                dt.Load(rdr);
                comboBox1.ValueMember = "MedName";
                comboBox1.DataSource = dt;
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while populating combo box: " + ex.Message);
                // You can also output the exception details to the console or log file for further analysis.
                Console.WriteLine(ex.ToString());
            }
        }

        int x, unitp;
        public void fetchQuantity()
        {
            try
            {
                dbConnection.Open();
                string mySql = "Select * from Medicine_tbl where MedName = '" + comboBox1.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand(mySql, dbConnection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    x = Convert.ToInt32(dr["MedQty"].ToString());
                    unitp = Convert.ToInt32(dr["Sprice"].ToString());
                    Stocklbl.Text = "Available stock is " + dr["MedQty"].ToString();
                    Stocklbl.Visible = true;
                }
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while fetching quantity: " + ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        public void updateMedicine()
        {
            try
            {
                dbConnection.Open();
                int newQty = x - Convert.ToInt32(Qty.Text);
                String Myquery = "UPDATE Medicine_tbl SET MedQty = " + newQty + " WHERE MedName = '" + comboBox1.SelectedValue.ToString() + "';";
                SqlCommand cmd = new SqlCommand(Myquery, dbConnection);
                cmd.ExecuteNonQuery();
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while updating medicine: " + ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        public void reset(string inp)
        {
            Qty.Text = "Quantity";
            
            Stocklbl.Text = "Available Stock";

            customer_lbl.Text = "Customer Name";

            customer_err_lbl.Visible = false;
            bill_err.Visible = false;
            
            comboBox1.Text = "Select Medicine";

            if (inp == "cancel")
            {
                BillingGridView.Rows.Clear();
                TotalAmount.Text = "Total Amount";
            }
            dbConnection.Close();
        }

        public BillingForm()
        {
            InitializeComponent();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            FormManager.RegisterForm("BillingForm", this);
			FormManager.RegisterForm("HomeForm", new HomeForm());
            FormManager.RegisterForm("Login", new Login());

            //string userRole = MyAppContext.UserRole;
            //string userName = MyAppContext.userName;

            //if (userName == null || userName == "" || userRole == null || userRole == "")
            //{
            //    Console.WriteLine("Null checker working");
            //    FormManager.NavigateTo("Login");
            //    this.Hide();
            //}
            //else
            //{
            //    populateComboBox();
            //    //getLastId();
            //    MyAppContext.saleId = NewId.getLastId(myLastSaleIdQusery, mySaleId);
            //}
            populateComboBox();
            //getLastId();
            MyAppContext.saleId = NewId.getLastId(myLastSaleIdQusery, mySaleId);
        }

        int gridTotal = 0;
        int n = 1;
        string billErrorMessage = "Please provide a valid quantity to proceed";
        private void Addbtn_Click(object sender, EventArgs e)
        {
            bill_err.Visible = false;
            if (comboBox1.SelectedValue != null)
            {
                string itemName = comboBox1.SelectedValue.ToString();
                try
                {
                    int quantity = Convert.ToInt32(Qty.Text);

                    if (Qty.Text == "" || Qty.Text == "Quantity")
                    {
                        bill_err.Text = billErrorMessage;
                        bill_err.Visible = true;
                    }
                    else if (quantity == 0)
                    {
                        bill_err.Text = "Can't add an empty medicine to bill";
                        bill_err.Visible = true;
                    }
                    else
                    {
                        try
                        {
                            if (Convert.ToInt32(Qty.Text) > x)
                            {
                                MessageBox.Show("No Enough Stock... Please Check Available Stock!!!");
                            }
                            else
                            {
                                bool itemExists = false;

                                // Search for the item in the BillingGridView
                                foreach (DataGridViewRow row in BillingGridView.Rows)
                                {
                                    string existingItem = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";

                                    if (existingItem == itemName)
                                    {
                                        // Item already exists, update the quantity
                                        int existingQuantity = Convert.ToInt32(row.Cells[2].Value);
                                        row.Cells[2].Value = existingQuantity + quantity;

                                        // Recalculate the total for the row
                                        int unitPrice = Convert.ToInt32(row.Cells[3].Value);
                                        row.Cells[4].Value = unitPrice * (existingQuantity + quantity);

                                        itemExists = true;
                                        break;
                                    }
                                }

                                if (!itemExists)
                                {
                                    // Item does not exist, add a new row
                                    int unitPrice = unitp;
                                    int total = quantity * unitPrice;

                                    DataGridViewRow newRow = new DataGridViewRow();
                                    newRow.CreateCells(BillingGridView);
                                    newRow.Cells[0].Value = n;
                                    newRow.Cells[1].Value = itemName;
                                    newRow.Cells[2].Value = quantity;
                                    newRow.Cells[3].Value = unitPrice;
                                    newRow.Cells[4].Value = total;
                                    BillingGridView.Rows.Add(newRow);
                                }

                                gridTotal += quantity * unitp;
                                TotalAmount.Text = "GHc" + gridTotal;

                                updateMedicine();
                                fetchQuantity();
                            }
                        }
                        catch (Exception ex)
                        {
                            string errMessage = ex.Message.ToString();
                            Console.WriteLine(errMessage);
                            dbConnection.Close();
                            bill_err.Text = billErrorMessage;
                            bill_err.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    string errMessage = ex.Message.ToString();
                    Console.WriteLine(errMessage);
                    bill_err.Text = billErrorMessage;
                    bill_err.Visible = true;
                }
            }
            else
            {
                bill_combo_err.Text = "Please select this field...";
                bill_combo_err.Visible = true;
            }
            bill_combo_err.Visible = false;
        }

        private void InsertSalesData()
        {
            try
            {
                string userName = MyAppContext.userName;
                string customerName = customer_lbl.Text;
                // Open the database connection
                dbConnection.Open();

                // Iterate over the rows in the BillingGridView and insert the sales data
                foreach (DataGridViewRow row in BillingGridView.Rows)
                {
                    string itemName = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";
                    int quantity = Convert.ToInt32(row.Cells[2].Value);
                    int unitPrice = Convert.ToInt32(row.Cells[3].Value);
                    int totalPrice = Convert.ToInt32(row.Cells[4].Value);

                    if (quantity != 0)
                    {
                    // Build the SQL query to insert the sales data into the database
                    string query = "INSERT INTO SalesAnalytics_tbl (ItemName, ItemQuantity, UnitPrice, TotalPrice, SaleDate, Customer, SalePerson) " +
                                   "VALUES ( @ItemName, @ItemQuantity, @UnitPrice, @TotalPrice, @SaleDate, @Customer, @SalePerson)";

                    SqlCommand cmd = new SqlCommand(query, dbConnection);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@ItemQuantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    cmd.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Customer", customerName);
                    cmd.Parameters.AddWithValue("@SalePerson", userName);

                    // Execute the SQL query
                    cmd.ExecuteNonQuery();
                    }
                }

                // Close the database connection
                dbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while inserting sales data: " + ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        private void BillingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangecommitted(object sender, EventArgs e)
        {
            fetchQuantity();
        }

        Bitmap bitmap;
        //private void Printbtn_Click(object sender, EventArgs e)
        //{
        //    //Panel panel = new Panel();
        //    //this.Controls.Add(panel);
        //    //Graphics graphics = panel.CreateGraphics();
        //    //Size size = this.ClientSize;
        //    //bitmap = new Bitmap(size.Width, size.Height, graphics);
        //    //graphics = Graphics.FromImage(bitmap);
        //    //Point point = PointToScreen(panel.Location);
        //    //graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
        //    //printPreviewDialog1.Document = printDocument1;
        //    //printPreviewDialog1.ShowDialog();
        //    GenerateReceipt();
        //}

        private void reCalculateQty(string inp)
        {
                try
                {
                    // Open the database connection
                    dbConnection.Open();

                    // Iterate over the rows in the BillingGridView and update the medicine quantity
                    foreach (DataGridViewRow row in BillingGridView.Rows)
                    {
                        string itemName = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : "";
                        int quantity = row.Cells[2].Value != null ? Convert.ToInt32(row.Cells[2].Value) :  0;

                        if(itemName != null && quantity != 0)
                    {
                        // Retrieve the original quantity of the medicine
                        string query = "SELECT MedQty FROM Medicine_tbl WHERE MedName = '" + itemName + "'";
                        SqlCommand cmd = new SqlCommand(query, dbConnection);
                        int originalQty = Convert.ToInt32(cmd.ExecuteScalar());

                        // Update the quantity of the medicine back to its original value
                        int newQty = originalQty + quantity;
                        query = "UPDATE Medicine_tbl SET MedQty = " + newQty + " WHERE MedName = '" + itemName + "'";
                        cmd = new SqlCommand(query, dbConnection);
                        cmd.ExecuteNonQuery();
                        if (inp == "cancel")
                        {
                            Stocklbl.Text = "Available Stock is " + newQty;
                            gridTotal = 0;
                        }

                    }
                    }

                    // Close the database connection
                    dbConnection.Close();

                // Reset the form
                //reset();
                if (inp == "cancel")
                {
                    customer_err_lbl.Visible = false;
                    bill_err.Visible = false;
                    BillingGridView.Rows.Clear();
                    TotalAmount.Text = "Total Amount";
                }

            }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while canceling the bill: " + ex.Message);
                    Console.WriteLine(ex.ToString());
                }

        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            GenerateReceipt();
            InsertSalesData();
            reset("cancel");
        }
        string space = "                            ";
        string smallSpace = "          ";
        private void GenerateReceipt()
        {
            StringBuilder receipt = new StringBuilder();

            receipt.AppendLine(space + smallSpace + "==================== RECEIPT ====================");
            receipt.AppendLine($" {space} {space} {space} Date: {DateTime.Now.ToString()}");
            receipt.AppendLine();

            int itemNo = 1;
            foreach (DataGridViewRow row in BillingGridView.Rows)
            {
                string itemName = Convert.ToString(row.Cells[1].Value);
                int quantity = Convert.ToInt32(row.Cells[2].Value);
                int unitPrice = Convert.ToInt32(row.Cells[3].Value);
                int totalPrice = Convert.ToInt32(row.Cells[4].Value);
                string customerName = customer_lbl.Text;
                string salesPerson = MyAppContext.userName;

                if (quantity != 0)
                {
                receipt.AppendLine($"{space} {smallSpace} Customer Name: {customerName}");
                receipt.AppendLine($"{space} {smallSpace} Sales Person Name: {salesPerson}");
                receipt.AppendLine($"{space} {smallSpace}  Item No: {itemNo}");
                receipt.AppendLine($"{space} {smallSpace} Item Name: {itemName}");
                receipt.AppendLine($"{space} {smallSpace} Quantity: {quantity}");
                receipt.AppendLine($"{space} {smallSpace} Unit Price: GHc {unitPrice}");
                receipt.AppendLine($"{space} {smallSpace} Total Price: GHc {totalPrice}");
                receipt.AppendLine();

                itemNo++;
                }
            }

            receipt.AppendLine(space + smallSpace + "==================================================");
            receipt.AppendLine($"{space} {smallSpace} Total Amount: GHc {gridTotal}");
            receipt.AppendLine(space + smallSpace + "==================================================");

            // Print the receipt
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(receipt.ToString(), new Font("Arial", 12), Brushes.Black, new PointF(10, 10));
            };
            pd.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0); 
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo("HomeForm");
            this.Hide();
        }

        private void Qty_Enter(object sender, EventArgs e)
        {
            if (Qty.Text == "Quantity")
            {
                Qty.Text = "";
            }
            else
            {
                Qty.Text = Qty.Text;
            }
        }


        private void Qty_Leave(object sender, EventArgs e)
        {
            if(Qty.Text == "")
            {
                Qty.Text = Qty.Text;
            }
            else
            {
                Qty.Text = Qty.Text;
            }
        }

        private void BillingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A || e.KeyCode == Keys.Add))
            {
                Addbtn_Click(sender, e);
            }
            if (e.Control && (e.KeyCode == Keys.Print || e.KeyCode == Keys.PrintScreen))
            {
                Printbtn_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.Back)
            {
                bill_back_icon_Click(sender, e);
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.Delete)
            {
                bill_clear_Click(sender, e);
            }
            if (e.Control && (e.KeyCode == Keys.Home || e.KeyCode == Keys.LWin))
            {
                homebtn_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.Z)
            {
                bill_cancel_btn_Click(sender, e);
            }
        }

        private void BillingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void bill_back_icon_Click(object sender, EventArgs e)
        {
            reCalculateQty("");
            FormManager.GoBack();
            this.Hide();
        }

        private void customer_lbl_Enter(object sender, EventArgs e)
        {
            if (customer_lbl.Text == "Customer Name")
            {
                customer_lbl.Text = "";
            }
            else
            {
                customer_lbl.Text = customer_lbl.Text;
            }
        }

        private void customer_lbl_Leave(object sender, EventArgs e)
        {
            if (customer_lbl.Text == "")
            {
                customer_lbl.Text = "Customer Name";
            }
            else
            {
                customer_lbl.Text = customer_lbl.Text;
            }
        }

        private void bill_clear_Click(object sender, EventArgs e)
        {
            //reCalculateQty("");
            reset("a");
        }

        private void bill_cancel_btn_Click(object sender, EventArgs e)
        {
            reCalculateQty("cancel");
            
        }

        private void Stocklbl_Click(object sender, EventArgs e)
        {

        }

    }
}
