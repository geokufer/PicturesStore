using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GUI;

namespace PicturesStorage
{
    //public delegate List<string> LoadPicturePathesByTags (List<string> pathes);
    public partial class FindWindow : Form
    {
        LoadPicturePathesByTagsEventHandler GetPicturePathesByTags;

        public FindWindow(LoadPicturePathesByTagsEventHandler GetPicturePathesByTags)
        {
            this.GetPicturePathesByTags = GetPicturePathesByTags
                ?? throw new ArgumentNullException(nameof(LoadPicturePathesByTagsEventHandler)); ;

            InitializeComponent();
        }

        public void UploadTags(List<string> tags)
        {
            TagsList.DataSource = tags;
        }

        private void Pathes_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = Image.FromFile(Pathes_listBox.SelectedItem.ToString());
            }
            catch (FileNotFoundException exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (TagsList.SelectedItems.Count < 1)
            {
                MessageBox.Show("Select nothing");
                return;
            }

            List<string> tags = new List<string>();
            foreach (string item in TagsList.SelectedItems)
            {
                tags.Add(item);
            }

            //event to load pictures by tag from db
            List<string> pathes = GetPicturePathesByTags(this, new LoadPicturePathesByTagsEventArgs(tags));
            if (pathes == null)
            {
                MessageBox.Show("Failed to load pathes");
                return;
            }
            //show picture pathes in listbox
            Pathes_listBox.DataSource = pathes;
            //TODO end flow of load pathes
        }
    }
}
