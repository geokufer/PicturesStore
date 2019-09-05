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
            this.EditNameTagbutton = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.DeleteTagbutton = new System.Windows.Forms.Button();
            this.addtag_button = new System.Windows.Forms.Button();
            this.TagsList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FindPicturePath_button = new System.Windows.Forms.Button();
            this.Path_label = new System.Windows.Forms.Label();
            this.Path_textBox3 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonsgroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ButtonsgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OK_button
            // 
            this.OK_button.BackColor = System.Drawing.Color.DarkGray;
            this.OK_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.OK_button, "OK_button");
            this.OK_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OK_button.Name = "OK_button";
            this.OK_button.UseVisualStyleBackColor = false;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.Color.DarkGray;
            this.Back_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Back_button, "Back_button");
            this.Back_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back_button.Name = "Back_button";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.EditNameTagbutton);
            this.groupBox1.Controls.Add(this.Edit_button);
            this.groupBox1.Controls.Add(this.DeleteTagbutton);
            this.groupBox1.Controls.Add(this.addtag_button);
            this.groupBox1.Controls.Add(this.TagsList);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // EditNameTagbutton
            // 
            this.EditNameTagbutton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.EditNameTagbutton, "EditNameTagbutton");
            this.EditNameTagbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditNameTagbutton.Name = "EditNameTagbutton";
            this.EditNameTagbutton.UseVisualStyleBackColor = false;
            this.EditNameTagbutton.Click += new System.EventHandler(this.EditNameTagbutton_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Edit_button, "Edit_button");
            this.Edit_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.UseVisualStyleBackColor = false;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // DeleteTagbutton
            // 
            this.DeleteTagbutton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.DeleteTagbutton, "DeleteTagbutton");
            this.DeleteTagbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteTagbutton.Name = "DeleteTagbutton";
            this.DeleteTagbutton.UseVisualStyleBackColor = false;
            this.DeleteTagbutton.Click += new System.EventHandler(this.DeleteTagbutton_Click);
            // 
            // addtag_button
            // 
            this.addtag_button.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.addtag_button, "addtag_button");
            this.addtag_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addtag_button.Name = "addtag_button";
            this.addtag_button.UseVisualStyleBackColor = false;
            this.addtag_button.Click += new System.EventHandler(this.Addtag_button_Click);
            // 
            // TagsList
            // 
            this.TagsList.FormattingEnabled = true;
            resources.ApplyResources(this.TagsList, "TagsList");
            this.TagsList.Name = "TagsList";
            this.TagsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.FindPicturePath_button);
            this.groupBox2.Controls.Add(this.Path_label);
            this.groupBox2.Controls.Add(this.Path_textBox3);
            resources.ApplyResources(this.groupBox2, "groupBox2");
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
            // ButtonsgroupBox
            // 
            this.ButtonsgroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ButtonsgroupBox.Controls.Add(this.Back_button);
            this.ButtonsgroupBox.Controls.Add(this.OK_button);
            resources.ApplyResources(this.ButtonsgroupBox, "ButtonsgroupBox");
            this.ButtonsgroupBox.Name = "ButtonsgroupBox";
            this.ButtonsgroupBox.TabStop = false;
            // 
            // UploadWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ButtonsgroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UploadWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ButtonsgroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.Button addtag_button;
        private System.Windows.Forms.GroupBox ButtonsgroupBox;
        private System.Windows.Forms.Button DeleteTagbutton;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button EditNameTagbutton;
    }
}