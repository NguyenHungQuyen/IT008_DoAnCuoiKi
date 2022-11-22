using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IT008_DoAnCuoiKi.Data.Models.MArtists;

namespace IT008_DoAnCuoiKi.Data.Models
{
    public class AlbumsItem : BaseModel
    {
        public string album_type { get; set; }
        public List<ArtistItem> artists { get; set; }
        public List<string> available_markets { get; set; }
        public string release_date { get; set; }
        public string release_date_precision { get; set; }
        public int total_tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }

    }
    public class MAlbums : BaseSearch
    {
        public List<AlbumsItem> items { get; set; }
    }
}
