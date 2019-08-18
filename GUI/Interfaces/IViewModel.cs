using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public interface IViewModel
    {
       void OnPicturePathUpdate(List<string> pathes);
       void OnTagsNameUpdate(List<string> tags);
    }
}
