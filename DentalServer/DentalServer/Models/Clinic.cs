using System;

namespace DentalServer.Models
{
    public class Clinic
    {
        public Guid ClinicId { get; set; }
        public string ClinicName { get; set; }
        public Inventory inventory { get; set; }
        public IList<Supplier> suppliers { get; set; }
        public IList<Bill> bills { get; set; }
        public IList<BuyingBill> buyingBills { get; set; }
        public IList<User> Users { get; set; }

        public Clinic()
        {
            inventory = new Inventory() { Clinic = this };
            suppliers = new List<Supplier>();
            bills = new List<Bill>();
            buyingBills = new List<BuyingBill>();
        }
    }
}
