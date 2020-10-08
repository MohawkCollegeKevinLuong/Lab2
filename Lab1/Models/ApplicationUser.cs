using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class ApplicationUser : IdentityUser
    {
        /*
        [Required, EmailAddress]
        public string Email { get; set; }
        */

        [Required, Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required, Display(Name = "LastName")]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public string BirthDate { get; set; }


    }
}
