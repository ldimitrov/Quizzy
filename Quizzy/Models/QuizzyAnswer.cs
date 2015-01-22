// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
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
        public virtual QuizzyOption TriviaOption { get; set; }
    }
}