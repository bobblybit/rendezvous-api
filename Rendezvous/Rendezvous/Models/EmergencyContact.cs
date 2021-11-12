using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rendezvous.Models
{
    public class EmergencyContact : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Relationship { get; set; }
        public AppUser User { get; set; }
        public string UserId { get; set; }
    }
}
