using DataDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LeaderboardDataAccessor
    {
        // Retrieve the List of Leaderboard Data.
        public List<QuizLeaderboard> RetrieveLeaderboard(string leaderboardFileName)
        {
            List<QuizLeaderboard> leaderboard = new List<QuizLeaderboard>();
            char[] separator = { ',' };
            using (StreamReader reader = new StreamReader(AppData.DataPath + leaderboardFileName))
            {
                reader.ReadLine();
                while(reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    string[] parts;

                    // Line needs to be greater than 5 characters, so users may put a
                    // single letter/character as their first &/or last names.
                    //      5 characters because they will have a Place (1 character), First Name (at least 1 character),
                    //      Last Name (at least 1 character), a Score (1 character), & a Date Achieved (at least 9 characters).
                    if(line.Length > 5)
                    {
                        parts = line.Split(separator);
                        if(parts.Count() == 4)
                        {
                            QuizLeaderboard quizLeaderboard = new QuizLeaderboard();
                            try
                            {
                                quizLeaderboard.Place = int.Parse(parts[0]);
                            }
                            catch(Exception ex)
                            {
                                // Nothing specific, as parsing should work.
                            }
                            quizLeaderboard.PlayerName = parts[1];
                            try
                            {
                                quizLeaderboard.PlayerScore = int.Parse(parts[2]);
                            }
                            catch (Exception ex)
                            {
                                // Nothing specific, as parsing should work.
                            }
                            try
                            {
                                quizLeaderboard.DateAchieved = DateOnly.FromDateTime(DateTime.Parse(parts[3]));
                            }
                            catch (Exception ex)
                            {
                                // Nothing specific, as parsing should work.
                            }
                            leaderboard.Add(quizLeaderboard);
                        }
                    }
                }
            }
            return leaderboard;
        }

        // Upate a player's record in the current leaderboard.
        public bool SaveLeaderboard(string leaderboardFileName, QuizLeaderboard currentPlayerRecord, string newPlayerName)
        {
            bool isSaved = false;
            try
            {
                updateLeaderboard(leaderboardFileName, currentPlayerRecord, newPlayerName);
                isSaved = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isSaved;
        }
        // Update the current leaderboard.
        private void updateLeaderboard(string leaderboardFileName, QuizLeaderboard currentPlayerRecord, string newPlayerName)
        {
            // Get the current Leaderboard.
            List<QuizLeaderboard> currentLeaderboard = RetrieveLeaderboard(leaderboardFileName);

            // Find the current record.
            for(int i = 0; i < currentLeaderboard.Count; i++)
            {
                if((currentLeaderboard[i].Place == currentPlayerRecord.Place) && (currentLeaderboard[i].PlayerName == currentPlayerRecord.PlayerName))
                {
                    currentLeaderboard[i].PlayerName = newPlayerName;
                }
            }

            // Update the leaderboard.
            writeLeaderboard(leaderboardFileName, currentLeaderboard);

        }

        // Overwrite the specified leaderboard.
        public bool SaveLeaderboard(string leaderboardFileName, List<QuizLeaderboard> leaderboard)
        {
            bool isSaved = false;
            try
            {
                writeLeaderboard(leaderboardFileName, leaderboard);
                isSaved = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isSaved;
        }
        // Overwrite a leaderboard.
        private void writeLeaderboard(string leaderboardFileName, List<QuizLeaderboard> leaderboard)
        {
            using(StreamWriter writer = new StreamWriter(AppData.DataPath + leaderboardFileName))
            {
                writer.WriteLine("Place,Player Name,Player Score,Date Achieved");
                foreach(QuizLeaderboard record in leaderboard)
                {
                    writer.WriteLine(record.Place.ToString() + "," +
                                        record.PlayerName + "," +
                                        record.PlayerScore.ToString() + "," +
                                        record.DateAchieved.ToString());
                }
            }
            return;
        }

        // Delete a record from a leaderboard.
        public bool DeleteLeaderboardRecord(string leaderboardFileName, QuizLeaderboard selectedRecord)
        {
            bool isDeleted = false;
            try
            {
                deleteRecord(leaderboardFileName, selectedRecord);

                isDeleted = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isDeleted;
        }
        private void deleteRecord(string leaderboardFileName, QuizLeaderboard selectedRecord)
        {
            // Get the associated Leaderboard.
            List<QuizLeaderboard> leaderboard = RetrieveLeaderboard(leaderboardFileName);

            // Find the record.
            for (int i = 0; i < leaderboard.Count; i++)
            {
                if(leaderboard[i].Place == selectedRecord.Place)
                {
                    // Remove the record from the leaderboard.
                    leaderboard.Remove(leaderboard[i]);

                    break;
                }
            }

            // Sort the leaderboard based on the PlayerScore field.
            leaderboard = leaderboard.OrderByDescending(r => r.PlayerScore).ToList();

            // Reset the Place field of each record.
            for (int i = 0; i < leaderboard.Count; i++)
            {
                leaderboard[i].Place = i + 1;
            }

            // Rewrite the file without the removed record.
            writeLeaderboard(leaderboardFileName, leaderboard);
        }

    }
}