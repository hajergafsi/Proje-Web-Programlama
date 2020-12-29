using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class Tour
    {
        [Key]
        public int TourId { get; set; }
        [Display(Name = "Tour Name")]
        public string name { get; set; }
        [Display(Name = "Country")]
        public Country country { get; set; }
        public string Icon { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Tour starting date")]
        public DateTime startDate { get; set; }
        [Display(Name = "Tour ending date")]
        public DateTime endDate { get; set; }
        [Display(Name = "Tour duration")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Duration { get; set; }
        public string image { get; set; }
        [Display(Name = "Tour cost")]
        public double cost { get; set; }
    }
}
