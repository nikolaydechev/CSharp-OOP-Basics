using System;

namespace _03.WildFarm
{
    public class Cat : Felime
    {
        private string breed;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion)
        {
            this.breed = breed;
        }
        

        public override void makeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void eatFood(Food food)
        {
            base.FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"{base.AnimalType}[{base.AnimalName}, {this.breed}, {base.AnimalWeight}, {base.LivingRegion}, {base.FoodEaten}]";
        }

    }
}
