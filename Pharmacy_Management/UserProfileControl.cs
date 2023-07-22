using Pharmacy_Management.utils.contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management
{
    public partial class UserProfileControl : UserControl
    {
        private const string UserProfilePicturePath = "UserProfilePicture.jpg";
        public UserProfileControl()
        {
            InitializeComponent();

            // Set the panel to have no border
            userProfilePanel.BorderStyle = BorderStyle.None;

            // Create a circular GraphicsPath
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, userProfilePanel.Width - 1, userProfilePanel.Height - 1);

            // Set the panel region to the circular path
            userProfilePanel.Region = new Region(path);



            LoadUserProfilePicture();
            SetDefaultProfilePicture();
            loadUserDetails();
            MakeCircularPictureBox();
        }

        public Image ProfilePicture
        {
            get { return picBoxProfile.Image; }
            set { picBoxProfile.Image = value; }
        }

        private void loadUserDetails()
        {
            string userId = MyAppContext.EmpID;
            string userName = MyAppContext.userName;
            string userRole = MyAppContext.UserRole;

            empid_lbl.Text = userId;
            empname_lbl.Text = userName;
            emprole_lbl.Text = userRole;
        }

        private void SetDefaultProfilePicture()
        {
            // Load the default profile picture from resources or file
            // Here, we assume you have "DefaultProfilePicture.jpg" in your resources
            ProfilePicture = Properties.Resources.DefaultMaleProfilePicture;
        }

        private void SaveUserProfilePicture(string filePath)
        {
            try
            {
                File.Copy(filePath, GetUserProfilePicturePath(), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the profile picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserProfilePicture()
        {
            string profilePicturePath = GetUserProfilePicturePath();
            if (File.Exists(profilePicturePath))
            {
                try
                {
                    // Load the image
                    Image originalImage = Image.FromFile(profilePicturePath);

                    // Create a new Bitmap with the same size as the PictureBox
                    Bitmap circularImage = new Bitmap(picBoxProfile.Width, picBoxProfile.Height);

                    // Draw the original image on the circular image with a circular region
                    using (Graphics g = Graphics.FromImage(circularImage))
                    {
                        GraphicsPath path = new GraphicsPath();
                        path.AddEllipse(0, 0, circularImage.Width, circularImage.Height);
                        g.SetClip(path);
                        g.DrawImage(originalImage, 0, 0, circularImage.Width, circularImage.Height);
                    }

                    // Set the circular image as the PictureBox image
                    picBoxProfile.Image = circularImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading the profile picture: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private string GetUserProfilePicturePath()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userProfileFolder = Path.Combine(appDataFolder, "PharmacyManagement");
            Directory.CreateDirectory(userProfileFolder);
            return Path.Combine(userProfileFolder, UserProfilePicturePath);
        }

        private void UserProfileControl_Load(object sender, EventArgs e)
        {

        }

        private void MakeCircularPictureBox()
        {
            // Create a circular GraphicsPath
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picBoxProfile.Width - 1, picBoxProfile.Height - 1);

            // Set the PictureBox region to the circular path
            picBoxProfile.Region = new Region(path);

            // Adjust the size and position of the PictureBox to fit the circular region
            picBoxProfile.Size = new Size(picBoxProfile.Width - 1, picBoxProfile.Height - 1);
            picBoxProfile.Location = new Point(1, 1);
        }


        private void upload_pic_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(openFileDialog.FileName).ToLower();
                    if (fileExtension == ".jpg" || fileExtension == ".png" || fileExtension == ".bmp")
                    {
                        try
                        {
                            ProfilePicture = Image.FromFile(openFileDialog.FileName);
                            SaveUserProfilePicture(openFileDialog.FileName);
                        }
                        catch (OutOfMemoryException)
                        {
                            MessageBox.Show("Invalid image format. Please select a valid image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid file format. Please select a valid image file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
