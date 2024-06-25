using System;

public class AppointmentServices
{
	public AppointmentServices()
	{
		public Guid AppointmentId { get; set; }
		public Appointment Appointment { get; set; }
		public Guid ServiceId { get; set; }
		public Service Service { get; set; }
	}
}
