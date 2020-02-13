using System;
using System.Collections.Generic;

namespace _06.Анималс
{
    class Program
    {
        static void Main()
        {
            var animals = new List<Animal>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input.Equals("Beast!")) break;
                string[] animalInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    switch (input)
                    {
                        case "Cat":
                            animals.Add(new Cat(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]));
                            break;

                        case "Dog":
                            animals.Add(new Dog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]));
                            break;

                        case "Frog":
                            animals.Add(new Frog(animalInfo[0], int.Parse(animalInfo[1]), animalInfo[2]));
                            break;

                        case "Kitten":
                            animals.Add(new Kitten(animalInfo[0], int.Parse(animalInfo[1])));
                            break;

                        case "Tomcat":
                            animals.Add(new Tomcat(animalInfo[0], int.Parse(animalInfo[1])));
                            break;

                        default: throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine(animal.ProduceSound());
            }


        }
    }
}
