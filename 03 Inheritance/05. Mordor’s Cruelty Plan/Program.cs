using System;
using System.Collections.Generic;

namespace _05.Mordor_s_Cruelty_Plan
{
    class Program
    {
        static void Main()
        {
            var lineWithFoods = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var foodList = new List<Food>();

            foreach (var food in lineWithFoods)
            {
                foodList.Add(FoodFactory.GetFood(food.ToLower()));
            }

            int moodFactor = 0;

            foreach (var typeFood in foodList)
            {
                moodFactor += typeFood.HapinessPoints;
            }

            Console.WriteLine(moodFactor);
            Console.WriteLine(MoodFactory.GetCorrespondingMood(moodFactor).GetType().Name);
        }
    }
}
