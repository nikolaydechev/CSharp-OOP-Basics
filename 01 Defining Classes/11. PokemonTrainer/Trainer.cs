using System.Collections.Generic;

namespace _11.PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private double badges;
        private List<Pokemon> pokemons;

        public string Name { get { return this.name; } }
        public List<Pokemon> Pokemons { get { return this.pokemons; } set { this.pokemons = value; } }
        public double Badges { get { return this.badges; } set { this.badges = value; } }

        public Trainer(string name, List<Pokemon> pokemons)
        {
            this.name = name;
            this.pokemons = pokemons;
            this.badges = 0;
        }
    }
}
