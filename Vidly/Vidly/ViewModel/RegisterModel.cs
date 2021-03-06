using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.ViewModel
{
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Display(Name = "Password")]
        [Required]
        public string Pass { get; set; }
        [Display(Name="Confirm Password")]
        [Compare(nameof(Pass), ErrorMessage = "Passwords do not match")]
        public string ConfirmPass { get; set; }
        [Display(Name = "Phone Number")]
        public int Phone { get; set; }
        
    }
}
