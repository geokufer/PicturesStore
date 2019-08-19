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
            this.OK_button.BackColor = System.Drawing.SystemColors.Control;
            this.OK_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OK_button.Location = new System.Drawing.Point(468, 417);
            this.OK_button.Margin = new System.Windows.Forms.Padding(4);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(157, 41);
            this.OK_button.TabIndex = 3;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = false;
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.Control;
            this.Back_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back_button.Location = new System.Drawing.Point(277, 417);
            this.Back_button.Margin = new System.Windows.Forms.Padding(4);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(183, 41);
            this.Back_button.TabIndex = 8;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TagsList);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(16, 176);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(609, 233);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tags";
            // 
            // TagsList
            // 
            this.TagsList.FormattingEnabled = true;
            this.TagsList.ItemHeight = 25;
            this.TagsList.Location = new System.Drawing.Point(13, 32);
            this.TagsList.Margin = new System.Windows.Forms.Padding(4);
            this.TagsList.Name = "TagsList";
            this.TagsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.TagsList.Size = new System.Drawing.Size(587, 179);
            this.TagsList.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FindPicturePath_button);
            this.groupBox2.Controls.Add(this.Path_label);
            this.groupBox2.Controls.Add(this.Path_textBox3);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(609, 140);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find picture";
            // 
            // FindPicturePath_button
            // 
            this.FindPicturePath_button.Location = new System.Drawing.Point(462, 83);
            this.FindPicturePath_button.Name = "FindPicturePath_button";
            this.FindPicturePath_button.Size = new System.Drawing.Size(138, 39);
            this.FindPicturePath_button.TabIndex = 8;
            this.FindPicturePath_button.Text = "Find";
            this.FindPicturePath_button.UseVisualStyleBackColor = true;
            this.FindPicturePath_button.Click += new System.EventHandler(this.FindPicturePath_button_Click);
            // 
            // Path_label
            // 
            this.Path_label.AutoSize = true;
            this.Path_label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Path_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Path_label.Location = new System.Drawing.Point(1, 44);
            this.Path_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Path_label.Name = "Path_label";
            this.Path_label.Size = new System.Drawing.Size(75, 29);
            this.Path_label.TabIndex = 7;
            this.Path_label.Text = "Path:";
            // 
            // Path_textBox3
            // 
            this.Path_textBox3.Location = new System.Drawing.Point(101, 43);
            this.Path_textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.Path_textBox3.Name = "Path_textBox3";
            this.Path_textBox3.ReadOnly = true;
            this.Path_textBox3.Size = new System.Drawing.Size(499, 32);
            this.Path_textBox3.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files (*.jpg) |*.jpg";
            this.openFileDialog1.Title = "Find image";
            // 
            // UploadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(640, 476);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.OK_button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UploadWindow";
            this.Text = "UploadWindow";
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