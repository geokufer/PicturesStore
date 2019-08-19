using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public delegate void LoadPictureInformation();
    public delegate bool AddPictureInformation(string path, List<string> tags);
    public interface IViewController
    {
        void LoadGUI();
        event AddPictureInformation AddPictureInfo;
        event LoadPictureInformation LoadPictureInfo;
    }
}
