using System;


namespace DentalServer.Models
{
    public class Appointment
    {
        public Guid AppointmentId { get; set; }
        public Clinic Clinic { get; set; }
        public Guid ClinicId { get; set; }
        public DateTime Date { get; set; }
        public Patient Patient { get; set; }
        public Guid PatientId { get; set; }
        public Doctor Doctor { get; set; }
        public Guid DoctorId { get; set; }
        public IList<AppointmentServices> Services { get; set; }

        public Appointment()
        {
        }
    }
}
