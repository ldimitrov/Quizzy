using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Quizzy.Models;

namespace Quizzy.Controllers
{
    [Authorize]
    public class QuizzyController : ApiController
    {
        private QuizzyContext db = new QuizzyContext();

        /*
         * The Dispose method of QuizzyController invokes the Dispose method of the QuizzyContext instance, 
         * which ensures that all the resources used by the context object are released when the QuizzyContext
         * instance is disposed or garbage-collected. This includes closing all database connections opened 
         * by Entity Framework. 
         */
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }

        /*
         * This method retrieves the following quiz question from the database to be answered by the specified user.
         *          
         */
        private async Task<QuizzyQuestion> NextQuestionAsync(string userId)
        {
            var lastQuestionId = await this.db.QuizzyAnswers
                .Where(w => w.UserId == userId)
                .GroupBy(g => g.QuestionId)
                .Select(s => new { QuestionId = s.Key, Count = s.Count() })
                .OrderByDescending(o => new { o.Count, QuestionId = o.QuestionId })
                .Select(q => q.QuestionId)
                .FirstOrDefaultAsync();

            var questionCount = await this.db.QuizzyQuestions.CountAsync();

            var nextQuestionid = (lastQuestionId % questionCount) + 1;

            return await this.db.QuizzyQuestions.FindAsync(CancellationToken.None, nextQuestionid);
        }

        // GET api/Quizzy
        [ResponseType(typeof(QuizzyQuestion))]
        public async Task<IHttpActionResult> Get()
        {
            var userId = User.Identity.Name;

            QuizzyQuestion nextQuestion = await this.NextQuestionAsync(userId);

            if (nextQuestion == null)
            {
                return this.NotFound();
            }
            return this.Ok(nextQuestion);
        }

        /*
         * This method stores the specified answer in the database and returns a Boolean 
         * value indicating whether or not the answer is correct.
         */
        private async Task<bool> StoreAsync(QuizzyAnswer answer)
        {
            this.db.QuizzyAnswers.Add(answer);

            await this.db.SaveChangesAsync();

            var selectedOption = await this.db.QuizzyOptions.FirstOrDefaultAsync(f => f.Id == answer.OptionId && f.QuestionId == answer.QuestionId);

            return selectedOption.IsCorrect;
        }


        /*
         * This action method associates the answer to the authenticated user and calls the 
         * StoreAsync helper method. Then, it sends a response with the Boolean value 
         * returned by the helper method.
         */
        // POST api/Quizzy
        [ResponseType(typeof(QuizzyAnswer))]
        public async Task<IHttpActionResult> Post(QuizzyAnswer answer)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }
            answer.UserId = User.Identity.Name;
            var isCorrect = await this.StoreAsync(answer);
            return this.Ok<bool>(isCorrect);
        }
    }
}
