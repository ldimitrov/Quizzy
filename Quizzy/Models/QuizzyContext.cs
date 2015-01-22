/*
 * Represents the Entity Framework's database context of the Quizzy application. 
 * This class derives from DContext and exposes DbSet properties that represent 
 * collections of the entities described above.
 */
namespace Quizzy.Models
{
    using System.Data.Entity;

    public class QuizzyContext : DbContext
    {
        public QuizzyContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<QuizzyQuestion> QuizzyQuestions { get; set; }

        public DbSet<QuizzyOption> QuizzyOptions { get; set; }

        public DbSet<QuizzyAnswer> QuizzyAnswers { get; set; }
    }
}