using System;

namespace _03.WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }


        public override void makeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override void eatFood(Food food)
        {
            base.FoodEaten += food.Quantity;
        }

    }
}
