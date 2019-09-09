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
        private readonly IViewController view;
        private readonly ModelManager model;

        public ControllerManager()
        {
            view = new ViewManager();
            model = ModelManager.GetInstatnce(view as ViewManager);

            view.LoadPicturesInfo += GetPicturesInfoFromDB;
            view.PictureInfoChange += PictureInfoChange;
            view.GetPicturePathesByTags += GetPicturesByTags;
            view.TagInfoChange += TagInfoChangeEventHandler;
        }

        private bool TagInfoChangeEventHandler(object sender, TagInfoEventArgs e)
        {
            bool operationResult = false;
            switch (e.Operation)
            {
                case TagInfoChangeOperation.Add:
                    operationResult = model.AddTagToDB(e.Name);
                    break;
                case TagInfoChangeOperation.Edit:
                    operationResult = model.EditTagInDB(e.Name,e.NewNameForEdit);
                    break;
                case TagInfoChangeOperation.Delete:
                    operationResult = model.DeleteTagFromDB(e.Name);
                    break;
            }

            if (operationResult)
            {
                model.GetTagsFromDB();
            }
            return operationResult;
        }

        private List<string> GetPicturesByTags(object o, LoadPicturePathesByTagsEventArgs e)
        {
            if (e.Tags == null || e.Tags.Count == 0)
            {
                throw new ArgumentException("Tags list is empty or argument null");
            }

            return model.GetPicturesPathes(e.Tags);
        }

        private bool PictureInfoChange(object o, PictureInfoEventArgs e)
        {
            bool operationResult = false;

            switch (e.operation)
            {
                case PicturePathChangeOperation.Add:
                    if (string.IsNullOrEmpty(e.Path) || e.Tags.Count == 0)
                    {
                        throw new ArgumentException("Tags list is empty or argument null");
                    }
                    operationResult = model.AddPictureToDB(e.Path, e.Tags);
                    break;
                case PicturePathChangeOperation.Delete:
                    if (string.IsNullOrEmpty(e.Path))
                    {
                        throw new ArgumentException("Tags list is empty or argument null");
                    }
                    operationResult = model.DeletePictureFromDB(e.Path);
                    break;
            }

            if (operationResult)
            {
                model.GetPicturesPathesToView();
            }
            return operationResult;
        }

        private void GetPicturesInfoFromDB()
        {
            model.GetTagsFromDB();
            model.GetPicturesPathesToView();
        }

        public void Start()
        {
           view.LoadGUI();
        }
    }
}
