namespace Pharmacy_Management
{
    partial class RolesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RolesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.role_back_icon = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.home_btn = new Guna.UI2.WinForms.Guna2Button();
            this.del_role_btn = new Guna.UI2.WinForms.Guna2Button();
            this.update_role_btn = new Guna.UI2.WinForms.Guna2Button();
            this.add_role_btn = new Guna.UI2.WinForms.Guna2Button();
            this.role_name_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.role_id_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rolenamelbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.roleidlbl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.RoleDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.role_clear = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.role_back_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // role_back_icon
            // 
            this.role_back_icon.BackColor = System.Drawing.Color.Transparent;
            this.role_back_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("role_back_icon.BackgroundImage")));
            this.role_back_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.role_back_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.role_back_icon.Location = new System.Drawing.Point(9, 20);
            this.role_back_icon.Name = "role_back_icon";
            this.role_back_icon.Size = new System.Drawing.Size(43, 30);
            this.role_back_icon.TabIndex = 37;
            this.role_back_icon.TabStop = false;
            this.role_back_icon.Click += new System.EventHandler(this.back_icon_Click_1);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(58, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(197, 44);
            this.guna2HtmlLabel1.TabIndex = 36;
            this.guna2HtmlLabel1.Text = "Roles Page";
            // 
            // home_btn
            // 
            this.home_btn.BorderRadius = 5;
            this.home_btn.CheckedState.Parent = this.home_btn;
            this.home_btn.CustomImages.Parent = this.home_btn;
            this.home_btn.FillColor = System.Drawing.Color.DarkCyan;
            this.home_btn.Font = new System.Drawing.Font("Algerian", 11.25F);
            this.home_btn.ForeColor = System.Drawing.Color.White;
            this.home_btn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.home_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.home_btn.HoverState.Parent = this.home_btn;
            this.home_btn.Location = new System.Drawing.Point(75, 393);
            this.home_btn.Name = "home_btn";
            this.home_btn.ShadowDecoration.Parent = this.home_btn;
            this.home_btn.Size = new System.Drawing.Size(87, 45);
            this.home_btn.TabIndex = 41;
            this.home_btn.Text = "HOME";
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // del_role_btn
            // 
            this.del_role_btn.BorderRadius = 5;
            this.del_role_btn.CheckedState.Parent = this.del_role_btn;
            this.del_role_btn.CustomImages.Parent = this.del_role_btn;
            this.del_role_btn.FillColor = System.Drawing.Color.DarkCyan;
            this.del_role_btn.Font = new System.Drawing.Font("Algerian", 11.25F);
            this.del_role_btn.ForeColor = System.Drawing.Color.White;
            this.del_role_btn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.del_role_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.del_role_btn.HoverState.Parent = this.del_role_btn;
            this.del_role_btn.Location = new System.Drawing.Point(241, 320);
            this.del_role_btn.Name = "del_role_btn";
            this.del_role_btn.ShadowDecoration.Parent = this.del_role_btn;
            this.del_role_btn.Size = new System.Drawing.Size(87, 45);
            this.del_role_btn.TabIndex = 40;
            this.del_role_btn.Text = "DELETE";
            this.del_role_btn.Click += new System.EventHandler(this.del_role_btn_Click);
            // 
            // update_role_btn
            // 
            this.update_role_btn.BorderRadius = 5;
            this.update_role_btn.CheckedState.Parent = this.update_role_btn;
            this.update_role_btn.CustomImages.Parent = this.update_role_btn;
            this.update_role_btn.FillColor = System.Drawing.Color.DarkCyan;
            this.update_role_btn.Font = new System.Drawing.Font("Algerian", 11.25F);
            this.update_role_btn.ForeColor = System.Drawing.Color.White;
            this.update_role_btn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.update_role_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.update_role_btn.HoverState.Parent = this.update_role_btn;
            this.update_role_btn.Location = new System.Drawing.Point(127, 320);
            this.update_role_btn.Name = "update_role_btn";
            this.update_role_btn.ShadowDecoration.Parent = this.update_role_btn;
            this.update_role_btn.Size = new System.Drawing.Size(87, 45);
            this.update_role_btn.TabIndex = 39;
            this.update_role_btn.Text = "UPDATE";
            this.update_role_btn.Click += new System.EventHandler(this.update_role_btn_Click);
            // 
            // add_role_btn
            // 
            this.add_role_btn.BorderRadius = 5;
            this.add_role_btn.CheckedState.Parent = this.add_role_btn;
            this.add_role_btn.CustomImages.Parent = this.add_role_btn;
            this.add_role_btn.FillColor = System.Drawing.Color.DarkCyan;
            this.add_role_btn.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_role_btn.ForeColor = System.Drawing.Color.White;
            this.add_role_btn.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.add_role_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.add_role_btn.HoverState.Parent = this.add_role_btn;
            this.add_role_btn.Location = new System.Drawing.Point(12, 320);
            this.add_role_btn.Name = "add_role_btn";
            this.add_role_btn.ShadowDecoration.Parent = this.add_role_btn;
            this.add_role_btn.Size = new System.Drawing.Size(85, 45);
            this.add_role_btn.TabIndex = 38;
            this.add_role_btn.Text = "ADD";
            this.add_role_btn.Click += new System.EventHandler(this.add_role_btn_Click);
            // 
            // role_name_err
            // 
            this.role_name_err.BackColor = System.Drawing.Color.Transparent;
            this.role_name_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_name_err.ForeColor = System.Drawing.Color.Red;
            this.role_name_err.Location = new System.Drawing.Point(58, 232);
            this.role_name_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.role_name_err.Name = "role_name_err";
            this.role_name_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.role_name_err.Size = new System.Drawing.Size(180, 20);
            this.role_name_err.TabIndex = 45;
            this.role_name_err.Text = "error";
            this.role_name_err.Visible = false;
            // 
            // role_id_err
            // 
            this.role_id_err.BackColor = System.Drawing.Color.Transparent;
            this.role_id_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_id_err.ForeColor = System.Drawing.Color.Red;
            this.role_id_err.Location = new System.Drawing.Point(58, 123);
            this.role_id_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.role_id_err.Name = "role_id_err";
            this.role_id_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.role_id_err.Size = new System.Drawing.Size(180, 20);
            this.role_id_err.TabIndex = 44;
            this.role_id_err.Text = "error";
            this.role_id_err.Visible = false;
            // 
            // rolenamelbl
            // 
            this.rolenamelbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rolenamelbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rolenamelbl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rolenamelbl.ForeColor = System.Drawing.Color.Black;
            this.rolenamelbl.HintForeColor = System.Drawing.Color.Empty;
            this.rolenamelbl.HintText = "";
            this.rolenamelbl.isPassword = false;
            this.rolenamelbl.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.rolenamelbl.LineIdleColor = System.Drawing.Color.Gray;
            this.rolenamelbl.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.rolenamelbl.LineThickness = 3;
            this.rolenamelbl.Location = new System.Drawing.Point(58, 192);
            this.rolenamelbl.Margin = new System.Windows.Forms.Padding(4);
            this.rolenamelbl.Name = "rolenamelbl";
            this.rolenamelbl.Size = new System.Drawing.Size(205, 33);
            this.rolenamelbl.TabIndex = 43;
            this.rolenamelbl.Text = "Role Name";
            this.rolenamelbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rolenamelbl.Enter += new System.EventHandler(this.rolenamelbl_Enter);
            this.rolenamelbl.Leave += new System.EventHandler(this.rolenamelbl_Leave);
            // 
            // roleidlbl
            // 
            this.roleidlbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roleidlbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roleidlbl.Enabled = false;
            this.roleidlbl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.roleidlbl.ForeColor = System.Drawing.Color.Black;
            this.roleidlbl.HintForeColor = System.Drawing.Color.Empty;
            this.roleidlbl.HintText = "";
            this.roleidlbl.isPassword = false;
            this.roleidlbl.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.roleidlbl.LineIdleColor = System.Drawing.Color.Gray;
            this.roleidlbl.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.roleidlbl.LineThickness = 3;
            this.roleidlbl.Location = new System.Drawing.Point(58, 83);
            this.roleidlbl.Margin = new System.Windows.Forms.Padding(4);
            this.roleidlbl.Name = "roleidlbl";
            this.roleidlbl.Size = new System.Drawing.Size(207, 33);
            this.roleidlbl.TabIndex = 42;
            this.roleidlbl.Text = "Role Id";
            this.roleidlbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // RoleDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.RoleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RoleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoleDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.RoleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoleDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RoleDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoleDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.RoleDataGridView.EnableHeadersVisualStyles = false;
            this.RoleDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoleDataGridView.Location = new System.Drawing.Point(346, 12);
            this.RoleDataGridView.Name = "RoleDataGridView";
            this.RoleDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RoleDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.RoleDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.RoleDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.RoleDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkCyan;
            this.RoleDataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.RoleDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
            this.RoleDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.RoleDataGridView.RowTemplate.Height = 35;
            this.RoleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoleDataGridView.Size = new System.Drawing.Size(448, 426);
            this.RoleDataGridView.TabIndex = 46;
            this.RoleDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.RoleDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoleDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoleDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoleDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoleDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoleDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoleDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoleDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkCyan;
            this.RoleDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoleDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoleDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoleDataGridView.ThemeStyle.HeaderStyle.Height = 35;
            this.RoleDataGridView.ThemeStyle.ReadOnly = false;
            this.RoleDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RoleDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoleDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RoleDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoleDataGridView.ThemeStyle.RowsStyle.Height = 35;
            this.RoleDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoleDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoleDataGridView_CellContentClick);
            // 
            // role_clear
            // 
            this.role_clear.BorderRadius = 5;
            this.role_clear.CheckedState.Parent = this.role_clear;
            this.role_clear.CustomImages.Parent = this.role_clear;
            this.role_clear.FillColor = System.Drawing.Color.DarkCyan;
            this.role_clear.Font = new System.Drawing.Font("Algerian", 11.25F);
            this.role_clear.ForeColor = System.Drawing.Color.White;
            this.role_clear.HoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.role_clear.HoverState.ForeColor = System.Drawing.Color.White;
            this.role_clear.HoverState.Parent = this.role_clear;
            this.role_clear.Location = new System.Drawing.Point(192, 393);
            this.role_clear.Name = "role_clear";
            this.role_clear.ShadowDecoration.Parent = this.role_clear;
            this.role_clear.Size = new System.Drawing.Size(87, 45);
            this.role_clear.TabIndex = 47;
            this.role_clear.Text = "CLEAR";
            this.role_clear.Click += new System.EventHandler(this.role_clear_Click);
            // 
            // RolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.role_clear);
            this.Controls.Add(this.RoleDataGridView);
            this.Controls.Add(this.role_name_err);
            this.Controls.Add(this.role_id_err);
            this.Controls.Add(this.rolenamelbl);
            this.Controls.Add(this.roleidlbl);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.del_role_btn);
            this.Controls.Add(this.update_role_btn);
            this.Controls.Add(this.add_role_btn);
            this.Controls.Add(this.role_back_icon);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RolesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RolesForm";
            this.Load += new System.EventHandler(this.RolesForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RolesForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.role_back_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox role_back_icon;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button home_btn;
        private Guna.UI2.WinForms.Guna2Button del_role_btn;
        private Guna.UI2.WinForms.Guna2Button update_role_btn;
        private Guna.UI2.WinForms.Guna2Button add_role_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel role_name_err;
        private Guna.UI2.WinForms.Guna2HtmlLabel role_id_err;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rolenamelbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox roleidlbl;
        private Guna.UI2.WinForms.Guna2DataGridView RoleDataGridView;
        private Guna.UI2.WinForms.Guna2Button role_clear;
    }
}