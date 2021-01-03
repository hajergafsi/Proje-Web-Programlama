using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Proje.Models
{
    public class Country
    {
        [Key]
        [Required(ErrorMessage ="Country code is required ")]
        [MaxLength(3,ErrorMessage ="must be 3 characters")]
        [MinLength(3, ErrorMessage = "must be 3 characters")]
        public string CountryCode { get; set; }
        [Required(ErrorMessage = "Country name is required ")]
        public string Name { get; set; }
    }
}
