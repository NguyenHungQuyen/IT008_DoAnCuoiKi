using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT008_DoAnCuoiKi.Data.Models
{
    public class BrowseResult
    {
        public MAlbums albums { get; set; }
        public MPlaylists playlists { get; set; }
        public MCategory categories { get; set; }
    }
}
