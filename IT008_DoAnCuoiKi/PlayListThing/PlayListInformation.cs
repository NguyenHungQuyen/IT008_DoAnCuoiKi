using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT008_DoAnCuoiKi.PlayListThing
{
    internal class PlayListInformation
    {
        public string Image { get; set; }
        public string ByWhom { get; set; }
        public string PlayListName { get; set; }
        public PlayListInformation(string image, string playListName, string byWhom)
        {
            Image = image;
            ByWhom = byWhom;
            PlayListName = playListName;
        }
    }
}
