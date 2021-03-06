using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Pass { get; set; }
        public int Phone { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public UserRoles Role { get; set; }
    }
}
