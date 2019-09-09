using GUI;
using GUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicturesStorage
{
    public partial class UploadWindow : Form
    {
        private bool isEditingTagsList = true;
        public event OnTagInfoChangeEventHandler TagInfoChange;
        internal readonly EditNameWindow EditNameWindow = new EditNameWindow();

        public UploadWindow(OnTagInfoChangeEventHandler TagInfoChange)
        {
            this.TagInfoChange = TagInfoChange;
            InitializeComponent();
            ShowEditTagsButtons(false);
        }


        private void FindPicturePath_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Path_textBox3.Text = openFileDialog1.FileName;
        }

        internal void UploadTags(List<string> tags)
        {
            TagsList.DataSource = tags;
        }

        public void Clear()
        {
            Path_textBox3.Text = string.Empty;
            TagsList.DataSource = null;
        }

        private void Addtag_button_Click(object sender, EventArgs e)
        {
            ClearTextBox();

            DialogResult result = EditNameWindow.ShowDialog(this);

            if (result == DialogResult.Cancel || string.IsNullOrEmpty(EditNameWindow.NameTextBox.Text))
            {
                MessageBox.Show("Operation canceled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TagInfoChange != null
                && TagInfoChange(this, new TagInfoEventArgs(EditNameWindow.NameTextBox.Text,TagInfoChangeOperation.Add)))
            {
                MessageBox.Show("Tag added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to add tag", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditNameTagbutton_Click(object sender, EventArgs e)
        {
            string tagName;
            string newTagName;

            if (TagsList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Select one tag to change name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClearTextBox();
            EditNameWindow.NameTextBox.Text = TagsList.SelectedItem.ToString();

            DialogResult result = EditNameWindow.ShowDialog(this);
            if (result == DialogResult.Cancel ||
                string.IsNullOrEmpty(EditNameWindow.NameTextBox.Text) ||
                string.Equals(TagsList.SelectedItem.ToString(), EditNameWindow.NameTextBox.Text))
            {
                MessageBox.Show("Operation canceled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tagName = TagsList.SelectedItem.ToString();
            newTagName = EditNameWindow.NameTextBox.Text;

            if (TagInfoChange != null &&
                TagInfoChange(this, new TagInfoEventArgs(
                tagName,
                newTagName,
                TagInfoChangeOperation.Edit)))
            {
                MessageBox.Show("Tag edited successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to edit tag", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTagbutton_Click(object sender, EventArgs e)
        {
            if (TagsList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Select one tag to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (TagInfoChange != null &&
                TagInfoChange(this, new TagInfoEventArgs(
                    TagsList.SelectedItem.ToString(),
                    TagInfoChangeOperation.Delete)))
            {
                MessageBox.Show("Tag deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to delete tag", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (isEditingTagsList)
            {
                OK_button.Enabled = false;
                ShowEditTagsButtons(true);
                isEditingTagsList = false;
            }
            else
            {
                OK_button.Enabled = true;
                ShowEditTagsButtons(false);
                isEditingTagsList = true;
            }
        }

        private void OK_button_Click(object sender, EventArgs e)
        {

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            ShowEditTagsButtons(false);
        }

        void ShowEditTagsButtons(bool flag)
        {
            addtag_button.Visible = DeleteTagbutton.Visible = EditNameTagbutton.Visible = flag;
        }

        private void ClearTextBox()
        {
            if (string.IsNullOrEmpty(EditNameWindow.NameTextBox.Text))
                return;

            EditNameWindow.NameTextBox.Text = string.Empty;
        }
    }
}
