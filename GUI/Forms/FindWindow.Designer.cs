namespace PicturesStorage
{
    partial class FindWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TagsList = new System.Windows.Forms.ListBox();
            this.Find_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pathes_listBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.TagsList);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // TagsList
            // 
            resources.ApplyResources(this.TagsList, "TagsList");
            this.TagsList.FormattingEnabled = true;
            this.TagsList.Name = "TagsList";
            this.TagsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // Find_button
            // 
            resources.ApplyResources(this.Find_button, "Find_button");
            this.Find_button.BackColor = System.Drawing.SystemColors.Control;
            this.Find_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Find_button.Name = "Find_button";
            this.Find_button.UseVisualStyleBackColor = false;
            this.Find_button.Click += new System.EventHandler(this.Find_button_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.Pathes_listBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Pathes_listBox
            // 
            resources.ApplyResources(this.Pathes_listBox, "Pathes_listBox");
            this.Pathes_listBox.FormattingEnabled = true;
            this.Pathes_listBox.Name = "Pathes_listBox";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Back_button
            // 
            resources.ApplyResources(this.Back_button, "Back_button");
            this.Back_button.BackColor = System.Drawing.SystemColors.Control;
            this.Back_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back_button.Name = "Back_button";
            this.Back_button.UseVisualStyleBackColor = false;
            // 
            // FindWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Find_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "FindWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox TagsList;
        private System.Windows.Forms.Button Find_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Pathes_listBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}