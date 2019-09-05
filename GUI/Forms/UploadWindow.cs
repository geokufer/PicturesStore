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
        public UploadWindow()
        {
            InitializeComponent();
            ShowEditTagsButtons(false);
        }

        private void FindPicturePath_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.Cancel)
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

        }

        private void EditNameTagbutton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteTagbutton_Click(object sender, EventArgs e)
        {

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
    }
}
