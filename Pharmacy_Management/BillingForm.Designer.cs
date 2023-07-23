namespace Pharmacy_Management
{
    partial class BillingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Qty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Stocklbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.BillingGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Printbtn = new Guna.UI2.WinForms.Guna2Button();
            this.homebtn = new Guna.UI2.WinForms.Guna2Button();
            this.billing_lbl = new System.Windows.Forms.Label();
            this.bill_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bill_back_icon = new System.Windows.Forms.PictureBox();
            this.customer_err_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customer_lbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bill_clear = new Guna.UI2.WinForms.Guna2Button();
            this.bill_combo_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bill_cancel_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_back_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Location = new System.Drawing.Point(53, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 25);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Select Medicine";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangecommitted);
            // 
            // Qty
            // 
            this.Qty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Qty.ForeColor = System.Drawing.Color.Black;
            this.Qty.HintForeColor = System.Drawing.Color.Empty;
            this.Qty.HintText = "";
            this.Qty.isPassword = false;
            this.Qty.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.Qty.LineIdleColor = System.Drawing.Color.Gray;
            this.Qty.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.Qty.LineThickness = 3;
            this.Qty.Location = new System.Drawing.Point(18, 184);
            this.Qty.Margin = new System.Windows.Forms.Padding(4);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(178, 33);
            this.Qty.TabIndex = 3;
            this.Qty.Text = "Quantity";
            this.Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Qty.Enter += new System.EventHandler(this.Qty_Enter);
            this.Qty.Leave += new System.EventHandler(this.Qty_Leave);
            // 
            // Stocklbl
            // 
            this.Stocklbl.AutoSize = true;
            this.Stocklbl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stocklbl.Location = new System.Drawing.Point(61, 131);
            this.Stocklbl.Name = "Stocklbl";
            this.Stocklbl.Size = new System.Drawing.Size(133, 18);
            this.Stocklbl.TabIndex = 4;
            this.Stocklbl.Text = "Available Stock";
            this.Stocklbl.Click += new System.EventHandler(this.Stocklbl_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BorderRadius = 7;
            this.Addbtn.CheckedState.Parent = this.Addbtn;
            this.Addbtn.CustomImages.Parent = this.Addbtn;
            this.Addbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.Addbtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.Addbtn.HoverState.Parent = this.Addbtn;
            this.Addbtn.Location = new System.Drawing.Point(43, 284);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.ShadowDecoration.Parent = this.Addbtn;
            this.Addbtn.Size = new System.Drawing.Size(103, 45);
            this.Addbtn.TabIndex = 10;
            this.Addbtn.Text = "Add To Bill";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // BillingGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BillingGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillingGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillingGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BillingGridView.BackgroundColor = System.Drawing.Color.White;
            this.BillingGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillingGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillingGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillingGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillingGridView.ColumnHeadersHeight = 35;
            this.BillingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedId,
            this.MedName,
            this.MedQty,
            this.UnitPrice,
            this.TotalPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillingGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillingGridView.EnableHeadersVisualStyles = false;
            this.BillingGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillingGridView.Location = new System.Drawing.Point(468, 6);
            this.BillingGridView.Name = "BillingGridView";
            this.BillingGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BillingGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.BillingGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BillingGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.BillingGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.BillingGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.BillingGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.BillingGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 3);
            this.BillingGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.BillingGridView.RowTemplate.Height = 35;
            this.BillingGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.BillingGridView.ShowCellToolTips = false;
            this.BillingGridView.ShowEditingIcon = false;
            this.BillingGridView.Size = new System.Drawing.Size(674, 441);
            this.BillingGridView.TabIndex = 11;
            this.BillingGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.BillingGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillingGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillingGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillingGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillingGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillingGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillingGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillingGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkCyan;
            this.BillingGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillingGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillingGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillingGridView.ThemeStyle.HeaderStyle.Height = 35;
            this.BillingGridView.ThemeStyle.ReadOnly = false;
            this.BillingGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillingGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillingGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillingGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.BillingGridView.ThemeStyle.RowsStyle.Height = 35;
            this.BillingGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.BillingGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.BillingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillingGridView_CellContentClick);
            // 
            // MedId
            // 
            this.MedId.HeaderText = "MedId";
            this.MedId.Name = "MedId";
            // 
            // MedName
            // 
            this.MedName.HeaderText = "MedName";
            this.MedName.Name = "MedName";
            // 
            // MedQty
            // 
            this.MedQty.HeaderText = "Quantity";
            this.MedQty.Name = "MedQty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // TotalAmount
            // 
            this.TotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.ForeColor = System.Drawing.Color.DarkCyan;
            this.TotalAmount.Location = new System.Drawing.Point(717, 453);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(221, 41);
            this.TotalAmount.TabIndex = 13;
            this.TotalAmount.Text = "Total Amount";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Printbtn
            // 
            this.Printbtn.BorderRadius = 7;
            this.Printbtn.CheckedState.Parent = this.Printbtn;
            this.Printbtn.CustomImages.Parent = this.Printbtn;
            this.Printbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.Printbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbtn.ForeColor = System.Drawing.Color.White;
            this.Printbtn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.Printbtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.Printbtn.HoverState.Parent = this.Printbtn;
            this.Printbtn.Location = new System.Drawing.Point(953, 500);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.ShadowDecoration.Parent = this.Printbtn;
            this.Printbtn.Size = new System.Drawing.Size(103, 45);
            this.Printbtn.TabIndex = 14;
            this.Printbtn.Text = "PRINT";
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.BorderRadius = 7;
            this.homebtn.CheckedState.Parent = this.homebtn;
            this.homebtn.CustomImages.Parent = this.homebtn;
            this.homebtn.FillColor = System.Drawing.Color.DarkCyan;
            this.homebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.homebtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.homebtn.HoverState.Parent = this.homebtn;
            this.homebtn.Location = new System.Drawing.Point(550, 500);
            this.homebtn.Name = "homebtn";
            this.homebtn.ShadowDecoration.Parent = this.homebtn;
            this.homebtn.Size = new System.Drawing.Size(103, 45);
            this.homebtn.TabIndex = 15;
            this.homebtn.Text = "HOME";
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // billing_lbl
            // 
            this.billing_lbl.AutoSize = true;
            this.billing_lbl.Font = new System.Drawing.Font("Segoe UI Emoji", 27.75F, System.Drawing.FontStyle.Bold);
            this.billing_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.billing_lbl.Location = new System.Drawing.Point(55, 12);
            this.billing_lbl.Name = "billing_lbl";
            this.billing_lbl.Size = new System.Drawing.Size(229, 49);
            this.billing_lbl.TabIndex = 16;
            this.billing_lbl.Text = "Billing Form";
            // 
            // bill_err
            // 
            this.bill_err.BackColor = System.Drawing.Color.Transparent;
            this.bill_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_err.ForeColor = System.Drawing.Color.Red;
            this.bill_err.Location = new System.Drawing.Point(18, 224);
            this.bill_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.bill_err.Name = "bill_err";
            this.bill_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bill_err.Size = new System.Drawing.Size(180, 20);
            this.bill_err.TabIndex = 22;
            this.bill_err.Text = "error";
            this.bill_err.Visible = false;
            // 
            // bill_back_icon
            // 
            this.bill_back_icon.BackColor = System.Drawing.Color.Transparent;
            this.bill_back_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bill_back_icon.BackgroundImage")));
            this.bill_back_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bill_back_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bill_back_icon.Location = new System.Drawing.Point(12, 20);
            this.bill_back_icon.Name = "bill_back_icon";
            this.bill_back_icon.Size = new System.Drawing.Size(43, 30);
            this.bill_back_icon.TabIndex = 23;
            this.bill_back_icon.TabStop = false;
            this.bill_back_icon.Click += new System.EventHandler(this.bill_back_icon_Click);
            // 
            // customer_err_lbl
            // 
            this.customer_err_lbl.BackColor = System.Drawing.Color.Transparent;
            this.customer_err_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_err_lbl.ForeColor = System.Drawing.Color.Red;
            this.customer_err_lbl.Location = new System.Drawing.Point(250, 224);
            this.customer_err_lbl.MinimumSize = new System.Drawing.Size(180, 0);
            this.customer_err_lbl.Name = "customer_err_lbl";
            this.customer_err_lbl.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.customer_err_lbl.Size = new System.Drawing.Size(180, 20);
            this.customer_err_lbl.TabIndex = 25;
            this.customer_err_lbl.Text = "error";
            this.customer_err_lbl.Visible = false;
            // 
            // customer_lbl
            // 
            this.customer_lbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customer_lbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customer_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.customer_lbl.ForeColor = System.Drawing.Color.Black;
            this.customer_lbl.HintForeColor = System.Drawing.Color.Empty;
            this.customer_lbl.HintText = "";
            this.customer_lbl.isPassword = false;
            this.customer_lbl.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.customer_lbl.LineIdleColor = System.Drawing.Color.Gray;
            this.customer_lbl.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.customer_lbl.LineThickness = 3;
            this.customer_lbl.Location = new System.Drawing.Point(250, 184);
            this.customer_lbl.Margin = new System.Windows.Forms.Padding(4);
            this.customer_lbl.Name = "customer_lbl";
            this.customer_lbl.Size = new System.Drawing.Size(178, 33);
            this.customer_lbl.TabIndex = 24;
            this.customer_lbl.Text = "Customer Name";
            this.customer_lbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customer_lbl.Enter += new System.EventHandler(this.customer_lbl_Enter);
            this.customer_lbl.Leave += new System.EventHandler(this.customer_lbl_Leave);
            // 
            // bill_clear
            // 
            this.bill_clear.BorderRadius = 7;
            this.bill_clear.CheckedState.Parent = this.bill_clear;
            this.bill_clear.CustomImages.Parent = this.bill_clear;
            this.bill_clear.FillColor = System.Drawing.Color.DarkCyan;
            this.bill_clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_clear.ForeColor = System.Drawing.Color.White;
            this.bill_clear.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.bill_clear.HoverState.ForeColor = System.Drawing.Color.White;
            this.bill_clear.HoverState.Parent = this.bill_clear;
            this.bill_clear.Location = new System.Drawing.Point(279, 284);
            this.bill_clear.Name = "bill_clear";
            this.bill_clear.ShadowDecoration.Parent = this.bill_clear;
            this.bill_clear.Size = new System.Drawing.Size(103, 45);
            this.bill_clear.TabIndex = 26;
            this.bill_clear.Text = "CLEAR";
            this.bill_clear.Click += new System.EventHandler(this.bill_clear_Click);
            // 
            // bill_combo_err
            // 
            this.bill_combo_err.BackColor = System.Drawing.Color.Transparent;
            this.bill_combo_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_combo_err.ForeColor = System.Drawing.Color.Red;
            this.bill_combo_err.Location = new System.Drawing.Point(202, 74);
            this.bill_combo_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.bill_combo_err.Name = "bill_combo_err";
            this.bill_combo_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.bill_combo_err.Size = new System.Drawing.Size(180, 20);
            this.bill_combo_err.TabIndex = 27;
            this.bill_combo_err.Text = "error";
            this.bill_combo_err.Visible = false;
            // 
            // bill_cancel_btn
            // 
            this.bill_cancel_btn.BorderRadius = 7;
            this.bill_cancel_btn.CheckedState.Parent = this.bill_cancel_btn;
            this.bill_cancel_btn.CustomImages.Parent = this.bill_cancel_btn;
            this.bill_cancel_btn.FillColor = System.Drawing.Color.DarkCyan;
            this.bill_cancel_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_cancel_btn.ForeColor = System.Drawing.Color.White;
            this.bill_cancel_btn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.bill_cancel_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.bill_cancel_btn.HoverState.Parent = this.bill_cancel_btn;
            this.bill_cancel_btn.Location = new System.Drawing.Point(764, 500);
            this.bill_cancel_btn.Name = "bill_cancel_btn";
            this.bill_cancel_btn.ShadowDecoration.Parent = this.bill_cancel_btn;
            this.bill_cancel_btn.Size = new System.Drawing.Size(103, 45);
            this.bill_cancel_btn.TabIndex = 28;
            this.bill_cancel_btn.Text = "CANCEL";
            this.bill_cancel_btn.Click += new System.EventHandler(this.bill_cancel_btn_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1149, 566);
            this.Controls.Add(this.bill_cancel_btn);
            this.Controls.Add(this.bill_combo_err);
            this.Controls.Add(this.bill_clear);
            this.Controls.Add(this.customer_err_lbl);
            this.Controls.Add(this.customer_lbl);
            this.Controls.Add(this.bill_back_icon);
            this.Controls.Add(this.bill_err);
            this.Controls.Add(this.billing_lbl);
            this.Controls.Add(this.homebtn);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.BillingGridView);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Stocklbl);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BillingForm_FormClosing);
            this.Load += new System.EventHandler(this.BillingForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BillingForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.BillingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_back_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Qty;
        private Bunifu.Framework.UI.BunifuCustomLabel Stocklbl;
        private Guna.UI2.WinForms.Guna2Button Addbtn;
        private Guna.UI2.WinForms.Guna2DataGridView BillingGridView;
        private Guna.UI2.WinForms.Guna2HtmlLabel TotalAmount;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2Button Printbtn;
        private Guna.UI2.WinForms.Guna2Button homebtn;
        private System.Windows.Forms.Label billing_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel bill_err;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.PictureBox bill_back_icon;
        private Guna.UI2.WinForms.Guna2HtmlLabel customer_err_lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox customer_lbl;
        private Guna.UI2.WinForms.Guna2Button bill_clear;
        private Guna.UI2.WinForms.Guna2HtmlLabel bill_combo_err;
        private Guna.UI2.WinForms.Guna2Button bill_cancel_btn;
    }
}