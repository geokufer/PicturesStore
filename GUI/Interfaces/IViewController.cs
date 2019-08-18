using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public delegate void LoadPictureInformation();
    public interface IViewController
    {
        void LoadGUI();
        event LoadPictureInformation LoadPictureInfo;
    }
}
