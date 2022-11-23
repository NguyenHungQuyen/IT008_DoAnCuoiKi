using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IT008_DoAnCuoiKi.Data.Models.MSearch;

namespace IT008_DoAnCuoiKi.Data.Models
{
    public class ArtistItem : BaseModel
    {
        public Followers followers { get; set; }
        public List<string> genres { get; set; }
        public int popularity { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }
    public class MArtists : BaseSearch
    {
        public List<ArtistItem> items { get; set; }
    }

}
