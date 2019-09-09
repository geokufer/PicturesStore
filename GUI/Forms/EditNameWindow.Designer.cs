namespace GUI.Forms
{
    partial class EditNameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNameWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.OK_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.Cancel_button);
            this.groupBox1.Controls.Add(this.OK_button);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.Name = "NameTextBox";
            // 
            // Cancel_button
            // 
            this.Cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Cancel_button, "Cancel_button");
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // OK_button
            // 
            this.OK_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.OK_button, "OK_button");
            this.OK_button.Name = "OK_button";
            this.OK_button.UseVisualStyleBackColor = true;
            // 
            // EditNameWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditNameWindow";
            this.Activated += new System.EventHandler(this.EditNameWindow_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button OK_button;
        internal System.Windows.Forms.TextBox NameTextBox;
    }
}