using PicturesStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI
{
    public class ViewManager : IViewController, IViewModel
    {
        private StartWindow startWindow = null;
        private FindWindow findWindow = null;
        private UploadWindow uploadWindow = null;

        public event LoadPictureInformation LoadPictureInfo;

        public ViewManager()
        {
            startWindow = new StartWindow();
            findWindow = new FindWindow();
            uploadWindow = new UploadWindow();

            startWindow.LanguageChange += languageChangeHandler;
            startWindow.WindowCalled += windowCallHandler;
            startWindow.ThemeChange += themeChangeHandler;
        }

        private void themeChangeHandler(Theme theme)
        {
            throw new NotImplementedException();
        }
        private void languageChangeHandler(Language language)
        {
            throw new NotImplementedException();
        }
        private void windowCallHandler(Windows window)
        {
            DialogResult result;
            switch (window)
            {
                case Windows.None:
                    break;
                case Windows.StartWindow:
                    break;
                case Windows.FindWindow:
                    result = findWindow.ShowDialog();
                    if (result == DialogResult.OK)
                    {

                    }
                    break;
                case Windows.UploadWindow:
                    result = uploadWindow.ShowDialog();
                    if (result == DialogResult.OK)
                    {

                    }
                    break;
            }
        }
        public void LoadGUI()
        {
            Application.Run(startWindow);
            LoadPictureInfo();
        }

        public void GetPictureInfo()
        {

        }
        public void OnPicturePathUpdate(List<string> pathes)
        {
            
        }
        public void OnTagsNameUpdate(List<string> tags)
        {
            findWindow.UploadTags(tags);
        }

    }

    #region Enums
    public enum Theme
    {
        Frog = 0,
        Navy = 1,
        Brick = 2
    }
    public enum Language
    {
        English = 0,
        Ukrainian = 1
    }
    public enum Windows
    {
        None = 0,
        StartWindow = 1,
        FindWindow = 2,
        UploadWindow = 3
    }
    #endregion
}
