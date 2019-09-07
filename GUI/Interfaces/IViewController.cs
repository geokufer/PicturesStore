﻿using System;
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
        event OnPictureInfoChangeEventHandler AddPictureInfo;
        event OnPictureInfoChangeEventHandler DeletePicture;
        event LoadPicturesInfoEventHandler LoadPicturesInfo;
        event LoadPicturePathesByTagsEventHandler GetPicturePathesByTags;
        //tag events
        event OnTagInfoChangeEventHandler AddTag;
        event OnTagInfoChangeEventHandler ChangeTagName;
        event OnTagInfoChangeEventHandler DeleteTag;
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

        public PictureInfoEventArgs(string path)
        {
            Path = path ?? throw new ArgumentNullException(nameof(path));
        }
        public PictureInfoEventArgs(string path, List<string> tags)
        {
            Path = path ?? throw new ArgumentNullException(nameof(path));
            Tags = tags ?? throw new ArgumentNullException(nameof(tags));
        }
    }

    public class TagInfoEventArgs : EventArgs
    {
        public string Name;
        public string NewName;

        public TagInfoEventArgs(string name)
        {
            Name = name
                ?? throw new ArgumentNullException(nameof(Name));
        }

        public TagInfoEventArgs(string name, string newName) 
        {
            NewName = newName 
                ?? throw new ArgumentNullException(nameof(newName));
            Name = name
                ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
