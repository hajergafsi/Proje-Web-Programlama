using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class CreditCard
    {
        [Key]
        public int CardId { get; set; }
        [Required(ErrorMessage = "number is required")]
        [MaxLength(16, ErrorMessage = "must be 16 characters")]
        [MinLength(16, ErrorMessage = "must be 16 characters")]
        [RegularExpression("^[0-9]*$",ErrorMessage ="Please enter only numbers")]
        [Display(Name = "number")]
        public string number { get; set; }
        [MaxLength(3, ErrorMessage = "must be 3 characters")]
        [MinLength(3, ErrorMessage = "must be 3 characters")]
        [Required(ErrorMessage = "CVV is required")]
        public string CVV { get; set; }
        [Display(Name = "Expiration Date")]
        [Required(ErrorMessage = "Expiration Date is required")]
        public DateTime ExpirationDate { get; set; }
    }
}
