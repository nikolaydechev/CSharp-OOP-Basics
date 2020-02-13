namespace _03.WildFarm
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public string LivingRegion
        {
            get { return this.livingRegion; }
            set { this.livingRegion = value; }
        }

        public Mammal(string name, double weight, string livingRegion) : 
            base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{base.AnimalType}[{base.AnimalName}, {base.AnimalWeight}, {this.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
