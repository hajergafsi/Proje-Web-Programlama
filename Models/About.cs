using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class About
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        [Display(Name ="Local Calls")]
        public string number { get; set; }
        [Display(Name = "International Calls")]
        public string intNumber { get; set; }
        [Display(Name = "E-mail Address")]
        public string email { get; set; }
        public string description { get; set; }
        [Display(Name = "Main Office Address")]
        public string address { get; set; }
    }
}
