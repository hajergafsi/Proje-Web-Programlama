using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace Proje.Models
{
    public class Counts 
    {
        [Display(Name ="Cities")]
        public int CityCount {get;set;}
        [Display(Name = "Countries")]
        public int CountryCount { get; set; }
        [Display(Name = "Tours")]
        public int TourCount { get; set; }
        public Counts(int cc1,int cc2,int ct)
        {
            CityCount = cc1;
            CountryCount = cc2;
            TourCount = ct;
        }

    }
}
