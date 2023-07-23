namespace Pharmacy_Management
{
    partial class Company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Company));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmpLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.compaddrtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.compphonetb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.compnametb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.companyidtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.backcompbtn = new Guna.UI2.WinForms.Guna2Button();
            this.deletcomppbtn = new Guna.UI2.WinForms.Guna2Button();
            this.updatecompbtn = new Guna.UI2.WinForms.Guna2Button();
            this.addcompbtn = new Guna.UI2.WinForms.Guna2Button();
            this.comp_id_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comp_pn_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comp_aadr_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comp_name_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comp_back_icon = new System.Windows.Forms.PictureBox();
            this.med_clear = new Guna.UI2.WinForms.Guna2Button();
            this.CompanyDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.comp_back_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpLabel
            // 
            this.EmpLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.EmpLabel.Location = new System.Drawing.Point(61, 16);
            this.EmpLabel.Name = "EmpLabel";
            this.EmpLabel.Size = new System.Drawing.Size(383, 44);
            this.EmpLabel.TabIndex = 2;
            this.EmpLabel.Text = "Medicine Manufacturer";
            // 
            // compaddrtb
            // 
            this.compaddrtb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.compaddrtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.compaddrtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.compaddrtb.ForeColor = System.Drawing.Color.Black;
            this.compaddrtb.HintForeColor = System.Drawing.Color.Empty;
            this.compaddrtb.HintText = "";
            this.compaddrtb.isPassword = false;
            this.compaddrtb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.compaddrtb.LineIdleColor = System.Drawing.Color.Gray;
            this.compaddrtb.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.compaddrtb.LineThickness = 3;
            this.compaddrtb.Location = new System.Drawing.Point(254, 247);
            this.compaddrtb.Margin = new System.Windows.Forms.Padding(4);
            this.compaddrtb.Name = "compaddrtb";
            this.compaddrtb.Size = new System.Drawing.Size(178, 33);
            this.compaddrtb.TabIndex = 24;
            this.compaddrtb.Text = "Address";
            this.compaddrtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.compaddrtb.OnValueChanged += new System.EventHandler(this.compaddrtb_OnValueChanged);
            this.compaddrtb.Enter += new System.EventHandler(this.compaddrtb_Enter);
            this.compaddrtb.Leave += new System.EventHandler(this.compaddrtb_Leave);
            // 
            // compphonetb
            // 
            this.compphonetb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.compphonetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.compphonetb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.compphonetb.ForeColor = System.Drawing.Color.Black;
            this.compphonetb.HintForeColor = System.Drawing.Color.Empty;
            this.compphonetb.HintText = "";
            this.compphonetb.isPassword = false;
            this.compphonetb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.compphonetb.LineIdleColor = System.Drawing.Color.Gray;
            this.compphonetb.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.compphonetb.LineThickness = 3;
            this.compphonetb.Location = new System.Drawing.Point(254, 138);
            this.compphonetb.Margin = new System.Windows.Forms.Padding(4);
            this.compphonetb.Name = "compphonetb";
            this.compphonetb.Size = new System.Drawing.Size(178, 33);
            this.compphonetb.TabIndex = 23;
            this.compphonetb.Text = "Phone Number";
            this.compphonetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.compphonetb.OnValueChanged += new System.EventHandler(this.compphonetb_OnValueChanged);
            this.compphonetb.Enter += new System.EventHandler(this.compphonetb_Enter);
            this.compphonetb.Leave += new System.EventHandler(this.compphonetb_Leave);
            // 
            // compnametb
            // 
            this.compnametb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.compnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.compnametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.compnametb.ForeColor = System.Drawing.Color.Black;
            this.compnametb.HintForeColor = System.Drawing.Color.Empty;
            this.compnametb.HintText = "";
            this.compnametb.isPassword = false;
            this.compnametb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.compnametb.LineIdleColor = System.Drawing.Color.Gray;
            this.compnametb.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.compnametb.LineThickness = 3;
            this.compnametb.Location = new System.Drawing.Point(27, 247);
            this.compnametb.Margin = new System.Windows.Forms.Padding(4);
            this.compnametb.Name = "compnametb";
            this.compnametb.Size = new System.Drawing.Size(178, 33);
            this.compnametb.TabIndex = 22;
            this.compnametb.Text = "Company Name";
            this.compnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.compnametb.OnValueChanged += new System.EventHandler(this.compnametb_OnValueChanged);
            this.compnametb.Enter += new System.EventHandler(this.compnametb_Enter);
            this.compnametb.Leave += new System.EventHandler(this.compnametb_Leave);
            // 
            // companyidtb
            // 
            this.companyidtb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.companyidtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyidtb.Enabled = false;
            this.companyidtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.companyidtb.ForeColor = System.Drawing.Color.Black;
            this.companyidtb.HintForeColor = System.Drawing.Color.Empty;
            this.companyidtb.HintText = "";
            this.companyidtb.isPassword = false;
            this.companyidtb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.companyidtb.LineIdleColor = System.Drawing.Color.Gray;
            this.companyidtb.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.companyidtb.LineThickness = 3;
            this.companyidtb.Location = new System.Drawing.Point(27, 138);
            this.companyidtb.Margin = new System.Windows.Forms.Padding(4);
            this.companyidtb.Name = "companyidtb";
            this.companyidtb.Size = new System.Drawing.Size(178, 33);
            this.companyidtb.TabIndex = 21;
            this.companyidtb.Text = "Company Id";
            this.companyidtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.companyidtb.OnValueChanged += new System.EventHandler(this.companyidtb_OnValueChanged);
            this.companyidtb.Enter += new System.EventHandler(this.companyidtb_Enter);
            this.companyidtb.Leave += new System.EventHandler(this.companyidtb_Leave);
            // 
            // backcompbtn
            // 
            this.backcompbtn.BorderRadius = 5;
            this.backcompbtn.CheckedState.Parent = this.backcompbtn;
            this.backcompbtn.CustomImages.Parent = this.backcompbtn;
            this.backcompbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.backcompbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backcompbtn.ForeColor = System.Drawing.Color.White;
            this.backcompbtn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.backcompbtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.backcompbtn.HoverState.Parent = this.backcompbtn;
            this.backcompbtn.Location = new System.Drawing.Point(102, 509);
            this.backcompbtn.Name = "backcompbtn";
            this.backcompbtn.ShadowDecoration.Parent = this.backcompbtn;
            this.backcompbtn.Size = new System.Drawing.Size(105, 45);
            this.backcompbtn.TabIndex = 28;
            this.backcompbtn.Text = "HOME";
            this.backcompbtn.Click += new System.EventHandler(this.backcompbtn_Click);
            // 
            // deletcomppbtn
            // 
            this.deletcomppbtn.BorderRadius = 5;
            this.deletcomppbtn.CheckedState.Parent = this.deletcomppbtn;
            this.deletcomppbtn.CustomImages.Parent = this.deletcomppbtn;
            this.deletcomppbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.deletcomppbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletcomppbtn.ForeColor = System.Drawing.Color.White;
            this.deletcomppbtn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.deletcomppbtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.deletcomppbtn.HoverState.Parent = this.deletcomppbtn;
            this.deletcomppbtn.Location = new System.Drawing.Point(327, 442);
            this.deletcomppbtn.Name = "deletcomppbtn";
            this.deletcomppbtn.ShadowDecoration.Parent = this.deletcomppbtn;
            this.deletcomppbtn.Size = new System.Drawing.Size(105, 45);
            this.deletcomppbtn.TabIndex = 27;
            this.deletcomppbtn.Text = "DELETE";
            this.deletcomppbtn.Click += new System.EventHandler(this.deletcomppbtn_Click);
            // 
            // updatecompbtn
            // 
            this.updatecompbtn.BorderRadius = 5;
            this.updatecompbtn.CheckedState.Parent = this.updatecompbtn;
            this.updatecompbtn.CustomImages.Parent = this.updatecompbtn;
            this.updatecompbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.updatecompbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatecompbtn.ForeColor = System.Drawing.Color.White;
            this.updatecompbtn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.updatecompbtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.updatecompbtn.HoverState.Parent = this.updatecompbtn;
            this.updatecompbtn.Location = new System.Drawing.Point(175, 442);
            this.updatecompbtn.Name = "updatecompbtn";
            this.updatecompbtn.ShadowDecoration.Parent = this.updatecompbtn;
            this.updatecompbtn.Size = new System.Drawing.Size(105, 45);
            this.updatecompbtn.TabIndex = 26;
            this.updatecompbtn.Text = "UPDATE";
            this.updatecompbtn.Click += new System.EventHandler(this.updatecompbtn_Click);
            // 
            // addcompbtn
            // 
            this.addcompbtn.BorderRadius = 5;
            this.addcompbtn.CheckedState.Parent = this.addcompbtn;
            this.addcompbtn.CustomImages.Parent = this.addcompbtn;
            this.addcompbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.addcompbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcompbtn.ForeColor = System.Drawing.Color.White;
            this.addcompbtn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.addcompbtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.addcompbtn.HoverState.Parent = this.addcompbtn;
            this.addcompbtn.Location = new System.Drawing.Point(27, 442);
            this.addcompbtn.Name = "addcompbtn";
            this.addcompbtn.ShadowDecoration.Parent = this.addcompbtn;
            this.addcompbtn.Size = new System.Drawing.Size(103, 45);
            this.addcompbtn.TabIndex = 25;
            this.addcompbtn.Text = "ADD";
            this.addcompbtn.Click += new System.EventHandler(this.addcompbtn_Click);
            // 
            // comp_id_err
            // 
            this.comp_id_err.BackColor = System.Drawing.Color.Transparent;
            this.comp_id_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp_id_err.ForeColor = System.Drawing.Color.Red;
            this.comp_id_err.Location = new System.Drawing.Point(27, 178);
            this.comp_id_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.comp_id_err.Name = "comp_id_err";
            this.comp_id_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comp_id_err.Size = new System.Drawing.Size(180, 20);
            this.comp_id_err.TabIndex = 30;
            this.comp_id_err.Text = "error";
            this.comp_id_err.Visible = false;
            // 
            // comp_pn_err
            // 
            this.comp_pn_err.BackColor = System.Drawing.Color.Transparent;
            this.comp_pn_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp_pn_err.ForeColor = System.Drawing.Color.Red;
            this.comp_pn_err.Location = new System.Drawing.Point(252, 178);
            this.comp_pn_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.comp_pn_err.Name = "comp_pn_err";
            this.comp_pn_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comp_pn_err.Size = new System.Drawing.Size(180, 20);
            this.comp_pn_err.TabIndex = 31;
            this.comp_pn_err.Text = "error";
            this.comp_pn_err.Visible = false;
            // 
            // comp_aadr_err
            // 
            this.comp_aadr_err.BackColor = System.Drawing.Color.Transparent;
            this.comp_aadr_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp_aadr_err.ForeColor = System.Drawing.Color.Red;
            this.comp_aadr_err.Location = new System.Drawing.Point(254, 287);
            this.comp_aadr_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.comp_aadr_err.Name = "comp_aadr_err";
            this.comp_aadr_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comp_aadr_err.Size = new System.Drawing.Size(180, 20);
            this.comp_aadr_err.TabIndex = 32;
            this.comp_aadr_err.Text = "error";
            this.comp_aadr_err.Visible = false;
            // 
            // comp_name_err
            // 
            this.comp_name_err.BackColor = System.Drawing.Color.Transparent;
            this.comp_name_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comp_name_err.ForeColor = System.Drawing.Color.Red;
            this.comp_name_err.Location = new System.Drawing.Point(27, 287);
            this.comp_name_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.comp_name_err.Name = "comp_name_err";
            this.comp_name_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comp_name_err.Size = new System.Drawing.Size(180, 20);
            this.comp_name_err.TabIndex = 33;
            this.comp_name_err.Text = "error";
            this.comp_name_err.Visible = false;
            // 
            // comp_back_icon
            // 
            this.comp_back_icon.BackColor = System.Drawing.Color.Transparent;
            this.comp_back_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("comp_back_icon.BackgroundImage")));
            this.comp_back_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.comp_back_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comp_back_icon.Location = new System.Drawing.Point(12, 22);
            this.comp_back_icon.Name = "comp_back_icon";
            this.comp_back_icon.Size = new System.Drawing.Size(43, 30);
            this.comp_back_icon.TabIndex = 34;
            this.comp_back_icon.TabStop = false;
            this.comp_back_icon.Click += new System.EventHandler(this.comp_back_icon_Click);
            // 
            // med_clear
            // 
            this.med_clear.BorderRadius = 5;
            this.med_clear.CheckedState.Parent = this.med_clear;
            this.med_clear.CustomImages.Parent = this.med_clear;
            this.med_clear.FillColor = System.Drawing.Color.DarkCyan;
            this.med_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_clear.ForeColor = System.Drawing.Color.White;
            this.med_clear.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.med_clear.HoverState.ForeColor = System.Drawing.Color.White;
            this.med_clear.HoverState.Parent = this.med_clear;
            this.med_clear.Location = new System.Drawing.Point(254, 509);
            this.med_clear.Name = "med_clear";
            this.med_clear.ShadowDecoration.Parent = this.med_clear;
            this.med_clear.Size = new System.Drawing.Size(105, 45);
            this.med_clear.TabIndex = 35;
            this.med_clear.Text = "CLEAR";
            this.med_clear.Click += new System.EventHandler(this.med_clear_Click);
            // 
            // CompanyDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CompanyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompanyDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.CompanyDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CompanyDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CompanyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CompanyDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CompanyDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CompanyDataGridView.EnableHeadersVisualStyles = false;
            this.CompanyDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.CompanyDataGridView.Location = new System.Drawing.Point(468, 12);
            this.CompanyDataGridView.Name = "CompanyDataGridView";
            this.CompanyDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CompanyDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CompanyDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.CompanyDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.CompanyDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.CompanyDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.CompanyDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.CompanyDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CompanyDataGridView.RowTemplate.Height = 35;
            this.CompanyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompanyDataGridView.Size = new System.Drawing.Size(711, 542);
            this.CompanyDataGridView.TabIndex = 29;
            this.CompanyDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.CompanyDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkCyan;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CompanyDataGridView.ThemeStyle.HeaderStyle.Height = 35;
            this.CompanyDataGridView.ThemeStyle.ReadOnly = false;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CompanyDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.CompanyDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.CompanyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompanyDataGridView_CellContentClick);
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1189, 566);
            this.Controls.Add(this.med_clear);
            this.Controls.Add(this.comp_back_icon);
            this.Controls.Add(this.comp_name_err);
            this.Controls.Add(this.comp_aadr_err);
            this.Controls.Add(this.comp_pn_err);
            this.Controls.Add(this.comp_id_err);
            this.Controls.Add(this.CompanyDataGridView);
            this.Controls.Add(this.backcompbtn);
            this.Controls.Add(this.deletcomppbtn);
            this.Controls.Add(this.updatecompbtn);
            this.Controls.Add(this.addcompbtn);
            this.Controls.Add(this.compaddrtb);
            this.Controls.Add(this.compphonetb);
            this.Controls.Add(this.compnametb);
            this.Controls.Add(this.companyidtb);
            this.Controls.Add(this.EmpLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Company_FormClosing);
            this.Load += new System.EventHandler(this.Company_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Company_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.comp_back_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel EmpLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox compaddrtb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox compphonetb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox compnametb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox companyidtb;
        private Guna.UI2.WinForms.Guna2Button backcompbtn;
        private Guna.UI2.WinForms.Guna2Button deletcomppbtn;
        private Guna.UI2.WinForms.Guna2Button updatecompbtn;
        private Guna.UI2.WinForms.Guna2Button addcompbtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel comp_id_err;
        private Guna.UI2.WinForms.Guna2HtmlLabel comp_pn_err;
        private Guna.UI2.WinForms.Guna2HtmlLabel comp_aadr_err;
        private Guna.UI2.WinForms.Guna2HtmlLabel comp_name_err;
        private System.Windows.Forms.PictureBox comp_back_icon;
        private Guna.UI2.WinForms.Guna2Button med_clear;
        private Guna.UI2.WinForms.Guna2DataGridView CompanyDataGridView;
    }
}