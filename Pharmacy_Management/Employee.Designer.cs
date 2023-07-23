namespace Pharmacy_Management
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmpLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.empnametb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empagetb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empsaltb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empidtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empphonetb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.backempbtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteempbtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateempbtn = new Guna.UI2.WinForms.Guna2Button();
            this.addempbtn = new Guna.UI2.WinForms.Guna2Button();
            this.emppasstb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.med_sal_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.med_age_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.med_pass_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.med_phn_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.emp_id_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.emp_back_icon = new System.Windows.Forms.PictureBox();
            this.view_roles_icon = new System.Windows.Forms.PictureBox();
            this.sh_roles_tt = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rolescb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.emp_clear = new Guna.UI2.WinForms.Guna2Button();
            this.EmployeeDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.emp_back_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_roles_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpLabel
            // 
            this.EmpLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.EmpLabel.Location = new System.Drawing.Point(139, 30);
            this.EmpLabel.Name = "EmpLabel";
            this.EmpLabel.Size = new System.Drawing.Size(188, 44);
            this.EmpLabel.TabIndex = 1;
            this.EmpLabel.Text = "Employees";
            // 
            // empnametb
            // 
            this.empnametb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empnametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empnametb.ForeColor = System.Drawing.Color.Black;
            this.empnametb.HintForeColor = System.Drawing.Color.Empty;
            this.empnametb.HintText = "";
            this.empnametb.isPassword = false;
            this.empnametb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.empnametb.LineIdleColor = System.Drawing.Color.Gray;
            this.empnametb.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.empnametb.LineThickness = 3;
            this.empnametb.Location = new System.Drawing.Point(33, 219);
            this.empnametb.Margin = new System.Windows.Forms.Padding(4);
            this.empnametb.Name = "empnametb";
            this.empnametb.Size = new System.Drawing.Size(178, 33);
            this.empnametb.TabIndex = 12;
            this.empnametb.Text = "Employee Name";
            this.empnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empnametb.OnValueChanged += new System.EventHandler(this.bptb_OnValueChanged);
            this.empnametb.Enter += new System.EventHandler(this.empnametb_Enter);
            this.empnametb.Leave += new System.EventHandler(this.empnametb_Leave);
            // 
            // empagetb
            // 
            this.empagetb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empagetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empagetb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empagetb.ForeColor = System.Drawing.Color.Black;
            this.empagetb.HintForeColor = System.Drawing.Color.Brown;
            this.empagetb.HintText = "";
            this.empagetb.isPassword = false;
            this.empagetb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.empagetb.LineIdleColor = System.Drawing.Color.Gray;
            this.empagetb.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.empagetb.LineThickness = 3;
            this.empagetb.Location = new System.Drawing.Point(272, 268);
            this.empagetb.Margin = new System.Windows.Forms.Padding(4);
            this.empagetb.Name = "empagetb";
            this.empagetb.Size = new System.Drawing.Size(178, 33);
            this.empagetb.TabIndex = 11;
            this.empagetb.Text = "Employee Age";
            this.empagetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empagetb.OnValueChanged += new System.EventHandler(this.sptb_OnValueChanged);
            this.empagetb.Enter += new System.EventHandler(this.empagetb_Enter);
            this.empagetb.Leave += new System.EventHandler(this.empagetb_Leave);
            // 
            // empsaltb
            // 
            this.empsaltb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empsaltb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empsaltb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empsaltb.ForeColor = System.Drawing.Color.Black;
            this.empsaltb.HintForeColor = System.Drawing.Color.Empty;
            this.empsaltb.HintText = "";
            this.empsaltb.isPassword = false;
            this.empsaltb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.empsaltb.LineIdleColor = System.Drawing.Color.Gray;
            this.empsaltb.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.empsaltb.LineThickness = 3;
            this.empsaltb.Location = new System.Drawing.Point(272, 110);
            this.empsaltb.Margin = new System.Windows.Forms.Padding(4);
            this.empsaltb.Name = "empsaltb";
            this.empsaltb.Size = new System.Drawing.Size(178, 33);
            this.empsaltb.TabIndex = 10;
            this.empsaltb.Text = "Salary";
            this.empsaltb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empsaltb.OnValueChanged += new System.EventHandler(this.empsaltb_OnValueChanged);
            this.empsaltb.Enter += new System.EventHandler(this.empsaltb_Enter);
            this.empsaltb.Leave += new System.EventHandler(this.empsaltb_Leave);
            // 
            // empidtb
            // 
            this.empidtb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empidtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empidtb.Enabled = false;
            this.empidtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empidtb.ForeColor = System.Drawing.Color.Black;
            this.empidtb.HintForeColor = System.Drawing.Color.Empty;
            this.empidtb.HintText = "";
            this.empidtb.isPassword = false;
            this.empidtb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.empidtb.LineIdleColor = System.Drawing.Color.Gray;
            this.empidtb.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.empidtb.LineThickness = 3;
            this.empidtb.Location = new System.Drawing.Point(33, 110);
            this.empidtb.Margin = new System.Windows.Forms.Padding(4);
            this.empidtb.Name = "empidtb";
            this.empidtb.Size = new System.Drawing.Size(178, 33);
            this.empidtb.TabIndex = 9;
            this.empidtb.Text = "Employee Id";
            this.empidtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empidtb.OnValueChanged += new System.EventHandler(this.empidtb_OnValueChanged);
            this.empidtb.Enter += new System.EventHandler(this.empidtb_Enter);
            this.empidtb.Leave += new System.EventHandler(this.empidtb_Leave);
            // 
            // empphonetb
            // 
            this.empphonetb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.empphonetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empphonetb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empphonetb.ForeColor = System.Drawing.Color.Black;
            this.empphonetb.HintForeColor = System.Drawing.Color.Empty;
            this.empphonetb.HintText = "";
            this.empphonetb.isPassword = false;
            this.empphonetb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.empphonetb.LineIdleColor = System.Drawing.Color.Gray;
            this.empphonetb.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.empphonetb.LineThickness = 3;
            this.empphonetb.Location = new System.Drawing.Point(272, 193);
            this.empphonetb.Margin = new System.Windows.Forms.Padding(4);
            this.empphonetb.Name = "empphonetb";
            this.empphonetb.Size = new System.Drawing.Size(178, 33);
            this.empphonetb.TabIndex = 14;
            this.empphonetb.Text = "Phone Number";
            this.empphonetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empphonetb.OnValueChanged += new System.EventHandler(this.empphonetb_OnValueChanged);
            this.empphonetb.Enter += new System.EventHandler(this.empphonetb_Enter);
            this.empphonetb.Leave += new System.EventHandler(this.empphonetb_Leave);
            // 
            // backempbtn
            // 
            this.backempbtn.BorderRadius = 5;
            this.backempbtn.CheckedState.Parent = this.backempbtn;
            this.backempbtn.CustomImages.Parent = this.backempbtn;
            this.backempbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.backempbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backempbtn.ForeColor = System.Drawing.Color.White;
            this.backempbtn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.backempbtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.backempbtn.HoverState.Parent = this.backempbtn;
            this.backempbtn.Location = new System.Drawing.Point(94, 509);
            this.backempbtn.Name = "backempbtn";
            this.backempbtn.ShadowDecoration.Parent = this.backempbtn;
            this.backempbtn.Size = new System.Drawing.Size(105, 45);
            this.backempbtn.TabIndex = 18;
            this.backempbtn.Text = "HOME";
            this.backempbtn.Click += new System.EventHandler(this.backempbtn_Click);
            // 
            // deleteempbtn
            // 
            this.deleteempbtn.BorderRadius = 5;
            this.deleteempbtn.CheckedState.Parent = this.deleteempbtn;
            this.deleteempbtn.CustomImages.Parent = this.deleteempbtn;
            this.deleteempbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.deleteempbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteempbtn.ForeColor = System.Drawing.Color.White;
            this.deleteempbtn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.deleteempbtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.deleteempbtn.HoverState.Parent = this.deleteempbtn;
            this.deleteempbtn.Location = new System.Drawing.Point(345, 439);
            this.deleteempbtn.Name = "deleteempbtn";
            this.deleteempbtn.ShadowDecoration.Parent = this.deleteempbtn;
            this.deleteempbtn.Size = new System.Drawing.Size(105, 45);
            this.deleteempbtn.TabIndex = 17;
            this.deleteempbtn.Text = "DELETE";
            this.deleteempbtn.Click += new System.EventHandler(this.deleteempbtn_Click);
            // 
            // updateempbtn
            // 
            this.updateempbtn.BorderRadius = 5;
            this.updateempbtn.CheckedState.Parent = this.updateempbtn;
            this.updateempbtn.CustomImages.Parent = this.updateempbtn;
            this.updateempbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.updateempbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateempbtn.ForeColor = System.Drawing.Color.White;
            this.updateempbtn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.updateempbtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.updateempbtn.HoverState.Parent = this.updateempbtn;
            this.updateempbtn.Location = new System.Drawing.Point(182, 439);
            this.updateempbtn.Name = "updateempbtn";
            this.updateempbtn.ShadowDecoration.Parent = this.updateempbtn;
            this.updateempbtn.Size = new System.Drawing.Size(105, 45);
            this.updateempbtn.TabIndex = 16;
            this.updateempbtn.Text = "UPDATE";
            this.updateempbtn.Click += new System.EventHandler(this.updateempbtn_Click);
            // 
            // addempbtn
            // 
            this.addempbtn.BorderRadius = 5;
            this.addempbtn.CheckedState.Parent = this.addempbtn;
            this.addempbtn.CustomImages.Parent = this.addempbtn;
            this.addempbtn.FillColor = System.Drawing.Color.DarkCyan;
            this.addempbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addempbtn.ForeColor = System.Drawing.Color.White;
            this.addempbtn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.addempbtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.addempbtn.HoverState.Parent = this.addempbtn;
            this.addempbtn.Location = new System.Drawing.Point(21, 439);
            this.addempbtn.Name = "addempbtn";
            this.addempbtn.ShadowDecoration.Parent = this.addempbtn;
            this.addempbtn.Size = new System.Drawing.Size(103, 45);
            this.addempbtn.TabIndex = 15;
            this.addempbtn.Text = "ADD";
            this.addempbtn.Click += new System.EventHandler(this.addempbtn_Click);
            // 
            // emppasstb
            // 
            this.emppasstb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.emppasstb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emppasstb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emppasstb.ForeColor = System.Drawing.Color.Black;
            this.emppasstb.HintForeColor = System.Drawing.Color.Empty;
            this.emppasstb.HintText = "";
            this.emppasstb.isPassword = false;
            this.emppasstb.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.emppasstb.LineIdleColor = System.Drawing.Color.Gray;
            this.emppasstb.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.emppasstb.LineThickness = 3;
            this.emppasstb.Location = new System.Drawing.Point(272, 345);
            this.emppasstb.Margin = new System.Windows.Forms.Padding(4);
            this.emppasstb.Name = "emppasstb";
            this.emppasstb.Size = new System.Drawing.Size(178, 33);
            this.emppasstb.TabIndex = 20;
            this.emppasstb.Text = "Emp Password";
            this.emppasstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emppasstb.Enter += new System.EventHandler(this.emppasstb_Enter);
            this.emppasstb.Leave += new System.EventHandler(this.emppasstb_Leave);
            // 
            // med_sal_err
            // 
            this.med_sal_err.BackColor = System.Drawing.Color.Transparent;
            this.med_sal_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_sal_err.ForeColor = System.Drawing.Color.Red;
            this.med_sal_err.Location = new System.Drawing.Point(272, 150);
            this.med_sal_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.med_sal_err.Name = "med_sal_err";
            this.med_sal_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.med_sal_err.Size = new System.Drawing.Size(180, 20);
            this.med_sal_err.TabIndex = 21;
            this.med_sal_err.Text = "error";
            this.med_sal_err.Visible = false;
            // 
            // med_age_err
            // 
            this.med_age_err.BackColor = System.Drawing.Color.Transparent;
            this.med_age_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_age_err.ForeColor = System.Drawing.Color.Red;
            this.med_age_err.Location = new System.Drawing.Point(272, 308);
            this.med_age_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.med_age_err.Name = "med_age_err";
            this.med_age_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.med_age_err.Size = new System.Drawing.Size(180, 20);
            this.med_age_err.TabIndex = 22;
            this.med_age_err.Text = "error";
            this.med_age_err.Visible = false;
            // 
            // med_pass_err
            // 
            this.med_pass_err.BackColor = System.Drawing.Color.Transparent;
            this.med_pass_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_pass_err.ForeColor = System.Drawing.Color.Red;
            this.med_pass_err.Location = new System.Drawing.Point(272, 385);
            this.med_pass_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.med_pass_err.Name = "med_pass_err";
            this.med_pass_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.med_pass_err.Size = new System.Drawing.Size(180, 20);
            this.med_pass_err.TabIndex = 23;
            this.med_pass_err.Text = "error";
            this.med_pass_err.Visible = false;
            // 
            // med_phn_err
            // 
            this.med_phn_err.BackColor = System.Drawing.Color.Transparent;
            this.med_phn_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med_phn_err.ForeColor = System.Drawing.Color.Red;
            this.med_phn_err.Location = new System.Drawing.Point(274, 241);
            this.med_phn_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.med_phn_err.Name = "med_phn_err";
            this.med_phn_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.med_phn_err.Size = new System.Drawing.Size(180, 20);
            this.med_phn_err.TabIndex = 24;
            this.med_phn_err.Text = "error";
            this.med_phn_err.Visible = false;
            // 
            // emp_id_err
            // 
            this.emp_id_err.BackColor = System.Drawing.Color.Transparent;
            this.emp_id_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_id_err.ForeColor = System.Drawing.Color.Red;
            this.emp_id_err.Location = new System.Drawing.Point(33, 150);
            this.emp_id_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.emp_id_err.Name = "emp_id_err";
            this.emp_id_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emp_id_err.Size = new System.Drawing.Size(180, 20);
            this.emp_id_err.TabIndex = 25;
            this.emp_id_err.Text = "error";
            this.emp_id_err.Visible = false;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(33, 259);
            this.guna2HtmlLabel5.MinimumSize = new System.Drawing.Size(180, 0);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(180, 20);
            this.guna2HtmlLabel5.TabIndex = 26;
            this.guna2HtmlLabel5.Text = "error";
            this.guna2HtmlLabel5.Visible = false;
            // 
            // emp_back_icon
            // 
            this.emp_back_icon.BackColor = System.Drawing.Color.Transparent;
            this.emp_back_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emp_back_icon.BackgroundImage")));
            this.emp_back_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emp_back_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp_back_icon.Location = new System.Drawing.Point(12, 12);
            this.emp_back_icon.Name = "emp_back_icon";
            this.emp_back_icon.Size = new System.Drawing.Size(43, 30);
            this.emp_back_icon.TabIndex = 27;
            this.emp_back_icon.TabStop = false;
            this.emp_back_icon.Click += new System.EventHandler(this.emp_back_icon_Click);
            // 
            // view_roles_icon
            // 
            this.view_roles_icon.BackColor = System.Drawing.Color.Transparent;
            this.view_roles_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_roles_icon.BackgroundImage")));
            this.view_roles_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_roles_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_roles_icon.Location = new System.Drawing.Point(205, 329);
            this.view_roles_icon.Name = "view_roles_icon";
            this.view_roles_icon.Size = new System.Drawing.Size(43, 36);
            this.view_roles_icon.TabIndex = 39;
            this.view_roles_icon.TabStop = false;
            this.view_roles_icon.Click += new System.EventHandler(this.view_roles_icon_Click);
            this.view_roles_icon.MouseEnter += new System.EventHandler(this.view_roles_icon_MouseEnter);
            this.view_roles_icon.MouseLeave += new System.EventHandler(this.view_roles_icon_MouseLeave);
            // 
            // sh_roles_tt
            // 
            this.sh_roles_tt.BackColor = System.Drawing.Color.Transparent;
            this.sh_roles_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sh_roles_tt.ForeColor = System.Drawing.Color.Brown;
            this.sh_roles_tt.Location = new System.Drawing.Point(169, 308);
            this.sh_roles_tt.Name = "sh_roles_tt";
            this.sh_roles_tt.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sh_roles_tt.Size = new System.Drawing.Size(97, 20);
            this.sh_roles_tt.TabIndex = 38;
            this.sh_roles_tt.Text = " View Roles ";
            this.sh_roles_tt.Visible = false;
            // 
            // rolescb
            // 
            this.rolescb.BackColor = System.Drawing.Color.Transparent;
            this.rolescb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rolescb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolescb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rolescb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rolescb.FocusedState.Parent = this.rolescb;
            this.rolescb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rolescb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.rolescb.HoverState.Parent = this.rolescb;
            this.rolescb.ItemHeight = 30;
            this.rolescb.ItemsAppearance.Parent = this.rolescb;
            this.rolescb.Location = new System.Drawing.Point(21, 329);
            this.rolescb.Name = "rolescb";
            this.rolescb.ShadowDecoration.Parent = this.rolescb;
            this.rolescb.Size = new System.Drawing.Size(178, 36);
            this.rolescb.TabIndex = 37;
            // 
            // emp_clear
            // 
            this.emp_clear.BorderRadius = 5;
            this.emp_clear.CheckedState.Parent = this.emp_clear;
            this.emp_clear.CustomImages.Parent = this.emp_clear;
            this.emp_clear.FillColor = System.Drawing.Color.DarkCyan;
            this.emp_clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emp_clear.ForeColor = System.Drawing.Color.White;
            this.emp_clear.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.emp_clear.HoverState.ForeColor = System.Drawing.Color.White;
            this.emp_clear.HoverState.Parent = this.emp_clear;
            this.emp_clear.Location = new System.Drawing.Point(272, 509);
            this.emp_clear.Name = "emp_clear";
            this.emp_clear.ShadowDecoration.Parent = this.emp_clear;
            this.emp_clear.Size = new System.Drawing.Size(105, 45);
            this.emp_clear.TabIndex = 40;
            this.emp_clear.Text = "CLEAR";
            this.emp_clear.Click += new System.EventHandler(this.emp_clear_Click);
            // 
            // EmployeeDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeDataGridView.EnableHeadersVisualStyles = false;
            this.EmployeeDataGridView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(488, 12);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeeDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.EmployeeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.EmployeeDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.EmployeeDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.EmployeeDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.EmployeeDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.RowTemplate.Height = 35;
            this.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(711, 542);
            this.EmployeeDataGridView.TabIndex = 41;
            this.EmployeeDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.EmployeeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkCyan;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeDataGridView.ThemeStyle.HeaderStyle.Height = 35;
            this.EmployeeDataGridView.ThemeStyle.ReadOnly = false;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.EmployeeDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmployeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellContentClick);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1211, 566);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Controls.Add(this.emp_clear);
            this.Controls.Add(this.view_roles_icon);
            this.Controls.Add(this.sh_roles_tt);
            this.Controls.Add(this.rolescb);
            this.Controls.Add(this.emp_back_icon);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.emp_id_err);
            this.Controls.Add(this.med_phn_err);
            this.Controls.Add(this.med_pass_err);
            this.Controls.Add(this.med_age_err);
            this.Controls.Add(this.med_sal_err);
            this.Controls.Add(this.emppasstb);
            this.Controls.Add(this.backempbtn);
            this.Controls.Add(this.deleteempbtn);
            this.Controls.Add(this.updateempbtn);
            this.Controls.Add(this.addempbtn);
            this.Controls.Add(this.empphonetb);
            this.Controls.Add(this.empnametb);
            this.Controls.Add(this.empagetb);
            this.Controls.Add(this.empsaltb);
            this.Controls.Add(this.empidtb);
            this.Controls.Add(this.EmpLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Employee_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.emp_back_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_roles_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel EmpLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empnametb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empagetb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empsaltb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empidtb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empphonetb;
        private Guna.UI2.WinForms.Guna2Button backempbtn;
        private Guna.UI2.WinForms.Guna2Button deleteempbtn;
        private Guna.UI2.WinForms.Guna2Button updateempbtn;
        private Guna.UI2.WinForms.Guna2Button addempbtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emppasstb;
        private Guna.UI2.WinForms.Guna2HtmlLabel med_sal_err;
        private Guna.UI2.WinForms.Guna2HtmlLabel med_age_err;
        private Guna.UI2.WinForms.Guna2HtmlLabel med_pass_err;
        private Guna.UI2.WinForms.Guna2HtmlLabel med_phn_err;
        private Guna.UI2.WinForms.Guna2HtmlLabel emp_id_err;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.PictureBox emp_back_icon;
        private System.Windows.Forms.PictureBox view_roles_icon;
        private Guna.UI2.WinForms.Guna2HtmlLabel sh_roles_tt;
        private Guna.UI2.WinForms.Guna2ComboBox rolescb;
        private Guna.UI2.WinForms.Guna2Button emp_clear;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeDataGridView;
    }
}