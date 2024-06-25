using System;

namespace DentalServer.Models
{
    public class AppointmentResult
    {
        public Guid AppointmentResultId { get; set; }
        public Appointment Appointment { get; set; }
        public Guid AppointmentId { get; set; }
        public string Status { get; set; }
        public Clinic Clinic { get; set; }
        public Guid ClinicId { get; set; }
        public IList<AppointmentResultServices> Services { get; set; }

        public AppointmentResult()
        {
        }
    }
}
