using QuizApp.Domain.Models.Categories;
using QuizApp.Domain.Models.Questions;
using System.Collections.Generic;

namespace QuizApp.Domain.Models.Levels
{
    public class Level
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Category Category { get; set; }

        public virtual IEnumerable<Question> Questions { get; set; }

        public int CorrectAnswersCount { get; set; }

        public int QuesttionsCount { get; set; }

        public bool IsUnlocked { get; set; }

        public bool IsCompleted { get; set; }
    }
}
