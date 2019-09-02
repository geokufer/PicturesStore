using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using PictureInfoDBContext;
using PictureInfoDB = PictureInfoDBContext.PictureInfoDBContext;

namespace Model
{
    //TODO SingleTon
    public class ModelManager
    {
        const string DBName = "PictureInfoDB";
        private static object lockObject = new object();
        IViewModel view;
        private static ModelManager modelManager;


        protected ModelManager(IViewModel view)
        {
            this.view = view;
        }

        public static ModelManager GetInstatnce(IViewModel view)
        {
            if (view == null)
            {
                throw new ArgumentNullException();
            }

            if (modelManager == null)
            {
                lock (lockObject)
                {
                    if (modelManager == null)
                    {
                        modelManager = new ModelManager(view);
                    }
                }
            }
            return modelManager;
        }

        public void GetTags()
        {
            using (PictureInfoDB db = new PictureInfoDB(DBName))
            {
                List<string> TagName = new List<string>();
                foreach (var tag in db.GetAllTags())
                {
                    TagName.Add(tag.Name);
                }
                view.OnTagsNameUpdate(TagName);
            }
        }

        public bool AddPictureToDB(string path, List<string> selectedTags)
        {
            using (PictureInfoDB db = new PictureInfoDB(DBName))
            {
                try
                {
                    db.AddPicture(path);
                    foreach (var tagName in selectedTags)
                    {
                        db.AddTagsToPicture(path, new Tag { Name = tagName});
                    }
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
        }

        public void GetPicturesPathesToView()
        {
            using (PictureInfoDB db = new PictureInfoDB(DBName))
            {
                List<string> PicturePathes = new List<string>();
                foreach (var picture in db.GetAllPictures())
                {
                    PicturePathes.Add(picture.Path);
                }
                view.OnPicturePathUpdate(PicturePathes);
            }
        }
        public List<string> GetPicturesPathes(List<string> tags)
        {
            using (PictureInfoDB db = new PictureInfoDB(DBName))
            {
                List<string> PicturePathes = new List<string>();
                foreach (var picture in db.GetAllPictures())
                {
                    //get all tag which binding to picture
                    List<string> pictureTags = new List<string>();
                    foreach (var tag in picture.Tags)
                    {
                        pictureTags.Add(tag.Name);
                    }

                    //add picture to main list of picture pathes, when at least one tag is equal 
                    if (pictureTags.Count == 0)
                    {
                        continue;
                    }
                    foreach (var tag in pictureTags)
                    {
                        if (tags.Contains(tag))
                        {
                            PicturePathes.Add(picture.Path);
                            break; 
                        }
                    }                               
                }
                return PicturePathes;
            }
        }

    }

}
