/*
 * Represents a single option associated with a quiz question 
 */
namespace Quizzy.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

    public class QuizzyOption
    {
        [Key, Column(Order = 1), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Key, Column(Order = 0), ForeignKey("QuizzyQuestion")]
        public int QuestionId { get; set; }

        [JsonIgnore]
        public virtual QuizzyQuestion QuizzyQuestion { get; set; }

        [JsonIgnore]
        public bool IsCorrect { get; set; }
    }
}