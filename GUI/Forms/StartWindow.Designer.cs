namespace PicturesStorage
{
    partial class StartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            this.Load_button = new System.Windows.Forms.Button();
            this.Find_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrainianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Load_button
            // 
            this.Load_button.BackColor = System.Drawing.SystemColors.Control;
            this.Load_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Load_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Load_button.Location = new System.Drawing.Point(280, 47);
            this.Load_button.Margin = new System.Windows.Forms.Padding(4);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(239, 41);
            this.Load_button.TabIndex = 2;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = false;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Find_button
            // 
            this.Find_button.BackColor = System.Drawing.SystemColors.Control;
            this.Find_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Find_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Find_button.Location = new System.Drawing.Point(13, 47);
            this.Find_button.Margin = new System.Windows.Forms.Padding(4);
            this.Find_button.Name = "Find_button";
            this.Find_button.Size = new System.Drawing.Size(239, 41);
            this.Find_button.TabIndex = 3;
            this.Find_button.Text = "Find";
            this.Find_button.UseVisualStyleBackColor = false;
            this.Find_button.Click += new System.EventHandler(this.Find_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 24);
            this.toolStripMenuItem1.Text = "Window";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukrainianToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // ukrainianToolStripMenuItem
            // 
            this.ukrainianToolStripMenuItem.Name = "ukrainianToolStripMenuItem";
            this.ukrainianToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.ukrainianToolStripMenuItem.Text = "Ukrainian";
            this.ukrainianToolStripMenuItem.Click += new System.EventHandler(this.UkrainianToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frogToolStripMenuItem,
            this.navyToolStripMenuItem,
            this.brickToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // frogToolStripMenuItem
            // 
            this.frogToolStripMenuItem.Name = "frogToolStripMenuItem";
            this.frogToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.frogToolStripMenuItem.Text = "Frog";
            this.frogToolStripMenuItem.Click += new System.EventHandler(this.FrogToolStripMenuItem_Click);
            // 
            // navyToolStripMenuItem
            // 
            this.navyToolStripMenuItem.Name = "navyToolStripMenuItem";
            this.navyToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.navyToolStripMenuItem.Text = "Navy";
            this.navyToolStripMenuItem.Click += new System.EventHandler(this.NavyToolStripMenuItem_Click);
            // 
            // brickToolStripMenuItem
            // 
            this.brickToolStripMenuItem.Name = "brickToolStripMenuItem";
            this.brickToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.brickToolStripMenuItem.Text = "Brick";
            this.brickToolStripMenuItem.Click += new System.EventHandler(this.BrickToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 108);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(532, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(532, 130);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Find_button);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartWindow";
            this.Text = "Pictures Storage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button Find_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukrainianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

