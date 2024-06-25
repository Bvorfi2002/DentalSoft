using System;

namespace DentalServer.Models
{
    public class Bill
    {
        public Guid BillId { get; set; }
        public Clinic Clinic { get; set; }
        public Guid ClinicId { get; set; }
        public DateTime date { get; set; }
        public string QrLink { get; set; }
        public Patient Patient { get; set; }
        public Guid PatientId { get; set; }
        public AppointmentResult Appointment { get; set; }
        public Guid AppointmentResultId { get; set; }
        public double Amount { get; set; }

        public Bill()
        {
            date = DateTime.Now;
            Amount = calculateAmount(appointment);
        }

        private double calculateAmount(AppointmentResult appointment)
        {
            IList<AppointmentResultServices> services = appointment.Services;
            double amount = 0;
            for (int i = 0; i < services.Count; i++)
            {
                amount += services[i].Service.Price;
            }
            return amount;
        }
    }
}
