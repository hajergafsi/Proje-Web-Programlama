using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public int CardId { get; set; }
        [Display(Name ="Payment date")]
        public DateTime payment_date { get; set; }
        public Tour tour { get; set; }
        public CreditCard card { get; set; }
    }
}
