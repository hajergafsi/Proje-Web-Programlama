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
        [Display(Name = "TourName")]
        public string name { get; set; }
        [Display(Name = "Country")]
        public Country country { get; set; }
        public string Icon { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "TourStartingDate")]
        public DateTime startDate { get; set; }
        [Display(Name = "TourEndingDate")]
        public DateTime endDate { get; set; }
        [Display(Name = "TourDuration")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Duration { get; set; }
        public string image { get; set; }
        [Display(Name = "TourCost")]
        public double cost { get; set; }
    }
}
