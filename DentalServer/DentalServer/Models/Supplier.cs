using System;

namespace DentalServer.Models
{
    public class Supplier
    {
        public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public string Nipt { get; set; }
        public string PhoneNumber { get; set; }
    }
}
