using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthPlusSport.Shared.Models
{
    public class UserRegister
    {
        public string UserModelId { get; set; }
        public string Username { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public string Address { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
