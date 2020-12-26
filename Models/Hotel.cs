using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int CityID { get; set; }
        public City city { get; set; }
        public int TourId { get; set; }
        public Tour tour { get; set; }
    }
}
