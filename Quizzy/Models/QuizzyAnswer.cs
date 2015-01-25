/*
 * Represents the option selected by the user in response to a quiz question
 */
namespace Quizzy.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

    public class QuizzyAnswer
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [ForeignKey("QuizzyOption"), Column(Order = 1)]
        public int OptionId { get; set; }

        [ForeignKey("QuizzyOption"), Column(Order = 0)]
        public int QuestionId { get; set; }

        [JsonIgnore]
        public virtual QuizzyOption QuizzyOption { get; set; }
    }
}