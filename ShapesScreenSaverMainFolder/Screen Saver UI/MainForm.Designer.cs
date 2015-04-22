namespace JohnBryce
{
    partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.מאפייניםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.שנהאתצבעהרקעToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.יציאהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עזרהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הצגחלוןעזרהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.אודותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShapesTimer = new System.Windows.Forms.Timer(this.components);
            this.backGroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.מאפייניםToolStripMenuItem,
            this.עזרהToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainMenu.Size = new System.Drawing.Size(473, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // מאפייניםToolStripMenuItem
            // 
            this.מאפייניםToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.שנהאתצבעהרקעToolStripMenuItem,
            this.יציאהToolStripMenuItem});
            this.מאפייניםToolStripMenuItem.Name = "מאפייניםToolStripMenuItem";
            this.מאפייניםToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.מאפייניםToolStripMenuItem.Text = "מאפיינים";
            // 
            // שנהאתצבעהרקעToolStripMenuItem
            // 
            this.שנהאתצבעהרקעToolStripMenuItem.Name = "שנהאתצבעהרקעToolStripMenuItem";
            this.שנהאתצבעהרקעToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.שנהאתצבעהרקעToolStripMenuItem.Text = "שנה את צבע הרקע של הטופס";
            this.שנהאתצבעהרקעToolStripMenuItem.Click += new System.EventHandler(this.שנהאתצבעהרקעToolStripMenuItem_Click);
            // 
            // יציאהToolStripMenuItem
            // 
            this.יציאהToolStripMenuItem.Name = "יציאהToolStripMenuItem";
            this.יציאהToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.יציאהToolStripMenuItem.Text = "יציאה";
            this.יציאהToolStripMenuItem.Click += new System.EventHandler(this.יציאהToolStripMenuItem_Click);
            // 
            // עזרהToolStripMenuItem
            // 
            this.עזרהToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הצגחלוןעזרהToolStripMenuItem,
            this.אודותToolStripMenuItem});
            this.עזרהToolStripMenuItem.Name = "עזרהToolStripMenuItem";
            this.עזרהToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.עזרהToolStripMenuItem.Text = "עזרה";
            // 
            // הצגחלוןעזרהToolStripMenuItem
            // 
            this.הצגחלוןעזרהToolStripMenuItem.Name = "הצגחלוןעזרהToolStripMenuItem";
            this.הצגחלוןעזרהToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.הצגחלוןעזרהToolStripMenuItem.Text = "הצג חלון עזרה";
            this.הצגחלוןעזרהToolStripMenuItem.Click += new System.EventHandler(this.הצגחלוןעזרהToolStripMenuItem_Click);
            // 
            // אודותToolStripMenuItem
            // 
            this.אודותToolStripMenuItem.Name = "אודותToolStripMenuItem";
            this.אודותToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.אודותToolStripMenuItem.Text = "אודות ";
            this.אודותToolStripMenuItem.Click += new System.EventHandler(this.אודותToolStripMenuItem_Click);
            // 
            // ShapesTimer
            // 
            this.ShapesTimer.Enabled = true;
            this.ShapesTimer.Interval = 250;
            this.ShapesTimer.Tick += new System.EventHandler(this.ShapesTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(473, 403);
            this.Controls.Add(this.mainMenu);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem מאפייניםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem שנהאתצבעהרקעToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem יציאהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem עזרהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הצגחלוןעזרהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem אודותToolStripMenuItem;
        private System.Windows.Forms.Timer ShapesTimer;
        private System.Windows.Forms.ColorDialog backGroundColorDialog;
    }
}
