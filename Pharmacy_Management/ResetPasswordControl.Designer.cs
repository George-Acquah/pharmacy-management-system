namespace Pharmacy_Management
{
    partial class ResetPasswordControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordControl));
            this.conf_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.new_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.old_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reset_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.view_old_pass = new System.Windows.Forms.PictureBox();
            this.view_new_pass = new System.Windows.Forms.PictureBox();
            this.view_conf_pass = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.view_old_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_new_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_conf_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // conf_pass
            // 
            this.conf_pass.BackColor = System.Drawing.Color.White;
            this.conf_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.conf_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.conf_pass.ForeColor = System.Drawing.Color.DarkCyan;
            this.conf_pass.HintForeColor = System.Drawing.Color.Brown;
            this.conf_pass.HintText = "";
            this.conf_pass.isPassword = true;
            this.conf_pass.LineFocusedColor = System.Drawing.Color.Brown;
            this.conf_pass.LineIdleColor = System.Drawing.Color.Gray;
            this.conf_pass.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.conf_pass.LineThickness = 3;
            this.conf_pass.Location = new System.Drawing.Point(35, 281);
            this.conf_pass.Margin = new System.Windows.Forms.Padding(4);
            this.conf_pass.Name = "conf_pass";
            this.conf_pass.Size = new System.Drawing.Size(221, 34);
            this.conf_pass.TabIndex = 8;
            this.conf_pass.Text = "Confirm Password";
            this.conf_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.conf_pass.Enter += new System.EventHandler(this.conf_pass_Enter);
            this.conf_pass.Leave += new System.EventHandler(this.conf_pass_Leave);
            // 
            // new_pass
            // 
            this.new_pass.BackColor = System.Drawing.Color.White;
            this.new_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.new_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.new_pass.ForeColor = System.Drawing.Color.DarkCyan;
            this.new_pass.HintForeColor = System.Drawing.Color.Brown;
            this.new_pass.HintText = "";
            this.new_pass.isPassword = true;
            this.new_pass.LineFocusedColor = System.Drawing.Color.Brown;
            this.new_pass.LineIdleColor = System.Drawing.Color.Gray;
            this.new_pass.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.new_pass.LineThickness = 3;
            this.new_pass.Location = new System.Drawing.Point(35, 193);
            this.new_pass.Margin = new System.Windows.Forms.Padding(4);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(221, 34);
            this.new_pass.TabIndex = 10;
            this.new_pass.Text = "New Password";
            this.new_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.new_pass.Enter += new System.EventHandler(this.new_pass_Enter);
            this.new_pass.Leave += new System.EventHandler(this.new_pass_Leave);
            // 
            // old_pass
            // 
            this.old_pass.BackColor = System.Drawing.Color.White;
            this.old_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.old_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.old_pass.ForeColor = System.Drawing.Color.DarkCyan;
            this.old_pass.HintForeColor = System.Drawing.Color.Brown;
            this.old_pass.HintText = "";
            this.old_pass.isPassword = true;
            this.old_pass.LineFocusedColor = System.Drawing.Color.Brown;
            this.old_pass.LineIdleColor = System.Drawing.Color.Gray;
            this.old_pass.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.old_pass.LineThickness = 3;
            this.old_pass.Location = new System.Drawing.Point(35, 108);
            this.old_pass.Margin = new System.Windows.Forms.Padding(4);
            this.old_pass.Name = "old_pass";
            this.old_pass.Size = new System.Drawing.Size(221, 34);
            this.old_pass.TabIndex = 12;
            this.old_pass.Text = "Old Password";
            this.old_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.old_pass.Enter += new System.EventHandler(this.old_pass_Enter);
            this.old_pass.Leave += new System.EventHandler(this.old_pass_Leave);
            // 
            // reset_btn
            // 
            this.reset_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reset_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.reset_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reset_btn.BorderRadius = 7;
            this.reset_btn.ButtonText = "RESET PASSWORD";
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_btn.DisabledColor = System.Drawing.Color.Gray;
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
            this.reset_btn.IconZoom = 90D;
            this.reset_btn.IsTab = false;
            this.reset_btn.Location = new System.Drawing.Point(47, 385);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Normalcolor = System.Drawing.Color.DarkCyan;
            this.reset_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.reset_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.reset_btn.selected = false;
            this.reset_btn.Size = new System.Drawing.Size(198, 48);
            this.reset_btn.TabIndex = 14;
            this.reset_btn.Text = "RESET PASSWORD";
            this.reset_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_btn.Textcolor = System.Drawing.Color.White;
            this.reset_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // view_old_pass
            // 
            this.view_old_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_old_pass.BackgroundImage")));
            this.view_old_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_old_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_old_pass.Location = new System.Drawing.Point(229, 108);
            this.view_old_pass.Name = "view_old_pass";
            this.view_old_pass.Size = new System.Drawing.Size(27, 22);
            this.view_old_pass.TabIndex = 13;
            this.view_old_pass.TabStop = false;
            this.view_old_pass.Click += new System.EventHandler(this.view_old_pass_Click);
            // 
            // view_new_pass
            // 
            this.view_new_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_new_pass.BackgroundImage")));
            this.view_new_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_new_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_new_pass.Location = new System.Drawing.Point(229, 193);
            this.view_new_pass.Name = "view_new_pass";
            this.view_new_pass.Size = new System.Drawing.Size(27, 22);
            this.view_new_pass.TabIndex = 11;
            this.view_new_pass.TabStop = false;
            this.view_new_pass.Click += new System.EventHandler(this.view_new_pass_Click);
            // 
            // view_conf_pass
            // 
            this.view_conf_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view_conf_pass.BackgroundImage")));
            this.view_conf_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_conf_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_conf_pass.Location = new System.Drawing.Point(229, 281);
            this.view_conf_pass.Name = "view_conf_pass";
            this.view_conf_pass.Size = new System.Drawing.Size(27, 22);
            this.view_conf_pass.TabIndex = 9;
            this.view_conf_pass.TabStop = false;
            this.view_conf_pass.Click += new System.EventHandler(this.view_conf_pass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fill this form";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(362, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(378, 480);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // ResetPasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.view_old_pass);
            this.Controls.Add(this.old_pass);
            this.Controls.Add(this.view_new_pass);
            this.Controls.Add(this.new_pass);
            this.Controls.Add(this.view_conf_pass);
            this.Controls.Add(this.conf_pass);
            this.Name = "ResetPasswordControl";
            this.Size = new System.Drawing.Size(740, 480);
            this.Load += new System.EventHandler(this.ResetPasswordControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_old_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_new_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_conf_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox view_conf_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox conf_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox new_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox old_pass;
        private System.Windows.Forms.PictureBox view_old_pass;
        private System.Windows.Forms.PictureBox view_new_pass;
        private Bunifu.Framework.UI.BunifuFlatButton reset_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
