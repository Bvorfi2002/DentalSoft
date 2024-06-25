using System;

namespace DentalServer.Models
{
    public class Invoice
    {

        public string Type { get; set; }
        public string Description { get; set; }
        public double TotalAmount { get; set; }
        public DateTime Date { get; set; } = DateTime.now
        public Clinic Clinic { get; set; }
        public Guid ClinicId { get; set; }
    }
}
