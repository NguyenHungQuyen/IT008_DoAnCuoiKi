using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IT008_DoAnCuoiKi.Data.Models.MSearch;

namespace IT008_DoAnCuoiKi.Data.Models
{
    public class SpotifyResult
    {
        public MArtists artists { get; set; }
        public MTracks tracks { get; set; }
        public MAlbums albums { get; set; }
        public MPlaylists playlists { get; set; }
        public MCategory categories { get; set; }
    }
}
