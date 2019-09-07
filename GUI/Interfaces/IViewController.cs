using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public delegate void LoadPicturesInfoEventHandler();
    public delegate bool AddNewPictureInfoEventHandler(object sender, AddNewPictureInfoEventArgs e);
    public delegate List<string> LoadPicturePathesByTagsEventHandler(object sender, LoadPicturePathesByTagsEventArgs e);

    public interface IViewController
    {
        void LoadGUI();
        event AddNewPictureInfoEventHandler AddPictureInfo;
        event LoadPicturesInfoEventHandler LoadPicturesInfo;
        event LoadPicturePathesByTagsEventHandler GetPicturePathesByTags;
    }

    public class AddNewPictureInfoEventArgs : EventArgs
    {
        public string Path;
        public List<string> Tags;

        public AddNewPictureInfoEventArgs(string path, List<string> tags)
        {
            Path = path ?? throw new ArgumentNullException(nameof(path));
            Tags = tags ?? throw new ArgumentNullException(nameof(tags));
        }
    }

    public class LoadPicturePathesByTagsEventArgs
    {
        public List<string> Tags;

        public LoadPicturePathesByTagsEventArgs(List<string> tags)
        {
            Tags = tags ?? throw new ArgumentNullException(nameof(tags));
        }
    }
}
