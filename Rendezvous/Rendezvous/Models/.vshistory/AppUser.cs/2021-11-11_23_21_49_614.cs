using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rendezvous.Models
{
    public class AppUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Sex { get; set; }
        public string Age { get; set; }
        public Address Address { get; set; }
        public string Password { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
