using DentalServer.Models;

public class AppointmentResultServices
{
    public Guid AppointmentResultId { get; set; }
    public required AppointmentResult AppointmentResult { get; set; }
    public Guid ServiceId { get; set; }
    public required Service Service { get; set; }
}
