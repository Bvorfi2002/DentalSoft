using System.ComponentModel.DataAnnotations;

namespace DentalServer.Models
{
    public class Patient
    {
        public Guid PatientId { get; set; }
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }
        public int FileID { get; set; }
        public IList<Picture> Pictures { get; set; }
        public IList<History> Historic { get; set; }
        public MedicalForm MedicalForm { get; set; }
    }
}
