using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public enum Result { Win, Draw, Loss}
    public class Team: IComparable
    {
        public string Name { get; set; }
        public int NumWins { get; set; }
        public int NumDraws { get; set; }
        public int NumLoss { get; set; }
        public int NumGames { get; set; }

        private int points;

        public int Points
        {
            get
            {
                points = (NumWins * 3) + (NumDraws * 1);
                return points;
            }
        }

        public List<Player> Players { get; set; }

        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
        }

        public string DisplayTeamTable()
        {
            return ($"{Name,-15}{Points,-7}{NumWins,-7}{NumDraws,-7}{NumLoss,-7}{NumGames,-7}");
        }

        public void AddResult(Result result)
        {
            NumGames++;
            switch (result)
            {
                case Result.Win:
                    NumWins++;
                    break;

                case Result.Loss:
                    NumLoss++;
                    break;

                case Result.Draw:
                    NumDraws++;
                    break;
            }
            
           

        }

        public int CompareTo(object obj)
        {
            Team that = (Team)obj;
            return points.CompareTo(that.Points);
        }
    }
}
