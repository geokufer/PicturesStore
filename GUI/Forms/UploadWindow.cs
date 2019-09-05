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
        public UploadWindow()
        {
            InitializeComponent();
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

        }
    }
}
