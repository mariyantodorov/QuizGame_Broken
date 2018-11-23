using QuizApp.Domain.Models.Questions;

namespace QuizApp.Domain.Models.Answers
{
    public class Answer
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public bool IsCorrect { get; set; }

        public virtual Question Question { get; set; }
    }
}
