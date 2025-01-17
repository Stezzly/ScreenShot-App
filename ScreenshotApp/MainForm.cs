using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ScreenshotApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Set initial transparency
            this.Opacity = 0.8; // 80% opacity
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            // Make the form completely transparent for the screenshot
            this.Opacity = 0; // 0% opacity (completely transparent)

            // Allow the form to update before taking the screenshot

            // Take the screenshot
            TakeScreenshot();

            // Restore the form's opacity
            this.Opacity = 0.8; // 80% opacity
        }

        private void TakeScreenshot()
        {
            // Create a bitmap of the same size as the form
            Rectangle bounds = new Rectangle(this.Location, this.Size);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Take the screenshot of the area behind the form
                    g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
                }

                // Define the folder path (bin\Debug or bin\Release)
                string folderPath = AppDomain.CurrentDomain.BaseDirectory; // Gets the path of the bin directory

                // Create a valid filename
                string fileName = $"screenshot_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                fileName = fileName.Replace("/", "-").Replace(":", "-"); // Replace any invalid characters

                // Save the screenshot to a file in the bin folder
                bitmap.Save(System.IO.Path.Combine(folderPath, fileName), ImageFormat.Png);

                // Notify the user
                MessageBox.Show($"Screenshot saved: {fileName}\nLocation: {folderPath}", "Screenshot Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
