using GUI;
using System;
using System.Windows.Forms;

namespace PicturesStorage
{
    public delegate void OnLanguageChangeEventHandler(Language language);
    public delegate void OnThemeChangeEventHandler(Theme theme);
    public delegate void OnWindowCalledEventHandler(Windows window);

    public partial class StartWindow : Form 
    {
        public event OnLanguageChangeEventHandler LanguageChange;
        public event OnThemeChangeEventHandler ThemeChange;
        public event OnWindowCalledEventHandler WindowCalled;
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
