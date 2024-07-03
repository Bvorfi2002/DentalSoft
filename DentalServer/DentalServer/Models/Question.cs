namespace DentalServer.Models
{
    public class Question
    {

        public Guid MedicalFormId { get; set; }
        public Guid QuestionId { get; set; }
        public string QuestionType { get; set; }
        public string QuestionText { get; set; }
        public string QuestionAnswer { get; set; }

    }
}