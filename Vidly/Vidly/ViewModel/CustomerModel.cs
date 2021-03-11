using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class CustomerModel
    {
        public int? Id { get; set; }
        [Required]
        public String Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public DateTime? Birthday { get; set; }
        public int MemberShip { get; set; }
        public IEnumerable<MemberShipTypes> MemberShipType { get; set; }
    }
}
