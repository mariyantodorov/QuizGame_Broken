using QuizApp.Domain.Models.Categories;

namespace QuizApp.Domain.Models.Achievements
{
    public class Achievement
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Milestone { get; set; }

        public int RewardPoints { get; set; }

        public bool IsUnlocked { get; set; }

        public Category Category { get; set; }
    }
}
