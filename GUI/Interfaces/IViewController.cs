using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public delegate void LoadPicturesInfoEventHandler();
    public delegate List<string> LoadPicturePathesByTagsEventHandler(object sender, LoadPicturePathesByTagsEventArgs e);
    public delegate bool OnPictureInfoChangeEventHandler(object sender, PictureInfoEventArgs e);
    //tag delegate
    public delegate bool OnTagInfoChangeEventHandler(object sender, TagInfoEventArgs e);

    public interface IViewController
    {
        void LoadGUI();
        event OnPictureInfoChangeEventHandler PictureInfoChange;
        event LoadPicturesInfoEventHandler LoadPicturesInfo;
        event LoadPicturePathesByTagsEventHandler GetPicturePathesByTags;
        //tag events
        event OnTagInfoChangeEventHandler TagInfoChange;
    }

    public class LoadPicturePathesByTagsEventArgs : EventArgs
    {
        public List<string> Tags;

        public LoadPicturePathesByTagsEventArgs(List<string> tags)
        {
            Tags = tags ?? throw new ArgumentNullException(nameof(tags));
        }
    }

    public class PictureInfoEventArgs : EventArgs
    {
        public string Path;
        public List<string> Tags;
        public PicturePathChangeOperation operation;

        public PictureInfoEventArgs(string path, PicturePathChangeOperation operation)
        {
            Path = path ?? throw new ArgumentNullException(nameof(path));
            this.operation = operation;
        }
        public PictureInfoEventArgs(string path, List<string> tags, PicturePathChangeOperation operation)
        {
            Path = path ?? throw new ArgumentNullException(nameof(path));
            Tags = tags ?? throw new ArgumentNullException(nameof(tags));
            this.operation = operation;
        }
    }

    public class TagInfoEventArgs : EventArgs
    {
        public string Name;
        public string NewNameForEdit;
        public TagInfoChangeOperation Operation;

        public TagInfoEventArgs(string name, TagInfoChangeOperation operation)
        {
            Name = name
                ?? throw new ArgumentNullException(nameof(Name));
            Operation = operation;
        }

        public TagInfoEventArgs(string oldName, string newName, TagInfoChangeOperation operation) 
        {
            NewNameForEdit = newName 
                ?? throw new ArgumentNullException(nameof(newName));
            Name = oldName
                ?? throw new ArgumentNullException(nameof(oldName));
            Operation = operation;
        }
    }

    public enum TagInfoChangeOperation
    {
        Add,
        Edit,
        Delete
    }

    public enum PicturePathChangeOperation
    {
        Add,
        Delete
    }
}
