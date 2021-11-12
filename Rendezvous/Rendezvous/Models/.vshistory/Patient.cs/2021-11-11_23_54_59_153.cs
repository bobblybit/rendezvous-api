using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rendezvous.Models
{
    public class Patient : BaseEntity
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string InsurerName { get; set; }
        public string InsuranceNumber { get; set; }
        public string MaritalStatus { get; set; }
        public EmergencyContact EmergencyContact { get; set; }
        public Appointment Appointment { get; set; }
        public string DateOfBirth { get; set; }
    }
}
