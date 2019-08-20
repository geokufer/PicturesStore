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
    delegate List<string> LoadPicturePathesByTags (List<string> pathes);
    public partial class FindWindow : Form
    {
        event LoadPicturePathesByTags LoadPicturePathes;
        public FindWindow()
        {
            InitializeComponent();
        }

        public void UploadTags(List<string> tags)
        {
            TagsList.DataSource = tags;
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            if (TagsList.SelectedItems.Count < 1)
            {
                MessageBox.Show("Select more than 1 tag");
                return;
            }


            List<string> tags = new List<string>();
            foreach (string item in TagsList.SelectedItems)
            {
                tags.Add(item);
            }


            List<string> pathes = LoadPicturePathes(tags);
            if (pathes == null)
            {
                MessageBox.Show("Failed to load pathes");
                return;
            }

            Pathes_listBox.DataSource = pathes;
            //TODO end flow of load pathes
        }
    }
}
