namespace Pharmacy_Management
{
    partial class MedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MedicineGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mednametb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.qtytb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sptb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bptb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ExpireDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.companycb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.med_name_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sh_comp_tt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.med_sp_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.med_bp_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.med_back_icon = new System.Windows.Forms.PictureBox();
            this.view_comp_icon = new System.Windows.Forms.PictureBox();
            this.med_clear = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_back_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_comp_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(61, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(257, 44);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Medicine Stock";
            // 
            // MedicineGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MedicineGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicineGridView.BackgroundColor = System.Drawing.Color.White;
            this.MedicineGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicineGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MedicineGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MedicineGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MedicineGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MedicineGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MedicineGridView.EnableHeadersVisualStyles = false;
            this.MedicineGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MedicineGridView.Location = new System.Drawing.Point(488, 12);
            this.MedicineGridView.Name = "MedicineGridView";
            this.MedicineGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MedicineGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MedicineGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MedicineGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.MedicineGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.MedicineGridView.RowTemplate.Height = 35;
            this.MedicineGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineGridView.Size = new System.Drawing.Size(674, 542);
            this.MedicineGridView.TabIndex = 1;
            this.MedicineGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.MedicineGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MedicineGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.MedicineGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MedicineGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MedicineGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MedicineGridView.ThemeStyle.HeaderStyle.Height = 35;
            this.MedicineGridView.ThemeStyle.ReadOnly = false;
            this.MedicineGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MedicineGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.MedicineGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MedicineGridView.ThemeStyle.RowsStyle.Height = 35;
            this.MedicineGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.MedicineGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.MedicineGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // mednametb
            // 
            this.mednametb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mednametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mednametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mednametb.ForeColor = System.Drawing.Color.Black;
            this.mednametb.HintForeColor = System.Drawing.Color.Empty;
            this.mednametb.HintText = "";
            this.mednametb.isPassword = false;
            this.mednametb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.mednametb.LineIdleColor = System.Drawing.Color.Gray;
            this.mednametb.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.mednametb.LineThickness = 3;
            this.mednametb.Location = new System.Drawing.Point(13, 83);
            this.mednametb.Margin = new System.Windows.Forms.Padding(4);
            this.mednametb.Name = "mednametb";
            this.mednametb.Size = new System.Drawing.Size(178, 33);
            this.mednametb.TabIndex = 2;
            this.mednametb.Text = "Medicine Name";
            this.mednametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mednametb.Enter += new System.EventHandler(this.mednametb_Enter);
            this.mednametb.Leave += new System.EventHandler(this.mednametb_Leave);
            // 
            // qtytb
            // 
            this.qtytb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.qtytb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qtytb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.qtytb.ForeColor = System.Drawing.Color.Black;
            this.qtytb.HintForeColor = System.Drawing.Color.Empty;
            this.qtytb.HintText = "";
            this.qtytb.isPassword = false;
            this.qtytb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.qtytb.LineIdleColor = System.Drawing.Color.Gray;
            this.qtytb.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.qtytb.LineThickness = 3;
            this.qtytb.Location = new System.Drawing.Point(296, 282);
            this.qtytb.Margin = new System.Windows.Forms.Padding(4);
            this.qtytb.Name = "qtytb";
            this.qtytb.Size = new System.Drawing.Size(165, 33);
            this.qtytb.TabIndex = 3;
            this.qtytb.Text = "Quantity";
            this.qtytb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.qtytb.Enter += new System.EventHandler(this.qtytb_Enter);
            this.qtytb.Leave += new System.EventHandler(this.qtytb_Leave);
            // 
            // sptb
            // 
            this.sptb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sptb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sptb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sptb.ForeColor = System.Drawing.Color.Black;
            this.sptb.HintForeColor = System.Drawing.Color.Brown;
            this.sptb.HintText = "";
            this.sptb.isPassword = false;
            this.sptb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.sptb.LineIdleColor = System.Drawing.Color.Gray;
            this.sptb.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.sptb.LineThickness = 3;
            this.sptb.Location = new System.Drawing.Point(296, 188);
            this.sptb.Margin = new System.Windows.Forms.Padding(4);
            this.sptb.Name = "sptb";
            this.sptb.Size = new System.Drawing.Size(165, 33);
            this.sptb.TabIndex = 4;
            this.sptb.Text = "Selling Price";
            this.sptb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sptb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            this.sptb.Enter += new System.EventHandler(this.sptb_Enter);
            this.sptb.Leave += new System.EventHandler(this.sptb_Leave);
            // 
            // bptb
            // 
            this.bptb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bptb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bptb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bptb.ForeColor = System.Drawing.Color.Black;
            this.bptb.HintForeColor = System.Drawing.Color.Empty;
            this.bptb.HintText = "";
            this.bptb.isPassword = false;
            this.bptb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.bptb.LineIdleColor = System.Drawing.Color.Gray;
            this.bptb.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.bptb.LineThickness = 3;
            this.bptb.Location = new System.Drawing.Point(296, 83);
            this.bptb.Margin = new System.Windows.Forms.Padding(4);
            this.bptb.Name = "bptb";
            this.bptb.Size = new System.Drawing.Size(165, 33);
            this.bptb.TabIndex = 6;
            this.bptb.Text = "Buying Price";
            this.bptb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bptb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            this.bptb.Enter += new System.EventHandler(this.bptb_Enter);
            this.bptb.Leave += new System.EventHandler(this.bptb_Leave);
            // 
            // ExpireDate
            // 
            this.ExpireDate.BackColor = System.Drawing.Color.Black;
            this.ExpireDate.CheckedState.Parent = this.ExpireDate;
            this.ExpireDate.FillColor = System.Drawing.Color.DarkCyan;
            this.ExpireDate.ForeColor = System.Drawing.Color.White;
            this.ExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ExpireDate.HoverState.Parent = this.ExpireDate;
            this.ExpireDate.Location = new System.Drawing.Point(12, 188);
            this.ExpireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExpireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.ShadowDecoration.Parent = this.ExpireDate;
            this.ExpireDate.Size = new System.Drawing.Size(233, 36);
            this.ExpireDate.TabIndex = 7;
            this.ExpireDate.Value = new System.DateTime(2023, 7, 5, 15, 20, 12, 962);
            // 
            // companycb
            // 
            this.companycb.BackColor = System.Drawing.Color.Transparent;
            this.companycb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.companycb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companycb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.companycb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.companycb.FocusedState.Parent = this.companycb;
            this.companycb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.companycb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.companycb.HoverState.Parent = this.companycb;
            this.companycb.ItemHeight = 30;
            this.companycb.ItemsAppearance.Parent = this.companycb;
            this.companycb.Location = new System.Drawing.Point(12, 282);
            this.companycb.Name = "companycb";
            this.companycb.ShadowDecoration.Parent = this.companycb;
            this.companycb.Size = new System.Drawing.Size(178, 36);
            this.companycb.TabIndex = 8;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.DarkCyan;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(13, 413);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(103, 45);
            this.guna2Button1.TabIndex = 9;
            this.guna2Button1.Text = "ADD";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.DarkCyan;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(178, 413);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(105, 45);
            this.guna2Button2.TabIndex = 10;
            this.guna2Button2.Text = "UPDATE";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.DarkCyan;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(356, 413);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(105, 45);
            this.guna2Button3.TabIndex = 11;
            this.guna2Button3.Text = "DELETE";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.DarkCyan;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.guna2Button4.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(99, 488);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(105, 45);
            this.guna2Button4.TabIndex = 12;
            this.guna2Button4.Text = "HOME";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // med_name_err
            // 
            this.med_name_err.BackColor = System.Drawing.Color.Transparent;
            this.med_name_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_name_err.ForeColor = System.Drawing.Color.Red;
            this.med_name_err.Location = new System.Drawing.Point(13, 123);
            this.med_name_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.med_name_err.Name = "med_name_err";
            this.med_name_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.med_name_err.Size = new System.Drawing.Size(180, 20);
            this.med_name_err.TabIndex = 31;
            this.med_name_err.Text = "error";
            this.med_name_err.Visible = false;
            // 
            // sh_comp_tt
            // 
            this.sh_comp_tt.BackColor = System.Drawing.Color.Transparent;
            this.sh_comp_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sh_comp_tt.ForeColor = System.Drawing.Color.DarkCyan;
            this.sh_comp_tt.Location = new System.Drawing.Point(154, 256);
            this.sh_comp_tt.Name = "sh_comp_tt";
            this.sh_comp_tt.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sh_comp_tt.Size = new System.Drawing.Size(138, 20);
            this.sh_comp_tt.TabIndex = 32;
            this.sh_comp_tt.Text = " View Companies ";
            this.sh_comp_tt.Visible = false;
            // 
            // med_sp_err
            // 
            this.med_sp_err.BackColor = System.Drawing.Color.Transparent;
            this.med_sp_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_sp_err.ForeColor = System.Drawing.Color.Red;
            this.med_sp_err.Location = new System.Drawing.Point(296, 228);
            this.med_sp_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.med_sp_err.Name = "med_sp_err";
            this.med_sp_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.med_sp_err.Size = new System.Drawing.Size(180, 20);
            this.med_sp_err.TabIndex = 33;
            this.med_sp_err.Text = "error";
            this.med_sp_err.Visible = false;
            // 
            // med_bp_err
            // 
            this.med_bp_err.BackColor = System.Drawing.Color.Transparent;
            this.med_bp_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_bp_err.ForeColor = System.Drawing.Color.Red;
            this.med_bp_err.Location = new System.Drawing.Point(296, 123);
            this.med_bp_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.med_bp_err.Name = "med_bp_err";
            this.med_bp_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.med_bp_err.Size = new System.Drawing.Size(180, 20);
            this.med_bp_err.TabIndex = 34;
            this.med_bp_err.Text = "error";
            this.med_bp_err.Visible = false;
            // 
            // med_back_icon
            // 
            this.med_back_icon.BackColor = System.Drawing.Color.Transparent;
            this.med_back_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("med_back_icon.BackgroundImage")));
            this.med_back_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.med_back_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.med_back_icon.Location = new System.Drawing.Point(12, 20);
            this.med_back_icon.Name = "med_back_icon";
            this.med_back_icon.Size = new System.Drawing.Size(43, 30);
            this.med_back_icon.TabIndex = 35;
            this.med_back_icon.TabStop = false;
            this.med_back_icon.Click += new System.EventHandler(this.med_back_icon_Click);
            // 
            // view_comp_icon
            // 
            this.view_comp_icon.BackColor = System.Drawing.Color.Transparent;
            this.view_comp_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_comp_icon.BackgroundImage")));
            this.view_comp_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_comp_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_comp_icon.Location = new System.Drawing.Point(202, 282);
            this.view_comp_icon.Name = "view_comp_icon";
            this.view_comp_icon.Size = new System.Drawing.Size(43, 36);
            this.view_comp_icon.TabIndex = 36;
            this.view_comp_icon.TabStop = false;
            this.view_comp_icon.Click += new System.EventHandler(this.view_comp_icon_Click);
            this.view_comp_icon.MouseEnter += new System.EventHandler(this.view_comp_icon_MouseEnter);
            this.view_comp_icon.MouseLeave += new System.EventHandler(this.view_comp_icon_MouseLeave);
            // 
            // med_clear
            // 
            this.med_clear.BorderRadius = 5;
            this.med_clear.CheckedState.Parent = this.med_clear;
            this.med_clear.CustomImages.Parent = this.med_clear;
            this.med_clear.FillColor = System.Drawing.Color.DarkCyan;
            this.med_clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.med_clear.ForeColor = System.Drawing.Color.White;
            this.med_clear.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.med_clear.HoverState.ForeColor = System.Drawing.Color.White;
            this.med_clear.HoverState.Parent = this.med_clear;
            this.med_clear.Location = new System.Drawing.Point(270, 488);
            this.med_clear.Name = "med_clear";
            this.med_clear.ShadowDecoration.Parent = this.med_clear;
            this.med_clear.Size = new System.Drawing.Size(105, 45);
            this.med_clear.TabIndex = 37;
            this.med_clear.Text = "CLEAR";
            this.med_clear.Click += new System.EventHandler(this.med_clear_Click);
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1174, 566);
            this.Controls.Add(this.med_clear);
            this.Controls.Add(this.view_comp_icon);
            this.Controls.Add(this.med_back_icon);
            this.Controls.Add(this.med_bp_err);
            this.Controls.Add(this.med_sp_err);
            this.Controls.Add(this.sh_comp_tt);
            this.Controls.Add(this.med_name_err);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.companycb);
            this.Controls.Add(this.ExpireDate);
            this.Controls.Add(this.bptb);
            this.Controls.Add(this.sptb);
            this.Controls.Add(this.qtytb);
            this.Controls.Add(this.mednametb);
            this.Controls.Add(this.MedicineGridView);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MedicineForm_FormClosing);
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MedicineForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.med_back_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_comp_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView MedicineGridView;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mednametb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox qtytb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sptb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bptb;
        private Guna.UI2.WinForms.Guna2DateTimePicker ExpireDate;
        private Guna.UI2.WinForms.Guna2ComboBox companycb;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2HtmlLabel med_name_err;
        private Guna.UI2.WinForms.Guna2HtmlLabel sh_comp_tt;
        private Guna.UI2.WinForms.Guna2HtmlLabel med_sp_err;
        private Guna.UI2.WinForms.Guna2HtmlLabel med_bp_err;
        private System.Windows.Forms.PictureBox med_back_icon;
        private System.Windows.Forms.PictureBox view_comp_icon;
        private Guna.UI2.WinForms.Guna2Button med_clear;
    }
}