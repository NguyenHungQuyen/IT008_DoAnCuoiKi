using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT008_DoAnCuoiKi.Data.Models
{
    public class CategoryItem
    {
        public List<Icons> icons { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string href { get; set; }
    }
    
    public class MCategory : BaseSearch
    {
        public List<CategoryItem> items { get; set; }
    }
}
