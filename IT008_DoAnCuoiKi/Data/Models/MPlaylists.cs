using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IT008_DoAnCuoiKi.Data.Models.MSearch;

namespace IT008_DoAnCuoiKi.Data.Models
{
    public class Owner
    {
        public string display_name { get; set; }
        public ExternalUrls external_urls { get; set; }
        public string href { get; set; }
    }
    public class tTracks
    {
        public string href { get; set; }
        public int total { get; set; }
    }

    public class PlaylistsItem : BaseModel
    {
        public bool collaborative { get; set; }
        public string description { get; set; }
        public Owner owner { get; set; }
        public string type { get; set; }
        public tTracks tracks { get; set; }
    }
    public class MPlaylists : BaseSearch
    {
        public List<PlaylistsItem> items { get; set; }
    }
}
