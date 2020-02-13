using System;

namespace _03.WildFarm
{
    public class Zebra : Mammal
    {
        public Zebra(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }


        public override void makeSound()
        {
            Console.WriteLine("Zs");
        }

        public override void eatFood(Food food)
        {
            base.FoodEaten += food.Quantity;
        }

    }
}
