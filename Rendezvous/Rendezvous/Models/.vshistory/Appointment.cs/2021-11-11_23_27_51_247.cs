using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rendezvous.Models
{
    public class Appointment
    {
        public string PatientId { get; set; }
        public string DoctorId { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}
