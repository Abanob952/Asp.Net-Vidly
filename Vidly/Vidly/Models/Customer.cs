using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public DateTime? Birthday { get; set; }
        [ForeignKey("memberShipType")]
        public int memberShipTypesId { get; set; }
        public MemberShipTypes memberShipType { get; set; }

    }
}
