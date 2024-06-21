namespace DentalServer.Models
{
    public class History
    {
        public int PatientId { get; set; }
        public Service[] Services { get; set; }

    }
}