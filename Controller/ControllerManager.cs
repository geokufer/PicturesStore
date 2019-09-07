using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
using Model;

namespace Controller
{
    public class ControllerManager
    {
        private IViewController view;
        private ModelManager model;

        public ControllerManager()
        {
            view = new ViewManager();
            model = ModelManager.GetInstatnce(view as ViewManager);

            view.LoadPicturesInfo += getPicturesInfoFromDB;
            view.AddPictureInfo += AddPictureInfoToDB;
            view.GetPicturePathesByTags += getPicturesByTags;
        }

        private List<string> getPicturesByTags(object o, LoadPicturePathesByTagsEventArgs e)
        {
            if (e.Tags == null || e.Tags.Count == 0)
            {
                throw new ArgumentException("Tags list is empty or argument null");
            }

            return model.GetPicturesPathes(e.Tags);
        }

        private bool AddPictureInfoToDB(object o, PictureInfoEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Path) || e.Tags.Count == 0)
            {
                throw new ArgumentException("Tags list is empty or argument null");
            }
            return model.AddPictureToDB(e.Path, e.Tags);
        }

        private void getPicturesInfoFromDB()
        {
            model.GetTags();
            model.GetPicturesPathesToView();
        }

        public void Start()
        {
           view.LoadGUI();
        }
    }
}
