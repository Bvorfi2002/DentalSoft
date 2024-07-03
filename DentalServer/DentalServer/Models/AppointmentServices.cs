using DentalServer.Models;

public class AppointmentServices
{

    public Guid AppointmentId { get; set; }
    public required Appointment Appointment { get; set; }
    public Guid ServiceId { get; set; }
    public required Service Service { get; set; }
}
