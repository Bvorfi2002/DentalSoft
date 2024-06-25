using System;

namespace DentalServer.Models
{
    public class BuyingBill
    {

        public Guid BuyingBillId { get; set; }
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
        public Supplier Supplier { get; set; }
        public Guid SupplierId { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public Clinic Clinic { get; set; }
        public Guid ClinicId { get; set; }

    }
}
