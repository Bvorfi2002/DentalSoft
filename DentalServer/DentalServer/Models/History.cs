namespace DentalServer.Models
{
    public class History
    {
        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
    }
}