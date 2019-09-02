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

            view.LoadPictureInfo += getPicturesInfoFromDB;
            view.AddPictureInfo += AddPictureInfo;
            view.queryToPictureByTags += getPicturesByTags;
        }

        private List<string> getPicturesByTags(List<string> tags)
        {
            return model.GetPicturesPathes(tags);
        }

        private bool AddPictureInfo(string path, List<string> selectedTags) => model.AddPictureToDB(path, selectedTags);

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
