using PicturesStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.ComponentModel;
using System.Globalization;
using System.Drawing;

namespace GUI
{
    public class ViewManager : IViewController, IViewModel
    {
        private StartWindow startWindow = null;
        private FindWindow findWindow = null;
        private UploadWindow uploadWindow = null;

        
        public static string LanguageProperty = Properties.Settings.Default.Language;

        public event LoadPictureInformation LoadPictureInfo;
        public event AddPictureInformation AddPictureInfo;
        public event LoadPicturePathesByTags queryToPictureByTags;

        public ViewManager()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageProperty);
            startWindow = new StartWindow();
            findWindow = new FindWindow();
            uploadWindow = new UploadWindow();

            startWindow.LanguageChange += languageChangeHandler;
            startWindow.WindowCalled += windowCallHandler;
            startWindow.ThemeChange += themeChangeHandler;

            findWindow.LoadPicturePathes += queryForPicturePathes;
        }

        #region Start form event's handlers
        //Main form event's handlers//
        private void themeChangeHandler(Theme theme)
        {
            switch (theme)
            {
                case Theme.Frog:
                    themeChange(Properties.Resources.frog);
                    break;
                case Theme.Navy:
                    themeChange(Properties.Resources.navy);
                    break;
                case Theme.Brick:
                    themeChange(Properties.Resources.brick);
                    break;
            }
        }

        private void themeChange(Bitmap backgroungImage)
        {
            startWindow.BackgroundImage = backgroungImage;
            findWindow.BackgroundImage = backgroungImage;
            uploadWindow.BackgroundImage = backgroungImage;
        }

        private void languageChangeHandler(Language language)
        {
            if (MessageBox.Show("Change language required restart application." +
                "\n Change language?",
                "Are you sure?",
                MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            switch (language)
            {
                case Language.English:
                    LanguageProperty = "en-US";
                    Properties.Settings.Default.Language = "en-US";
                    Properties.Settings.Default.Save();
                    break;
                case Language.Ukrainian:
                    LanguageProperty = "uk-UA";
                    Properties.Settings.Default.Language = "uk-UA";
                    Properties.Settings.Default.Save();
                    break;
                default:
                    break;
            }


        }
        private void windowCallHandler(Windows window)
        {
            LoadPictureInfo();

            switch (window)
            {
                case Windows.UploadWindow:
                    if (uploadWindow.ShowDialog() == DialogResult.OK)
                    {
                        if (string.IsNullOrEmpty(uploadWindow.Path_textBox3.Text) ||
                            uploadWindow.TagsList.SelectedItems.Count < 1)
                        {
                            MessageBox.Show("Select file please or select tag!");
                            uploadWindow.Clear();
                            return;
                        }

                        List<string> selectedTags = new List<string>();
                        foreach (string item in uploadWindow.TagsList.SelectedItems)
                        {
                            selectedTags.Add(item);
                        }

                        if (AddPictureInfo(uploadWindow.Path_textBox3.Text, selectedTags))
                        {
                            MessageBox.Show("Picture added successfully");
                        }
                        else
                        {
                            MessageBox.Show("Picture added failed");
                        }
                    }
                    uploadWindow.Clear();
                    break;

                case Windows.FindWindow:
                    findWindow.ShowDialog();
                    break;

                case Windows.None:
                    break;

                case Windows.StartWindow:
                    break;
            }
        }
        #endregion

        #region Upload form handlers
        private List<string> queryForPicturePathes(List<string> pathes)
        {
            return queryToPictureByTags(pathes);
        }
        #endregion


        public void LoadGUI()
        {
            LoadPictureInfo();
            Application.Run(startWindow);
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
            uploadWindow.UploadTags(tags);
        }


        #region Change language on programm run (not work correctly=> Control.ControlCollection doesn't have all form elements)
        //static List<Form> forms = new List<Form>();
        //private static void ChangeLanguage(string lang)
        //{
        //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
        //    foreach (Form frm in forms)
        //    {
        //        localizeForm(frm);
        //    }
        //}

        //private static void localizeForm(Form frm)
        //{
        //    var manager = new ComponentResourceManager(frm.GetType());
        //    manager.ApplyResources(frm, "$this");
        //    applyResources(manager, frm.Controls);
        //}

        //private static void applyResources(ComponentResourceManager manager, Control.ControlCollection ctls)
        //{
        //    foreach (Control ctl in ctls)
        //    {
        //        manager.ApplyResources(ctl, ctl.Name);
        //        applyResources(manager, ctl.Controls);
        //    }
        //}
        #endregion
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
