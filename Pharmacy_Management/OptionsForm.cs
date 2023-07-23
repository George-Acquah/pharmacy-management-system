using Pharmacy_Management.utils.contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management
{
    public partial class OptionsForm : Form
    {
        private UserProfileControl userProfileControl;
        private ShortcutsControl shortcutsControl;
        private ResetPasswordControl resetPasswordControl;
        private AdminResetPassword adminResetPassword;

        public OptionsForm()
        {
            InitializeComponent();

            userProfileControl = new UserProfileControl();
            userProfileControl.Dock = DockStyle.Fill; // Set the control to fill the options_panel
            options_panel.Controls.Add(userProfileControl);

            shortcutsControl = new ShortcutsControl();
            shortcutsControl.Dock = DockStyle.Fill; // Set the control to fill the options_panel
            options_panel.Controls.Add(shortcutsControl);

            resetPasswordControl = new ResetPasswordControl();
            resetPasswordControl.Dock = DockStyle.Fill; // Set the control to fill the options_panel
            options_panel.Controls.Add(resetPasswordControl);

            adminResetPassword = new AdminResetPassword();
            adminResetPassword.Dock = DockStyle.Fill; // Set the control to fill the options_panel
            options_panel.Controls.Add(adminResetPassword);

            //string userRole = MyAppContext.UserRole;

            //if (userRole != "Admin")
            //{
            //    pass_req_icon.Visible = false;
            //    pass_req_lbl.Visible = false;
            //}

            userProfileControl.Visible = false; // Set the visibility to false
            shortcutsControl.Visible = false; // Set the visibility to false
            resetPasswordControl.Visible = false; // Set the visibility to false
            adminResetPassword.Visible = false; // Set the visibility to false
        }


        private void ShowUserProfile()
        {
            HideAllUserControls();
            if (userProfileControl == null)
            {
                userProfileControl = new UserProfileControl();
                userProfileControl.Dock = DockStyle.Fill;
                options_panel.Controls.Add(userProfileControl);
            }
            userProfileControl.Visible = true;

            // Bring options_panel to front
            options_panel.BringToFront();
        }

        private void ShowShortcutsControl()
        {
            HideAllUserControls();

            // Clear the controls in the options_panel
            //shortcutsControl.Controls.Clear();

            if (shortcutsControl == null)
            {
                shortcutsControl = new ShortcutsControl();
                shortcutsControl.Dock = DockStyle.Fill;
                options_panel.Controls.Add(shortcutsControl);
                // Create and add Shortcut Labels here
                
                // You can add more shortcuts as needed
                
            }
            shortcutsControl.Visible = true;

            // Bring options_panel to front
            options_panel.BringToFront();
        }

        private void ShowResetPasswordControl()
        {
            HideAllUserControls();
            if (resetPasswordControl == null)
            {
                resetPasswordControl = new ResetPasswordControl();
                resetPasswordControl.Dock = DockStyle.Fill;
                options_panel.Controls.Add(resetPasswordControl);
            }
            resetPasswordControl.Visible = true;

            // Bring options_panel to front
            options_panel.BringToFront();
        }

        private void ShowAdminResetPasswordControl()
        {
            HideAllUserControls();
            if (adminResetPassword == null)
            {
                adminResetPassword = new AdminResetPassword();
                adminResetPassword.Dock = DockStyle.Fill;
                options_panel.Controls.Add(adminResetPassword);
            }
            adminResetPassword.Visible = true;

            // Bring options_panel to front
            options_panel.BringToFront();
        }
        private void HideAllUserControls()
        {
            if (userProfileControl != null)
                userProfileControl.Visible = false;

            if (shortcutsControl != null)
                shortcutsControl.Visible = false;

            if (resetPasswordControl != null)
                resetPasswordControl.Visible = false;

            if (shortcutsControl != null)
                shortcutsControl.Visible = false;

            if (adminResetPassword != null)
                adminResetPassword.Visible = false;

            // Hide other user controls here
        }



        private Point defLoc(int helper)
        {
            Point p = new Point(109, helper);
            return p;
        }
        Point point = new Point(30, 0);
        private void view_pr_icon_MouseEnter(object sender, EventArgs e)
        {
            Point loc = defLoc(101);
            Point newPoint = new Point(loc.X + point.X, loc.Y + point.Y);
            view_pr_lbl.Location = newPoint;
            view_pr_lbl.ForeColor = Color.Brown;
        }

        private void view_pr_icon_MouseLeave(object sender, EventArgs e)
        {
            view_pr_lbl.Location = defLoc(101);
            view_pr_lbl.ForeColor = Color.DarkCyan;
        }

        private void view_sc_icon_MouseEnter(object sender, EventArgs e)
        { 
            Point loc = defLoc(150);
            Point newPoint = new Point(loc.X + point.X, loc.Y + point.Y);
            options_sc_lbl.Location = newPoint;
            options_sc_lbl.ForeColor = Color.Brown;
        }

        private void view_sc_icon_MouseLeave(object sender, EventArgs e)
        {
            options_sc_lbl.Location = defLoc(150);
            options_sc_lbl.ForeColor = Color.DarkCyan;
        }

        private void reset_icon_MouseEnter(object sender, EventArgs e)
        {
            Point loc = defLoc(195);
            Point newPoint = new Point(loc.X + point.X, loc.Y + point.Y);
            options_reset_lbl.Location = newPoint;
            options_reset_lbl.ForeColor = Color.Brown;
        }

        private void reset_icon_MouseLeave(object sender, EventArgs e)
        {
            options_reset_lbl.Location = defLoc(195);
            options_reset_lbl.ForeColor = Color.DarkCyan;
        }

        private void help_icon_MouseEnter(object sender, EventArgs e)
        {
            Point loc = defLoc(241);
            Point newPoint = new Point(loc.X + point.X, loc.Y + point.Y);
            options_help_lbl.Location = newPoint;
            options_help_lbl.ForeColor = Color.Brown;
        }

        private void help_icon_MouseLeave(object sender, EventArgs e)
        {
            options_help_lbl.Location = defLoc(241);
            options_help_lbl.ForeColor = Color.DarkCyan;
        }

        private void about_us_icon_MouseEnter(object sender, EventArgs e)
        {
            Point loc = defLoc(286);
            Point newPoint = new Point(loc.X + point.X, loc.Y + point.Y);
            options_about_lbl.Location = newPoint;
            options_about_lbl.ForeColor = Color.Brown;
        }

        private void about_us_icon_MouseLeave(object sender, EventArgs e)
        {
            options_about_lbl.Location = defLoc(286);
            options_about_lbl.ForeColor = Color.DarkCyan;
        }

        private void options_back_icon_Click(object sender, EventArgs e)
        {
            FormManager.GoBack();
            this.Hide();
        }

        private void view_pr_icon_Click(object sender, EventArgs e)
        {
            ShowUserProfile();
        }

        private void reset_icon_Click(object sender, EventArgs e)
        {
            ShowResetPasswordControl();
        }

        private void view_sc_icon_Click(object sender, EventArgs e)
        {
            ShowShortcutsControl();
        }


        private void help_icon_Click(object sender, EventArgs e)
        {

        }

        private void about_us_icon_Click(object sender, EventArgs e)
        {

        }

        private void opt_home_icon_Click(object sender, EventArgs e)
        {
            FormManager.NavigateTo("HomeForm");
            this.Hide();
        }




        private void OptionsForm_Load(object sender, EventArgs e)
        {
            FormManager.RegisterForm("OptionsForm", this);
            FormManager.RegisterForm("HomeForm", new HomeForm());
            FormManager.RegisterForm("Login", new Login());
        }

        private void OptionsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Back)
            {
                options_back_icon_Click(sender, e);
            }
            if (e.Control && (e.KeyCode == Keys.Home || e.KeyCode == Keys.H))
            {
                opt_home_icon_Click(sender, e);
            }
        }

        private void pass_req_icon_Click(object sender, EventArgs e)
        {
            ShowAdminResetPasswordControl();
        }
    }
}
