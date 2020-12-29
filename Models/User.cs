using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class User : IdentityUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Identity Number")]
        public string IdentityNumber { get; set; }
        public Role role { get; set; }
    }
}
