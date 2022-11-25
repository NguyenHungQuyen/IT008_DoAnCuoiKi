using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IT008_DoAnCuoiKi.Data.Models.MSearch;

namespace IT008_DoAnCuoiKi.Data.Models
{

    public class TracksItem : BaseModel
    {
        public AlbumsItem album { get; set; }
        public List<string> available_markets { get; set; }
        public List<ArtistItem> artists { get; set; }
        public int disc_number { get; set; }
        public Int64 duration_ms { get; set; }
        public bool is_local { get; set; }
        public int popularity { get; set; }
        public string preview_url { get; set; }
        public int track_number { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public string duration_string { get; set; }
    }
    public class MTracks : BaseSearch
    {
        public List<TracksItem> items { get; set; }
    }
}
