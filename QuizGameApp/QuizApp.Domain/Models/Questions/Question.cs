using QuizApp.Domain.Models.Answers;
using QuizApp.Domain.Models.Categories;
using QuizApp.Domain.Models.Levels;
using System.Collections.Generic;

namespace QuizApp.Domain.Models.Questions
{
    public class Question
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public QuestionDifficulty Difficulty { get; set; }

        public virtual Category Category { get; set; }

        public virtual Answer[] Answers { get; set; }

        public virtual IEnumerable<Level> Levels { get; set; }

        public bool IsAnswered { get; set; }

        //add collection of users who liked the question
    }
}
