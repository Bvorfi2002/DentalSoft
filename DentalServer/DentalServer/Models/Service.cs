namespace DentalServer.Models
{
    public class Service
    {
        public Guid ServiceId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public IList<ProdUsage> ProdUsage { get; set; }
    }
}