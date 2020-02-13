using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FootballTeamGenerator
{
    class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public List<Player> Players
        {
            get { return this.players; }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }

        public double Rating()
        {
            if (players.Count < 1)
            {
                return 0;
            }
            return this.players.Average(x => x.SkillLevel());
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(Player player, string playerName)
        {
            if (player == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
            this.players.Remove(player);
        }
    }
}
