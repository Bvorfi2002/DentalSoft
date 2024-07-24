namespace DentalServer.DTOs
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public Guid PaymentDataId { get; set; }
        public Guid ClinicId { get; set; }
    }

    public class CreateUserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public Guid PaymentDataId { get; set; }
        public Guid ClinicId { get; set; }
    }

    public class UpdateUserDto
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public Guid PaymentDataId { get; set; }
        public Guid ClinicId { get; set; }
    }

    public class PaymentDataDto
    {
        public Guid PaymentDataId { get; set; }
        public string PaymentType { get; set; }
        public double PaymentRate { get; set; }
    }
}
