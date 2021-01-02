using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public int TourId { get; set; }
        public Tour tour { get; set; }
        public string CountryCode { get; set; }
        [Display(Name = "CityName")]
        public string name { get; set; }   
        public string description { get; set; }
        public string photoUrl { get; set; }
    }
}
