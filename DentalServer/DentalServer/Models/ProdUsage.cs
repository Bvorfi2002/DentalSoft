namespace DentalServer.Models
{
    public class ProdUsage
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        public int Quantity { get; set; }
    }
}