namespace _11.PokemonTrainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private double health;

        public string Element { get { return this.element; } }
        public double Health { get { return this.health; } set { this.health = value; } }

        public Pokemon(string name, string element, double health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }
    }
}
