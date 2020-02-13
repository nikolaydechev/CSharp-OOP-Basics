using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PizzaCalories
{
    public class Program
    {
        public static void Main()
        {
            var listInputs = new List<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                listInputs.Add(input);
            }
            listInputs.Add("END");

            try
            {
                switch (listInputs.Count)
                {
                    case 2:
                        GetDough(listInputs);
                        break;

                    case 3:
                        GetDough(listInputs);
                        string[] toppingArgs = listInputs[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var topping = new Topping(toppingArgs[1], double.Parse(toppingArgs[2]));
                        Console.WriteLine("{0:F2}", topping.GetCalories());
                        break;

                    default:
                        string[] doughArgs = listInputs[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var dough = new Dough(doughArgs[1], doughArgs[2], double.Parse(doughArgs[3]));

                        string[] pizzaArgs = listInputs[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var pizza = new Pizza(pizzaArgs[1], int.Parse(pizzaArgs[2]), dough);
                        
                        foreach (var line in listInputs.Skip(2))
                        {
                            if (line == "END")
                            {
                                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():F2} Calories.");
                                break;
                            }
                            toppingArgs = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            pizza.AddTopping(new Topping(toppingArgs[1], double.Parse(toppingArgs[2])));
                        }
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void GetDough(List<string> listInputs)
        {
            string[] doughArgs = listInputs[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var dough = new Dough(doughArgs[1], doughArgs[2], double.Parse(doughArgs[3]));
            Console.WriteLine("{0:F2}", dough.GetCalories());
        }
    }
}
