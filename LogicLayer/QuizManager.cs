using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDomain;
using DataAccessLayer;

namespace LogicLayer
{
    public class QuizManager
    {
        private QuizDataAccessor _quizDataAccessor = new QuizDataAccessor();

        // Get the List of Quizzes.
        public List<QuizList> GetQuizList()
        {
            List<QuizList> quizzes = null;
            try
            {
                quizzes = _quizDataAccessor.RetrieveQuizList();
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Quiz List Data Not Available.", ex);
            }
            return quizzes;
        }

        // Get the Quiz To Take.
        public List<QuizQuestion> GetQuizToTake(string fileName)
        {
            List<QuizQuestion> quizToTake = null;
            try
            {
                quizToTake = _quizDataAccessor.RetrieveQuizToTake(fileName);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Quiz Data Not Available.", ex);
            }
            return quizToTake;
        }
    }
}