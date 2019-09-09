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
using GUI.Properties;

namespace GUI
{
    public class ViewManager : IViewController, IViewModel
    {
        public static string LanguageProperty = Settings.Default.Language;
        public static int ThemeProperty = Settings.Default.Theme;

        private StartWindow startWindow = null;
        private FindWindow findWindow = null;
        private UploadWindow uploadWindow = null;

        public event LoadPicturesInfoEventHandler LoadPicturesInfo;
        public event LoadPicturePathesByTagsEventHandler GetPicturePathesByTags;
        public event OnPictureInfoChangeEventHandler PictureInfoChange;
        public event OnTagInfoChangeEventHandler TagInfoChange;

        public ViewManager()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageProperty);
        }

        private void InitWindowsForm()
        {
            startWindow = new StartWindow();
            findWindow = new FindWindow(GetPicturePathesByTags, PictureInfoChange);
            uploadWindow = new UploadWindow(TagInfoChange);

            startWindow.LanguageChange += LanguageChangeEventHandler;
            startWindow.WindowCalled += WindowLoadEventHandler;
            startWindow.ThemeChange += ThemeChangeEventHandler;
        }

        #region Event's handlers from "Start form"
        private void ThemeChangeEventHandler(Theme theme)
        {
            switch (theme)
            {
                case Theme.Brick:
                    ThemeChange(Resources.brick);
                    ThemeProperty = (int)Theme.Brick;
                    break;
                case Theme.Navy:
                    ThemeChange(Resources.navy);
                    ThemeProperty = (int)Theme.Navy;
                    break;
                case Theme.Frog:
                    ThemeChange(Resources.frog);
                    ThemeProperty = (int)Theme.Frog;
                    break;
            }
            Settings.Default.Theme = ThemeProperty;
            Settings.Default.Save();
        }
        private void ThemeChange(Bitmap backgroungImage)
        {
            startWindow.BackgroundImage = backgroungImage;
            findWindow.BackgroundImage = backgroungImage;
            uploadWindow.BackgroundImage = backgroungImage;
            uploadWindow.EditNameWindow.BackgroundImage = backgroungImage;
        }
        private void LanguageChangeEventHandler(Language language)
        {
            if (MessageBox.Show("For language change restart application required." +
                "\nChange language?",
                "Change language",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            switch (language)
            {
                case Language.English:
                    LanguageProperty = "en-US";
                    break;
                case Language.Ukrainian:
                    LanguageProperty = "uk-UA";
                    break;
            }
            Settings.Default.Language = LanguageProperty;
            Settings.Default.Save();
        }
        private void WindowLoadEventHandler(Windows window)
        {
            LoadPicturesInfo();

            switch (window)
            {
                case Windows.UploadWindow:
                    startWindow.Hide();
                    if (uploadWindow.ShowDialog(startWindow) == DialogResult.OK)
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

                        if (PictureInfoChange(this, 
                            new PictureInfoEventArgs(uploadWindow.Path_textBox3.Text, selectedTags,PicturePathChangeOperation.Add)))
                        {
                            MessageBox.Show("Picture added successfully");
                        }
                        else
                        {
                            MessageBox.Show("Picture added failed");
                        }
                    }
                    startWindow.Show();
                    uploadWindow.Clear();
                    break;

                case Windows.FindWindow:
                    startWindow.Hide();
                    findWindow.ShowDialog(startWindow);
                    startWindow.Show();
                    break;

                case Windows.None:
                    break;

                case Windows.StartWindow:
                    break;
            }
        }
        #endregion

        #region IViewController realisation
        public void LoadGUI()
        {
            InitWindowsForm();
            ThemeChangeEventHandler((Theme)ThemeProperty);
            LoadPicturesInfo();
            Application.Run(startWindow);
        }
        #endregion

        #region IViewModel realisation
        public void OnPicturePathUpdate(List<string> pathes)
        {
            if (pathes == null)
            {
                MessageBox.Show("Failed to load pathes");
                return;
            }
            findWindow.LoadPicturePathes(pathes);
        }
        public void OnTagsNameUpdate(List<string> tags)
        {
            findWindow.UploadTags(tags);
            uploadWindow.UploadTags(tags);
        }
        #endregion

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
        Brick = 0,
        Navy = 1,
        Frog = 2
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
