namespace JohnBryce
{
    partial class AboutForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.closeButton.Location = new System.Drawing.Point(243, 278);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(89, 35);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "סגור";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.aboutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aboutLabel.Location = new System.Drawing.Point(19, 170);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aboutLabel.Size = new System.Drawing.Size(543, 62);
            this.aboutLabel.TabIndex = 1;
            this.aboutLabel.Text = "קוראים לי ארן.\r\nאין לי מושג בתכנות אבל איך שהוא הצלחתי לעשות שומר מסך פסיכדלי. \r\n" +
    "תהנו לכם!";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(574, 403);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.aboutLabel);
            this.Name = "AboutForm";
            this.Text = "About Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Button closeButton;
    }
}
