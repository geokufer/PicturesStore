using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using Model.Entities;

namespace Model
{
    public class ModelManager
    {
        const string DBName = "PictureInfoDB";

        IViewModel view;
        public ModelManager(IViewModel view)
        {
            this.view = view;
        }

        public void GetTags()
        {
            using (PictureInfoDBContext db = new PictureInfoDBContext(DBName))
            {
                List<string> TagName = new List<string>();
                foreach (var tag in db.GetAllTags())
                {
                    TagName.Add(tag.Name);
                }
                view.OnTagsNameUpdate(TagName);
            }
        }
        public void GetPicturesPathes()
        {
            using (PictureInfoDBContext db = new PictureInfoDBContext(DBName))
            {
                List<string> PicturePathes = new List<string>();
                foreach (var picture in db.GetAllPictures())
                {
                    PicturePathes.Add(picture.Path);
                }
                view.OnPicturePathUpdate(PicturePathes);
            }
        }
    }

}
