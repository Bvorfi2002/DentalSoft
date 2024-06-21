using System.ComponentModel.DataAnnotations;

namespace DentalServer.Models
{
    public class Patient
    {
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }
        public int FileID { get; set; }
        public string[] Pictures { get; set; }
        public History History { get; set; }
        public MedicalForm MedicalForm { get; set; }
    }
}
