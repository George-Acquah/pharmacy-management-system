using Bunifu.Framework.UI;
using Pharmacy_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pharmacy_Management
{
    public partial class ShortcutsControl : UserControl
    {
        public ShortcutsControl()
        {
            InitializeComponent();
            
        }

        private Point defLoc(int x_helper, int y_helper)
        {
            Point p = new Point(x_helper, y_helper);
            return p;
        }

        Point point = new Point(0, 20);
        int defLeftlblX = 19;
        int defLeftlblY = 88;
        int defLeftX = 99;
        int defLeftY = 79;

        private void AddShortcutLabel(string name, string value,int lblx, int lbly, int txtx, int txty)
        {
            Label labelShortcut = new Label();
            BunifuMaterialTextbox textbox = new BunifuMaterialTextbox();

            labelShortcut.Text = name;
            labelShortcut.AutoSize = true; 
            labelShortcut.Font = new Font("Segoe UI Emoji", 12F);
            labelShortcut.ForeColor = Color.DarkCyan; 
            labelShortcut.Size = new Size(81, 26);
            labelShortcut.TabIndex = 35;
            labelShortcut.Location = defLoc(lblx, lbly);

            textbox.Text = value;
            textbox.AutoSize = true; // Set AutoSize to true
            textbox.Font = new Font("Century Gothic", 9.75F);
            textbox.ForeColor = Color.DarkCyan;
            textbox.Margin = new Padding(2);
            textbox.BorderStyle = BorderStyle.Fixed3D;
            textbox.BackColor = Color.White;
            textbox.Width = 200;
            textbox.Location = defLoc(txtx, txty);
            textbox.Cursor = Cursors.IBeam;
            textbox.Enabled = false;
            textbox.HintForeColor = Color.Brown;
            textbox.HintText = "";
            textbox.isPassword = false;
            textbox.LineFocusedColor = Color.Brown;
            textbox.LineIdleColor = Color.Gray;
            textbox.LineMouseHoverColor = Color.BlueViolet;
            textbox.LineThickness = 3;
            textbox.Size = new Size(200, 34);
            textbox.TabIndex = 2;
            textbox.TextAlign = HorizontalAlignment.Left;

            // Add click event handler to handle click action
            labelShortcut.Click += (sender, e) =>
            {
                // Implement the click action here
                // For example, you can open a form or execute a function
                MessageBox.Show("You clicked on " + name);
            };

            this.Controls.Add(labelShortcut);
            this.Controls.Add(textbox);
        }


        private void ShortcutsControl_Load(object sender, EventArgs e)
        {
            
            AddShortcutLabel("Add", "Ctrl + A, Ctrl + plus",defLeftlblX, defLeftlblY, defLeftX, defLeftY);
            AddShortcutLabel("Delete", "Ctrl + Delete", defLeftlblX, defLeftlblY + 50, defLeftX, defLeftY + 50);
            AddShortcutLabel("Update", "Ctrl + U", defLeftlblX, defLeftlblY + 100, defLeftX, defLeftY + 100);
            AddShortcutLabel("Clear", "Ctrl + Shift + Delete", defLeftlblX, defLeftlblY + 150, defLeftX, defLeftY + 150);
            AddShortcutLabel("Home", "Ctrl + H, Ctrl + Home", defLeftlblX, defLeftlblY + 200, defLeftX, defLeftY + 200);
            AddShortcutLabel("Back", "Ctrl + Backspace", defLeftlblX + 360, defLeftlblY, defLeftX + 360, defLeftY );
            AddShortcutLabel("Print", "Ctrl + V, Ctrl + PrtSc", defLeftlblX + 360, defLeftlblY + 50, defLeftX + 360, defLeftY + 50);
            AddShortcutLabel("Exit App", "Ctrl + End", defLeftlblX + 360, defLeftlblY + 100, defLeftX + 360, defLeftY + 100);
            AddShortcutLabel("Cancel", "Ctrl + Z", defLeftlblX + 360 , defLeftlblY + 150, defLeftX + 360 , defLeftY + 150);
            AddShortcutLabel("Shortcut 2", "Value 2", defLeftlblX + 360, defLeftlblY + 200, defLeftX + 360, defLeftY + 200);
            //AddShortcutLabel("Shortcut 3", "Value 3");
        }
    }
}
