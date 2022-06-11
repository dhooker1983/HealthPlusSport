using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPlusSport.Shared.Models
{
    public class UserLogin
    {
        [Required, MaxLength(16)]
        public string Username { get; set; }

        [Required, MinLength(8)]
        public string Password { get; set; }
    }
}
