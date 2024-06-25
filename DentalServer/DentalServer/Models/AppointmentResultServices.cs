using System;

public class AppointmentResultServices
{
    public AppointmentResultServices()
    {

        public Guid AppointmentResultId { get; set; }
        public AppointmentResult AppointmentResult { get; set; }
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
}
}
