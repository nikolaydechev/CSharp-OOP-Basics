using System;

namespace _03.WildFarm
{
    public class Tiger : Felime
    {
        public Tiger(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }
        
        public override void makeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void eatFood(Food food)
        {
            base.FoodEaten += food.Quantity;
        }
    }
}
