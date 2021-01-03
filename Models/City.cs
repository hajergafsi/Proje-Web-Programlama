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
        [Required(ErrorMessage = "this field is required")]
        public int TourId { get; set; }
        public Tour tour { get; set; }
        [Required(ErrorMessage ="this field is required")]
        [Display(Name = "Country")]
        public string CountryCode { get; set; }
        [Display(Name = "City Name")]
        [Required(ErrorMessage = "this field is required")]
        public string name { get; set; }   
        public string description { get; set; }
        public string photoUrl { get; set; }
    }
}
