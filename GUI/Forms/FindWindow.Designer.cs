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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TagsList);
            this.groupBox1.Controls.Add(this.Find_button);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // TagsList
            // 
            this.TagsList.FormattingEnabled = true;
            resources.ApplyResources(this.TagsList, "TagsList");
            this.TagsList.Name = "TagsList";
            this.TagsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // Find_button
            // 
            this.Find_button.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Find_button, "Find_button");
            this.Find_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Find_button.Name = "Find_button";
            this.Find_button.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Pathes_listBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Pathes_listBox
            // 
            this.Pathes_listBox.FormattingEnabled = true;
            resources.ApplyResources(this.Pathes_listBox, "Pathes_listBox");
            this.Pathes_listBox.Name = "Pathes_listBox";
            this.Pathes_listBox.SelectedIndexChanged += new System.EventHandler(this.Pathes_listBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.groupBox3, "groupBox3");
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
            this.Back_button.BackColor = System.Drawing.SystemColors.Control;
            this.Back_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Back_button, "Back_button");
            this.Back_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back_button.Name = "Back_button";
            this.Back_button.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.FindButton);
            this.groupBox4.Controls.Add(this.Back_button);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.FindButton, "FindButton");
            this.FindButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FindButton.Name = "FindButton";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FindWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button FindButton;
    }
}