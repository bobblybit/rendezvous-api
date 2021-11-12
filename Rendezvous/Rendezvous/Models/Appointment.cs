using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rendezvous.Models
{
    public class Appointment
    {
        public AppUser User { get; set; }
        public string UserId { get; set; }
        public string AppointmentID { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}
