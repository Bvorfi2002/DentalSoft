namespace DentalServer.Models
{
    public class Service
    {
        public int PatientId { get; set; }
        public int ServiceId { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
        public ProdUsage ProdUsage { get; set; }
    }
}