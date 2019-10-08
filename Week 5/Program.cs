using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            Team Arsenal = new Team("Arsenal");
            Team Liverpool = new Team("Liverpool");
            Team Everton = new Team("Everton");
            Team Barcelona = new Team("Barcelona");

            teams.Add(Arsenal);
            teams.Add(Liverpool);
            teams.Add(Everton);
            teams.Add(Barcelona);

            Display(teams);

            Arsenal.AddResult(Result.Win);
            Liverpool.AddResult(Result.Draw);
            Everton.AddResult(Result.Loss);
            Barcelona.AddResult(Result.Win);

            Display(teams);

            teams.Sort();
            
            Display(teams);

            teams.Reverse();

            Display(teams);

            Arsenal.Players.Add(new Player() { Name = "Ed McGinty", Position = "Goalkeeper" });
            Arsenal.Players.Add(new Player() { Name = "John Mahon", Position = "Defender" });
            Arsenal.Players.Add(new Player() { Name = "Ronan Coughlan", Position = "Forward" });

            Console.WriteLine("\nArsenal Teamsheet");
            foreach(Player player in Arsenal.Players)
            {
                
                Console.WriteLine(player);
            }
        }
        static void Display(List<Team> teams)
        {
            Console.WriteLine("{0, -15}{1, -7}{2, -7}{3, -7}{4,-7}{5, -7}", "Name", "Points", "Wins", "Draws", "Losses", "Played");

            foreach (Team team in teams)
            {
                Console.WriteLine(team.DisplayTeamTable());
            }
        }


    }
}
