using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDomain;

namespace DataAccessLayer
{
    public class QuizDataAccessor
    {
        // Retrieve the List of Quizzes.
        public List<QuizList> RetrieveQuizList()
        {
            List<QuizList> quizList = new List<QuizList>();
            char[] separator = { ',' };
            using(StreamReader reader = new StreamReader(AppData.DataPath + "Quiz_List.csv"))
            {
                reader.ReadLine();
                while(reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    string[] parts;
                    if(line.Length > 20)
                    {
                        parts = line.Split(separator);
                        if(parts.Count() == 4)
                        {
                            QuizList quizzes = new QuizList();
                            quizzes.QuizName = parts[0];
                            quizzes.NumberOfQuestions = parts[1];
                            quizzes.QuizFileName = parts[2];
                            quizzes.QuizLeaderboardFileName = parts[3];
                            quizList.Add(quizzes);
                        }
                    }
                }
            }
            return quizList;
        }

        // Retrieve the Quiz To Take.
        public List<QuizQuestion> RetrieveQuizToTake(string fileName)
        {
            List<QuizQuestion> quizToTake = new List<QuizQuestion>();
            char[] separator = { '\t' };
            using (StreamReader reader = new StreamReader(AppData.DataPath + fileName))
            {
                reader.ReadLine();
                while(reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    string[] parts;
                    if(line.Length > 20)
                    {
                        parts = line.Split(separator);
                        if(parts.Count() == 6)
                        {
                            QuizQuestion quizQuestion = new QuizQuestion();
                            quizQuestion.Question = parts[0];
                            quizQuestion.Answer1 = parts[1];
                            quizQuestion.Answer2 = parts[2];
                            quizQuestion.Answer3 = parts[3];
                            quizQuestion.Answer4 = parts[4];
                            quizQuestion.CorrectAnswer = parts[5];
                            quizToTake.Add(quizQuestion);
                        }
                    }
                }
            }
            return quizToTake;
        }


    }
}