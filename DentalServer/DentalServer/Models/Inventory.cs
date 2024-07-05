namespace DentalServer.Models
{
    public class Inventory
    {
        public Guid InventoryId { get; set; }
        public IList<Product> Products { get; set; }
        public Clinic Clinic { get; set; }
        public Guid ClinicId { get; set; }

        public Inventory()
        {
            Products = new List<Product>();
        }
    }
}
