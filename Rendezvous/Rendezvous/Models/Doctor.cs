using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rendezvous.Models
{
    public class Doctor : BaseEntity
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string Specialty { get; set; }
        public bool Availability { get; set; }
        public IList<Appointment> Appointments { get; set; }
    }
}
