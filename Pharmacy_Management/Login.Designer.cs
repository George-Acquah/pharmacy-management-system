namespace Pharmacy_Management
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this._login_btn = new Guna.UI2.WinForms.Guna2Button();
            this.show_pass_timer = new System.Windows.Forms.Timer(this.components);
            this.forgot_pass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.show_hide_pass = new System.Windows.Forms.PictureBox();
            this.exit_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.show_hide_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.White;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Username.ForeColor = System.Drawing.Color.DarkCyan;
            this.Username.HintForeColor = System.Drawing.Color.DarkCyan;
            this.Username.HintText = "";
            this.Username.isPassword = false;
            this.Username.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.Username.LineIdleColor = System.Drawing.Color.Gray;
            this.Username.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.Username.LineThickness = 3;
            this.Username.Location = new System.Drawing.Point(50, 155);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(221, 34);
            this.Username.TabIndex = 1;
            this.Username.Text = "UserId";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username.OnValueChanged += new System.EventHandler(this.UserId_OnValueChanged);
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.DarkCyan;
            this.Password.HintForeColor = System.Drawing.Color.DarkCyan;
            this.Password.HintText = "";
            this.Password.isPassword = true;
            this.Password.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.Password.LineIdleColor = System.Drawing.Color.Gray;
            this.Password.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(50, 250);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(221, 34);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(91, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // _login_btn
            // 
            this._login_btn.BackColor = System.Drawing.Color.White;
            this._login_btn.BorderRadius = 10;
            this._login_btn.CheckedState.Parent = this._login_btn;
            this._login_btn.CustomImages.Parent = this._login_btn;
            this._login_btn.FillColor = System.Drawing.Color.DarkCyan;
            this._login_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this._login_btn.ForeColor = System.Drawing.Color.White;
            this._login_btn.HoverState.Parent = this._login_btn;
            this._login_btn.Location = new System.Drawing.Point(68, 332);
            this._login_btn.Name = "_login_btn";
            this._login_btn.ShadowDecoration.Parent = this._login_btn;
            this._login_btn.Size = new System.Drawing.Size(180, 45);
            this._login_btn.TabIndex = 6;
            this._login_btn.Text = "LOGIN";
            this._login_btn.Click += new System.EventHandler(this._login_btn_Click);
            // 
            // show_pass_timer
            // 
            this.show_pass_timer.Tick += new System.EventHandler(this.show_pass_timer_Tick);
            // 
            // forgot_pass
            // 
            this.forgot_pass.AutoSize = true;
            this.forgot_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_pass.ForeColor = System.Drawing.Color.Red;
            this.forgot_pass.Location = new System.Drawing.Point(96, 395);
            this.forgot_pass.Name = "forgot_pass";
            this.forgot_pass.Size = new System.Drawing.Size(132, 16);
            this.forgot_pass.TabIndex = 16;
            this.forgot_pass.Text = "Forgot Password?";
            this.forgot_pass.Click += new System.EventHandler(this.forgot_pass_Click);
            // 
            // show_hide_pass
            // 
            this.show_hide_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_hide_pass.BackgroundImage")));
            this.show_hide_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.show_hide_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_hide_pass.Location = new System.Drawing.Point(234, 257);
            this.show_hide_pass.Name = "show_hide_pass";
            this.show_hide_pass.Size = new System.Drawing.Size(27, 22);
            this.show_hide_pass.TabIndex = 7;
            this.show_hide_pass.TabStop = false;
            this.show_hide_pass.Click += new System.EventHandler(this.show_hide_pass_Click);
            // 
            // exit_icon
            // 
            this.exit_icon.BackColor = System.Drawing.Color.Transparent;
            this.exit_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_icon.BackgroundImage")));
            this.exit_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_icon.Location = new System.Drawing.Point(282, 3);
            this.exit_icon.Name = "exit_icon";
            this.exit_icon.Size = new System.Drawing.Size(38, 36);
            this.exit_icon.TabIndex = 18;
            this.exit_icon.TabStop = false;
            this.exit_icon.Click += new System.EventHandler(this.exit_icon_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 430);
            this.Controls.Add(this.exit_icon);
            this.Controls.Add(this.forgot_pass);
            this.Controls.Add(this.show_hide_pass);
            this.Controls.Add(this._login_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_hide_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuMaterialTextbox Username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button _login_btn;
        private System.Windows.Forms.PictureBox show_hide_pass;
        private System.Windows.Forms.Timer show_pass_timer;
        private Bunifu.Framework.UI.BunifuCustomLabel forgot_pass;
        private System.Windows.Forms.PictureBox exit_icon;
    }
}