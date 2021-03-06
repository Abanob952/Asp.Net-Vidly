using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vidly.ValidationFilter;

namespace Vidly.ViewModel
{
    public class LoginModel
    {
        
        [Required]
        [EmailExists]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Url { get; set; }
    }
}
