using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public string customerId { get; set; }
        public int TourId { get; set; }
        public int PaymentId { get; set; }
        public User customer { get; set; }
        public Tour tour { get; set; }
        public DateTime placed_at { get; set; }
        public string state { get; set; }
    }
}
