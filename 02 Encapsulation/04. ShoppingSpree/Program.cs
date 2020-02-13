using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            var personList = new List<Person>();
            var productList = new List<Product>();

            var people = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var products = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var personInfo in people)
                {
                    string[] personInfoArgs = personInfo.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    var person = new Person(personInfoArgs[0], decimal.Parse(personInfoArgs[1]));
                    personList.Add(person);
                }

                foreach (var productInfo in products)
                {
                    string[] productInfoArgs = productInfo.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    var product = new Product(productInfoArgs[0], decimal.Parse(productInfoArgs[1]));
                    productList.Add(product);
                }

                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] inputArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var currentPerson = personList.FirstOrDefault(x => x.Name == inputArgs[0]);
                    var currentProduct = productList.FirstOrDefault(x => x.Name == inputArgs[1]);

                    try
                    {
                        currentPerson.BuyProduct(currentProduct);
                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                personList.ForEach(pr => Console.WriteLine(pr.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
