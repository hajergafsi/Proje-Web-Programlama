using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string Username { get; set; }
        public string text { get; set; }
        public string imageUrl { get; set; }
        public int rating { get; set; }
    }
}
