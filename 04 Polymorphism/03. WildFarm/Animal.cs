namespace _03.WildFarm
{
    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        public Animal(string name, double weight)
        {
            this.AnimalName = name;
            this.AnimalWeight = weight;
            this.FoodEaten = 0;
        }

        public string AnimalName
        {
            get { return this.animalName; }
            set { this.animalName = value; }
        }

        public string AnimalType
        {
            get { return this.animalType; }
            set { this.animalType = value; }
        }

        public double AnimalWeight
        {
            get { return this.animalWeight; }
            set { this.animalWeight = value; }
        }

        public int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }

        public abstract void makeSound();

        public abstract void eatFood(Food food);

        
    }
}
