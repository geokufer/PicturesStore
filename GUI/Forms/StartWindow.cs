using GUI;
using System;
using System.Windows.Forms;
using GUI.Properties;
using System.Threading;
using System.Globalization;
using System.Resources;
using System.ComponentModel;

namespace PicturesStorage
{
    public delegate void OnLanguageChange(Language language);
    public delegate void OnThemeChange(Theme theme);
    public delegate void OnWindowCalled(Windows window);

    public partial class StartWindow : Form 
    {

        public event OnLanguageChange LanguageChange;
        public event OnThemeChange ThemeChange;
        public event OnWindowCalled WindowCalled;

        

        public StartWindow()
        {
            InitializeComponent();
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            WindowCalled(Windows.FindWindow);
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            WindowCalled(Windows.UploadWindow);
        }

        private void UkrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageChange(Language.Ukrainian);
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanguageChange(Language.English);
        }

        private void FrogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeChange(Theme.Frog);
        }

        private void NavyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeChange(Theme.Navy);
        }

        private void BrickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemeChange(Theme.Brick);
        }
    }
}
