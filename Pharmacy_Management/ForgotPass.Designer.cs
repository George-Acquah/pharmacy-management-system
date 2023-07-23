namespace Pharmacy_Management
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            this.id_name_err = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.id_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.options_lbl = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.emp_name_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reset_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exit_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // id_name_err
            // 
            this.id_name_err.BackColor = System.Drawing.Color.Transparent;
            this.id_name_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_name_err.ForeColor = System.Drawing.Color.Red;
            this.id_name_err.Location = new System.Drawing.Point(89, 131);
            this.id_name_err.MinimumSize = new System.Drawing.Size(180, 0);
            this.id_name_err.Name = "id_name_err";
            this.id_name_err.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.id_name_err.Size = new System.Drawing.Size(180, 20);
            this.id_name_err.TabIndex = 33;
            this.id_name_err.Text = "error";
            this.id_name_err.Visible = false;
            // 
            // id_text
            // 
            this.id_text.BackColor = System.Drawing.Color.White;
            this.id_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.id_text.ForeColor = System.Drawing.Color.Black;
            this.id_text.HintForeColor = System.Drawing.Color.Empty;
            this.id_text.HintText = "";
            this.id_text.isPassword = false;
            this.id_text.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.id_text.LineIdleColor = System.Drawing.Color.Gray;
            this.id_text.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.id_text.LineThickness = 3;
            this.id_text.Location = new System.Drawing.Point(91, 91);
            this.id_text.Margin = new System.Windows.Forms.Padding(4);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(178, 33);
            this.id_text.TabIndex = 32;
            this.id_text.Text = "Emp Id";
            this.id_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.id_text.Enter += new System.EventHandler(this.id_name_text_Enter);
            this.id_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.id_name_text_KeyDown);
            this.id_text.Leave += new System.EventHandler(this.id_name_text_Leave);
            // 
            // options_lbl
            // 
            this.options_lbl.AutoSize = true;
            this.options_lbl.Font = new System.Drawing.Font("Segoe UI Emoji", 27.75F, System.Drawing.FontStyle.Bold);
            this.options_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.options_lbl.Location = new System.Drawing.Point(35, 22);
            this.options_lbl.Name = "options_lbl";
            this.options_lbl.Size = new System.Drawing.Size(313, 49);
            this.options_lbl.TabIndex = 35;
            this.options_lbl.Text = "Forgot Password";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(89, 229);
            this.guna2HtmlLabel1.MinimumSize = new System.Drawing.Size(180, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(180, 20);
            this.guna2HtmlLabel1.TabIndex = 37;
            this.guna2HtmlLabel1.Text = "error";
            this.guna2HtmlLabel1.Visible = false;
            // 
            // emp_name_text
            // 
            this.emp_name_text.BackColor = System.Drawing.Color.White;
            this.emp_name_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emp_name_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emp_name_text.ForeColor = System.Drawing.Color.Black;
            this.emp_name_text.HintForeColor = System.Drawing.Color.Empty;
            this.emp_name_text.HintText = "";
            this.emp_name_text.isPassword = false;
            this.emp_name_text.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.emp_name_text.LineIdleColor = System.Drawing.Color.Gray;
            this.emp_name_text.LineMouseHoverColor = System.Drawing.Color.Cyan;
            this.emp_name_text.LineThickness = 3;
            this.emp_name_text.Location = new System.Drawing.Point(91, 189);
            this.emp_name_text.Margin = new System.Windows.Forms.Padding(4);
            this.emp_name_text.Name = "emp_name_text";
            this.emp_name_text.Size = new System.Drawing.Size(178, 33);
            this.emp_name_text.TabIndex = 36;
            this.emp_name_text.Text = "Emp Name";
            this.emp_name_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emp_name_text.Enter += new System.EventHandler(this.emp_name_text_Enter);
            this.emp_name_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emp_name_text_KeyDown);
            this.emp_name_text.Leave += new System.EventHandler(this.emp_name_text_Leave);
            // 
            // reset_btn
            // 
            this.reset_btn.Activecolor = System.Drawing.Color.Green;
            this.reset_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.reset_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reset_btn.BorderRadius = 7;
            this.reset_btn.ButtonText = "Request For Reset";
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_btn.DisabledColor = System.Drawing.Color.Brown;
            this.reset_btn.ForeColor = System.Drawing.Color.White;
            this.reset_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.reset_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("reset_btn.Iconimage")));
            this.reset_btn.Iconimage_right = null;
            this.reset_btn.Iconimage_right_Selected = null;
            this.reset_btn.Iconimage_Selected = null;
            this.reset_btn.IconMarginLeft = 0;
            this.reset_btn.IconMarginRight = 0;
            this.reset_btn.IconRightVisible = true;
            this.reset_btn.IconRightZoom = 0D;
            this.reset_btn.IconVisible = true;
            this.reset_btn.IconZoom = 50D;
            this.reset_btn.IsTab = false;
            this.reset_btn.Location = new System.Drawing.Point(82, 287);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(2);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Normalcolor = System.Drawing.Color.DarkCyan;
            this.reset_btn.OnHovercolor = System.Drawing.Color.Green;
            this.reset_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.reset_btn.selected = false;
            this.reset_btn.Size = new System.Drawing.Size(187, 48);
            this.reset_btn.TabIndex = 34;
            this.reset_btn.Text = "Request For Reset";
            this.reset_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reset_btn.Textcolor = System.Drawing.Color.White;
            this.reset_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // exit_icon
            // 
            this.exit_icon.BackColor = System.Drawing.Color.Transparent;
            this.exit_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_icon.BackgroundImage")));
            this.exit_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_icon.Location = new System.Drawing.Point(345, 1);
            this.exit_icon.Name = "exit_icon";
            this.exit_icon.Size = new System.Drawing.Size(38, 36);
            this.exit_icon.TabIndex = 38;
            this.exit_icon.TabStop = false;
            this.exit_icon.Click += new System.EventHandler(this.exit_icon_Click);
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 346);
            this.Controls.Add(this.exit_icon);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.emp_name_text);
            this.Controls.Add(this.options_lbl);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.id_name_err);
            this.Controls.Add(this.id_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPass";
            this.Load += new System.EventHandler(this.ForgotPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel id_name_err;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id_text;
        private Bunifu.Framework.UI.BunifuFlatButton reset_btn;
        private System.Windows.Forms.Label options_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emp_name_text;
        private System.Windows.Forms.PictureBox exit_icon;
    }
}