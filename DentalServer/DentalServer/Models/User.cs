namespace DentalServer.Models
{
    public class User
    {

        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public Guid PaymentDataId { get; set; }
        public PaymentData PaymentData { get; set; }

        public Guid ClinicId { get; set; }
        public Clinic Clinic { get; set; }


    }
}
