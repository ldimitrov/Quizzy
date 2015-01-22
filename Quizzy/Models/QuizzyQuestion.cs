/*
 * Represents a quiz question and exposes the associated options through the Options property
 */
namespace Quizzy.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class QuizzyQuestion
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public virtual List<QuizzyOption> Options { get; set; }
    }
}