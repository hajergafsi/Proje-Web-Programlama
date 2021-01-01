using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class Activities
    {
        [Key]
        public int ativityId {get;set;}
        public string title { get; set; }
        public int TourId { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
    }
}
