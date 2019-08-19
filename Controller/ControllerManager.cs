﻿using System;
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
            model = new ModelManager(view as ViewManager);

            view.LoadPictureInfo += getPicturesInfoFromDB;
            view.AddPictureInfo += AddPictureInfo;
        }

        private bool AddPictureInfo(string path, List<string> selectedTags) => model.AddPictureToDB(path, selectedTags);

        private void getPicturesInfoFromDB()
        {
            model.GetTags();
            model.GetPicturesPathes();
        }

        public void Start()
        {
           view.LoadGUI();
        }




    }
}
