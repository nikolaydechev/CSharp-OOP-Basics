namespace _12.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var personList = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputParams = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (personList.All(x => x.Name != inputParams[0]))
                {
                    var person = new Person(inputParams[0]);
                    personList.Add(person);
                }

                var currentPerson = personList.First(x => x.Name == inputParams[0]);
                switch (inputParams[1])
                {
                    case "company":
                        currentPerson.CompanyData.CompanyName = inputParams[2];
                        currentPerson.CompanyData.Department = inputParams[3];
                        currentPerson.CompanyData.Salary = double.Parse(inputParams[4]);
                        break;
                    case "car":
                        currentPerson.CarData.Model = inputParams[2];
                        currentPerson.CarData.Speed = double.Parse(inputParams[3]);
                        break;
                    case "pokemon":
                        var pokemon = new Person.Pokemon(inputParams[2], inputParams[3]);
                        currentPerson.PokemonsData.Add(pokemon);
                        break;
                    case "parents":
                        var parents = new Person.Parent(inputParams[2], inputParams[3]);
                        currentPerson.ParentsData.Add(parents);
                        break;
                    case "children":
                        var children = new Person.Child(inputParams[2], inputParams[3]);
                        currentPerson.ChildrenData.Add(children);
                        break;
                }
            }

            var name = Console.ReadLine();

            var personInfoForDisplay = personList.First(x => x.Name == name);

            Console.WriteLine(personInfoForDisplay.ToString());
            
        }
    }
}
