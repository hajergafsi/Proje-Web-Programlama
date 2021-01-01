using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class InstaPost
    {
        [Key]
        public int photoId { get; set; }
        public string photoUrl { get; set; }
    }
}
