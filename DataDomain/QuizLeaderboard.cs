using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDomain
{
    public class QuizLeaderboard
    {
        public int Place {  get; set; }
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
        public DateOnly DateAchieved { get; set; }
    }
}