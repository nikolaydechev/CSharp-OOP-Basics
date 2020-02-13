using System;

namespace _03.WildFarm
{
    public class StartUp
    {
        public static void Main()
        {
            while (true)
            {
                var animalInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (animalInfo[0] == "End") break;
                var foodInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Food food;

                switch (animalInfo[0])
                {
                    case "Mouse":
                        var mouse = new Mouse(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                        food = Food.FoodFactory(foodInfo[0], int.Parse(foodInfo[1]));
                        mouse.makeSound();
                        try
                        {
                            mouse.AnimalType = "Mouse";
                            if (foodInfo[0] != "Vegetable")
                            {
                                mouse.FoodEaten = 0;
                                throw new ArgumentException($"Mouses are not eating that type of food!");
                            }
                            else
                            {
                                mouse.eatFood(food);
                            }
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        Console.WriteLine(mouse);
                        break;

                    case "Zebra":
                        var zebra = new Zebra(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                        food = Food.FoodFactory(foodInfo[0], int.Parse(foodInfo[1]));
                        zebra.makeSound();
                        try
                        {
                            zebra.AnimalType = "Zebra";
                            if (foodInfo[0] != "Vegetable")
                            {
                                zebra.FoodEaten = 0;
                                throw new ArgumentException($"Zebras are not eating that type of food!");
                            }
                            else
                            {
                                zebra.eatFood(food);

                            }
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        Console.WriteLine(zebra);
                        break;

                    case "Cat":
                        var cat = new Cat(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                        cat.AnimalType = "Cat";
                        food = Food.FoodFactory(foodInfo[0], int.Parse(foodInfo[1]));
                        cat.makeSound();
                        cat.eatFood(food);
                        Console.WriteLine(cat);
                        break;

                    case "Tiger":
                        var tiger = new Tiger(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                        tiger.makeSound();
                        food = Food.FoodFactory(foodInfo[0], int.Parse(foodInfo[1]));
                        try
                        {
                            tiger.AnimalType = "Tiger";
                            if (foodInfo[0] == "Vegetable")
                            {
                                tiger.FoodEaten = 0;
                                throw new ArgumentException($"Tigers are not eating that type of food!");
                            }
                            else
                            {
                                tiger.eatFood(food);
                            }
                        }
                        catch (ArgumentException e)
                        {

                            Console.WriteLine(e.Message);
                        }

                        Console.WriteLine(tiger);
                        break;
                }

            }
        }
    }
}
