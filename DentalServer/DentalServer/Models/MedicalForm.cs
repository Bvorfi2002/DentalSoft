namespace DentalServer.Models
{
    public class MedicalForm
    {
        public int ClinicId { get; set; }
        public Question[] Questions { get; set; }

    }
}