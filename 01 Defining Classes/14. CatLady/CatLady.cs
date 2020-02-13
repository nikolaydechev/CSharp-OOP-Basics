namespace _14.CatLady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CatLady
    {
        public static void Main()
        {
            var catList = new List<Cat>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputParams = input.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

                switch (inputParams[0])
                {
                    case "StreetExtraordinaire":
                        catList.Add(new Street_Extraordinaire(inputParams[1], double.Parse(inputParams[2])));
                        break;
                    case "Siamese":
                        catList.Add(new Siamese(inputParams[1], double.Parse(inputParams[2])));
                        break;
                    case "Cymric":
                        catList.Add(new Cymric(inputParams[1], double.Parse(inputParams[2])));
                        break;
                }
            }

            var name = Console.ReadLine();
            var catToDisplay = catList.First(x => x.Name == name);

            Console.WriteLine(catToDisplay);
        }
    }
}
