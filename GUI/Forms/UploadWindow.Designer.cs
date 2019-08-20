namespace PicturesStorage
{
    partial class UploadWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadWindow));
            this.OK_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TagsList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FindPicturePath_button = new System.Windows.Forms.Button();
            this.Path_label = new System.Windows.Forms.Label();
            this.Path_textBox3 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK_button
            // 
            resources.ApplyResources(this.OK_button, "OK_button");
            this.OK_button.BackColor = System.Drawing.SystemColors.Control;
            this.OK_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OK_button.Name = "OK_button";
            this.OK_button.UseVisualStyleBackColor = false;
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
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.FindPicturePath_button);
            this.groupBox2.Controls.Add(this.Path_label);
            this.groupBox2.Controls.Add(this.Path_textBox3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // FindPicturePath_button
            // 
            resources.ApplyResources(this.FindPicturePath_button, "FindPicturePath_button");
            this.FindPicturePath_button.Name = "FindPicturePath_button";
            this.FindPicturePath_button.UseVisualStyleBackColor = true;
            this.FindPicturePath_button.Click += new System.EventHandler(this.FindPicturePath_button_Click);
            // 
            // Path_label
            // 
            resources.ApplyResources(this.Path_label, "Path_label");
            this.Path_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Path_label.Name = "Path_label";
            // 
            // Path_textBox3
            // 
            resources.ApplyResources(this.Path_textBox3, "Path_textBox3");
            this.Path_textBox3.Name = "Path_textBox3";
            this.Path_textBox3.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // UploadWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.OK_button);
            this.Name = "UploadWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Path_label;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FindPicturePath_button;
        protected internal System.Windows.Forms.ListBox TagsList;
        protected internal System.Windows.Forms.TextBox Path_textBox3;
    }
}