namespace DentalServer.Models
{
    public class MedicalForm
    {
        public Clinic Clinic { get; set; }
        public Guid ClinicId { get; set; }
        public IList<Question> Questions { get; set; }

    }
}