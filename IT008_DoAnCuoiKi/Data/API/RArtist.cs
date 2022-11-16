using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT008_DoAnCuoiKi.Data.API
{
    internal class RArtist
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Int64 Followers { get; set; }
        public string ArtistImage { get; set; }
        public string External_Url { get; set; }
        public List<string> Genres { get; set; }
        public string Type { get; set; }
        public int Popularity { get; set; }
        public string Href { get; set; }
    }
}
