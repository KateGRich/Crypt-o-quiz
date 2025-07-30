using DataAccessLayer;
using DataDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LeaderboardManager
    {
        private LeaderboardDataAccessor _leaderboardDataAccessor = new LeaderboardDataAccessor();

        // Get the List of Leaderboard Data.
        public List<QuizLeaderboard> GetLeaderboard(string leaderboardFileName)
        {
            List<QuizLeaderboard> leaderboard;
            try
            {
                leaderboard = _leaderboardDataAccessor.RetrieveLeaderboard(leaderboardFileName);
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Leaderboard Data Not Available.", ex);
            }

            return leaderboard;
        }

        // Update a player's record in the current Leaderboard.
        public bool SaveLeaderboard(string leaderboardFileName, QuizLeaderboard currentPlayerRecord, string newPlayerName)
        {
            bool isSaved = false;
            try
            {
                isSaved = _leaderboardDataAccessor.SaveLeaderboard(leaderboardFileName, currentPlayerRecord, newPlayerName);
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Leaderboard Save Unsuccessful.", ex);
            }
            return isSaved;
        }

        // Overwrite the Leaderboard with the new placer's record.
        public bool SaveLeaderboard(string leaderboardFileName, List<QuizLeaderboard> leaderboard)
        {
            bool isSaved = false;
            try
            {
                isSaved = _leaderboardDataAccessor.SaveLeaderboard(leaderboardFileName, leaderboard);
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Leaderboard Save Unsuccessful.", ex);
            }
            return isSaved;
        }

        // Delete a record from the leaderboard.
        public bool DeleteRecord(string leaderboardFileName, QuizLeaderboard selectedRecord)
        {
            bool isDeleted = false;
            try
            {
                isDeleted = _leaderboardDataAccessor.DeleteLeaderboardRecord(leaderboardFileName, selectedRecord);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Record Deletion Unsuccessful.", ex);
            }
            return isDeleted;
        }


        public List<QuizLeaderboard> DeterminePlace(string leaderboardFileName, QuizLeaderboard record, LeaderboardManager leaderboardManager)
        {
            // Get a copy of the current leaderboard.
            List<QuizLeaderboard> currentLeaderboard = null;
            try
            {
                currentLeaderboard = leaderboardManager.GetLeaderboard(leaderboardFileName);
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Leaderboard Data Not Available.", ex);
            }



            if(currentLeaderboard != null)
            {
                if (currentLeaderboard.Count > 0)
                {
                    // Get the record for the current player.
                    record.Place = currentLeaderboard[currentLeaderboard.Count - 1].Place + 1;
                }
                else
                {
                    record.Place = 1;
                }

                // Get a copy of the current leaderboard.
                List<QuizLeaderboard> leaderboardCopy = currentLeaderboard;

                // Add the current player's record.
                leaderboardCopy.Add(record);

                // Sort the leaderboardCopy based on the PlayerScore field.
                leaderboardCopy = leaderboardCopy.OrderByDescending(r => r.PlayerScore).ToList();

                // Reset the Place field of each record.
                for (int i = 0; i < leaderboardCopy.Count; i++)
                {
                    leaderboardCopy[i].Place = i + 1;
                }

                // Send the leaderboardCopy back.
                return leaderboardCopy;
            }

            return null;
        }
    }
}