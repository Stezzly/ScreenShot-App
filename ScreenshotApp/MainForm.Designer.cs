namespace ScreenshotApp
{
    partial class MainForm // Changed from Form1 to MainForm for consistency
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Location = new System.Drawing.Point(50, 50);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(150, 50);
            this.btnScreenshot.TabIndex = 0;
            this.btnScreenshot.Text = "Take Screenshot";
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);

            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(50, 20);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(136, 17);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Click to take a screenshot";

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.btnScreenshot);
            this.Name = "MainForm";
            this.Text = "Screenshot App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnScreenshot; // Fixed button variable name
        private System.Windows.Forms.Label labelInfo; // Added labelInfo variable declaration
    }
}
