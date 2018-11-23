using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace QuizApp.Infrastructure.Data
{
    public class QuizAppDbContext : IdentityDbContext
    {
        public QuizAppDbContext(DbContextOptions<QuizAppDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
