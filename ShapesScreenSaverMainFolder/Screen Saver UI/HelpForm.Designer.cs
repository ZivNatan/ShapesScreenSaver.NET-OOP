namespace JohnBryce
{
    partial class HelpForm
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
            this.helpLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.helpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpLabel.Location = new System.Drawing.Point(19, 170);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helpLabel.Size = new System.Drawing.Size(536, 62);
            this.helpLabel.TabIndex = 0;
            this.helpLabel.Text = "זהו שומר מסך המייצר צורות בצורה רנדומלית.\r\nבאפשרותך לשנות את צבע רקע המסך ע\"י לחי" +
    "צה על \"שינוי צבע הרקע\".\r\nבמידה ונתקלת בבעיה מיוחדת - התקשר ל-100.";
            this.helpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.closeButton.Location = new System.Drawing.Point(243, 265);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(89, 35);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "סגור";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(574, 403);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.helpLabel);
            this.Name = "HelpForm";
            this.Text = "Help Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Button closeButton;
    }
}
