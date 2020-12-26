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
        public string CountryCode { get; set; }
        public string Name { get; set; }
    }
}
