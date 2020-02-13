using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FootballTeamGenerator
{
    public class FootballTeamGenerator
    {
        public static void Main()
        {
            var listTeams = new List<Team>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] inputArgs = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (inputArgs[0])
                    {
                        case "Team":
                            var team = new Team(inputArgs[1]);
                            listTeams.Add(team);
                            break;

                        case "Add":
                            var currentTeam = listTeams.FirstOrDefault(x => x.Name == inputArgs[1]);
                            if (currentTeam == null)
                            {
                                throw new ArgumentException($"Team {inputArgs[1]} does not exist.");
                            }
                            var player = new Player(inputArgs[2], double.Parse(inputArgs[3]), double.Parse(inputArgs[4]),
                                double.Parse(inputArgs[5]), double.Parse(inputArgs[6]), double.Parse(inputArgs[7]));

                            currentTeam.AddPlayer(player);
                            break;

                        case "Remove":
                            currentTeam = listTeams.FirstOrDefault(x => x.Name == inputArgs[1]);
                            player = currentTeam.Players.FirstOrDefault(x => x.Name == inputArgs[2]);
                            currentTeam.RemovePlayer(player, inputArgs[2]);
                            break;

                        case "Rating":
                            currentTeam = listTeams.FirstOrDefault(x => x.Name == inputArgs[1]);
                            if (currentTeam == null)
                            {
                                throw new ArgumentException($"Team {inputArgs[1]} does not exist.");
                            }
                            Console.WriteLine($"{currentTeam.Name} - {Math.Round(currentTeam.Rating())}");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
