namespace _13.FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FamilyTree
    {
        public static void Main()
        {
            var dataList = new List<string>();
            var personList = new List<Person>();

            var initialInputPerson = Console.ReadLine();
            
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input.Contains("-"))
                {
                    dataList.Add(input);
                }
                else
                {
                    string[] peopleDataArgs = input
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.Trim())
                        .ToArray();
                    var personName = peopleDataArgs[0] + " " + peopleDataArgs[1];
                    var personBirthdate = peopleDataArgs[2];

                    personList.Add(new Person(personName, personBirthdate));

                }
            }

            var personInfo = personList.First(x => x.Name == initialInputPerson || x.BirthDate == initialInputPerson);

            foreach (var line in dataList)
            {
                string[] lineArgs = line.Split('-').Select(x => x.Trim()).ToArray();

                if (personInfo.Name == lineArgs[0] || personInfo.BirthDate == lineArgs[0])
                {
                    var currentChild = personList.First(x => x.Name == lineArgs[1] || x.BirthDate == lineArgs[1]);
                    personInfo.Children.Add(new Child(currentChild.Name, currentChild.BirthDate));
                }
                else if (personInfo.Name == lineArgs[1] || personInfo.BirthDate == lineArgs[1])
                {
                    var currentParent = personList.First(x => x.Name == lineArgs[0] || x.BirthDate == lineArgs[0]);
                    personInfo.Parents.Add(new Parent(currentParent.Name, currentParent.BirthDate));
                }

            }

            Console.WriteLine(personInfo);
        }
    }
}
