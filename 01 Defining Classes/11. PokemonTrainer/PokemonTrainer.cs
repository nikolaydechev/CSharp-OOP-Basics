using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PokemonTrainer
{
    public class PokemonTrainer
    {
        public static void Main()
        {
            var trainers = new List<Trainer>();

            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] inputParams = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var pokemon = new Pokemon(inputParams[1], inputParams[2], double.Parse(inputParams[3]));

                if (trainers.All(x => x.Name != inputParams[0]))
                {
                    var trainer = new Trainer(inputParams[0], new List<Pokemon>());
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    var currentTrainer = trainers.First(x => x.Name == inputParams[0]);
                    currentTrainer.Pokemons.Add(pokemon);
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                switch (command)
                {
                    case "Fire":
                        CheckPokemonElement(trainers, command);
                        break;
                    case "Electricity":
                        CheckPokemonElement(trainers, command);
                        break;
                    case "Water":
                        CheckPokemonElement(trainers, command);
                        break;
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static void CheckPokemonElement(List<Trainer> trainers, string element)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(x=>x.Element == element))
                {
                    trainer.Badges++;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                }

                trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                
            }
        }
    }
}
