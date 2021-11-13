using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JwtDotNet5Api.Models
{
    public class ApplicationUser:IdentityUser
    {

        [Required, MaxLength(50)]
        public string firstName { get; set; }

        [Required, MaxLength(50)]
        public string lastName { get; set; }
    }
}
