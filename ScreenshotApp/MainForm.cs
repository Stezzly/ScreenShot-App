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
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            // Call the method to capture a screenshot
            CaptureScreenshot();
        }

        private void CaptureScreenshot()
        {
            // Define the area to capture
            Rectangle bounds = new Rectangle(this.Location, this.Size);
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Capture the screenshot
                    g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size);
                }

                // Save the screenshot to the project directory
                string filePath = $"screenshot_{DateTime.Now:yyyyMMdd_HHmmss}.png";
                bitmap.Save(filePath, ImageFormat.Png);

                // Display a message box confirming the screenshot was taken
                MessageBox.Show($"Screenshot saved as: {filePath}", "Screenshot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
