namespace DentalServer.Models
{
    public class PaymentData
    {

        public Guid PaymentDataId { get; set; }
        public string PaymentType { get; set; }
        public double PaymentRate   { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
