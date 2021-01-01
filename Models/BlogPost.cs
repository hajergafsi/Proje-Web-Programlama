using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class BlogPost
    {
        [Key]
        public int PostId { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string image { get; set; }
        public DateTime postingDate { get; set; }
        public int likes { get; set; }
        public int comments { get; set; }
    }
}
