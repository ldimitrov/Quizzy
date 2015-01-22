/*
 * The implementation of the Entity Framework initializer for the QuizzyContext class
 * which inherits from CreateDatabaseIfNotExists. The default behavior of this class 
 * is to create the database only if it does not exist, inserting the entities specified
 * in the Seed method.
 */
namespace Quizzy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    public class QuizzyDatabaseInitializer : CreateDatabaseIfNotExists<QuizzyContext>
    {
        protected override void Seed(QuizzyContext context)
        {
            base.Seed(context);

            var questions = new List<QuizzyQuestion>();

            questions.Add(new QuizzyQuestion
            {
                Title = "Which country won the first world cup in 1930?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Uruguay", IsCorrect = true },
                    new QuizzyOption { Title = "Chile", IsCorrect = false },
                    new QuizzyOption { Title = "Brazil", IsCorrect = false },
                    new QuizzyOption { Title = "England", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "England's World Cup debut came in 1950, where they suffered an infamous 1-0 defeat by which nation?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Japan", IsCorrect = false },
                    new QuizzyOption { Title = "France", IsCorrect = false },
                    new QuizzyOption { Title = "Germany", IsCorrect = false },
                    new QuizzyOption { Title = "USA", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "What nationality was Carlos Caszely who received the first ever World Cup red card in 1974?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Spanish", IsCorrect = false },
                    new QuizzyOption { Title = "Brazilian", IsCorrect = false },
                    new QuizzyOption { Title = "Chilean", IsCorrect = true },
                    new QuizzyOption { Title = "Argentinian", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Which football player is famous for his 1986 'Hand of God'?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Gary Lineker", IsCorrect = false },
                    new QuizzyOption { Title = "Jorge Valdano", IsCorrect = false },
                    new QuizzyOption { Title = "Diego Maradona", IsCorrect = true },
                    new QuizzyOption { Title = "Lothar Matthäus", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "True or False. Referees are allowed to stop games in Brazil 2014 due to hot weather?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "True", IsCorrect = true },
                    new QuizzyOption { Title = "False", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "In 2002, which country became the first semi-finalists from outside Europe and the Americas?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Ivory Coast", IsCorrect = false },
                    new QuizzyOption { Title = "South Korea", IsCorrect = true },
                    new QuizzyOption { Title = "Japan", IsCorrect = false },
                    new QuizzyOption { Title = "Mexico", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Who is the only player to score a hat-trick in a World Cup Final?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Leonel Messi", IsCorrect = false },
                    new QuizzyOption { Title = "Diego Maradona", IsCorrect = false },
                    new QuizzyOption { Title = "Geoff Hurst", IsCorrect = true },
                    new QuizzyOption { Title = "Miroslav Klose", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Which team has demanded a jacuzzi in every room for their 2014 visit to in Brazil?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Sweden", IsCorrect = false },
                    new QuizzyOption { Title = "Japan", IsCorrect = true },
                    new QuizzyOption { Title = "Norway", IsCorrect = false },
                    new QuizzyOption { Title = "Finland", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Which English goalkeeper has kept 10 clean sheets in World Cup games?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Peter Shilton", IsCorrect = true },
                    new QuizzyOption { Title = "Joe Hart", IsCorrect = false },
                    new QuizzyOption { Title = "Ray Clemence", IsCorrect = false },
                    new QuizzyOption { Title = "Nigel Martyn", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Which country beat South Korea 9-0 in 1954, and El Salvador 10-1 in 1982?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Hungary", IsCorrect = true },
                    new QuizzyOption { Title = "Netherlands", IsCorrect = false },
                    new QuizzyOption { Title = "Germany", IsCorrect = false },
                    new QuizzyOption { Title = "Brazil", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Which German won the World Cup as both a player and a manager?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Franz Beckenbauer", IsCorrect = true },
                    new QuizzyOption { Title = "Lothar Matthäus", IsCorrect = false },
                    new QuizzyOption { Title = "Joachim Löw", IsCorrect = false },
                    new QuizzyOption { Title = "Gerd Müller", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Which French player has picked up four yellows and two red cards in three world cups?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Lilian Thuram", IsCorrect = false },
                    new QuizzyOption { Title = "Thierry Henry", IsCorrect = false },
                    new QuizzyOption { Title = "Didier Deschamps", IsCorrect = false },
                    new QuizzyOption { Title = "Zinedine Zidane", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "How many countries have hosted the world cup twice?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Four", IsCorrect = false },
                    new QuizzyOption { Title = "Six", IsCorrect = false },
                    new QuizzyOption { Title = "Five", IsCorrect = true },
                    new QuizzyOption { Title = "Three", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Which Manchester United player became the youngest player in world cup history in 1982?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Rayan Giggs", IsCorrect = false },
                    new QuizzyOption { Title = "Paul Scholes", IsCorrect = false },
                    new QuizzyOption { Title = "Norman Whiteside", IsCorrect = true },
                    new QuizzyOption { Title = "Eric Cantona", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "In which country was the 1978 tournament held?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Argentina", IsCorrect = true },
                    new QuizzyOption { Title = "Brazil", IsCorrect = false },
                    new QuizzyOption { Title = "USA", IsCorrect = false },
                    new QuizzyOption { Title = "England", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Which country lost in both the 1974 and 1978 finals?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Uroguay", IsCorrect = false },
                    new QuizzyOption { Title = "Argentina", IsCorrect = false },
                    new QuizzyOption { Title = "Spain", IsCorrect = false },
                    new QuizzyOption { Title = "Holland", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Name the only footballer to have played for Everton, Liverpool, Manchester City and Manchester United?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Wayne Rooney", IsCorrect = false },
                    new QuizzyOption { Title = "Peter Beardsley", IsCorrect = true },
                    new QuizzyOption { Title = "Jimmy Greaves", IsCorrect = false },
                    new QuizzyOption { Title = "Ron Atkinson", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Which club did Sir Alex Ferguson call 'a small club, with a small mentality' in 2009?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Manchester City", IsCorrect = true },
                    new QuizzyOption { Title = "Liverpool", IsCorrect = false },
                    new QuizzyOption { Title = "Arsenal", IsCorrect = false },
                    new QuizzyOption { Title = "Chelsea", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "How many Premier League titles have Arsenal won?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "11", IsCorrect = false },
                    new QuizzyOption { Title = "6", IsCorrect = false },
                    new QuizzyOption { Title = "1", IsCorrect = false },
                    new QuizzyOption { Title = "3", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new QuizzyQuestion
            {
                Title = "Who is the English Premier League's all time leading goal scorer?",
                Options = (new QuizzyOption[]
                {
                    new QuizzyOption { Title = "Thierry Henry", IsCorrect = false },
                    new QuizzyOption { Title = "Wayne Rooney", IsCorrect = false },
                    new QuizzyOption { Title = "Andy Cole", IsCorrect = false },
                    new QuizzyOption { Title = "Alan Shearer", IsCorrect = true }
                }).ToList()
            });
            
            questions.ForEach(a => context.QuizzyQuestions.Add(a));

            context.SaveChanges();
        }
    }
}