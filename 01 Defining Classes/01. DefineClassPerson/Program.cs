using System;
using System.Linq;

namespace _01.DefineClassPerson
{
    public class Program
    {
        public static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < N; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                var name = inputArgs[0];
                var age = int.Parse(inputArgs[1]);

                var person = new Person(name, age);
                family.AddMember(person);
            }

            var membersOver30 = family.People.Where(x => x.Age > 30).OrderBy(x=>x.Name);
            foreach (var person in membersOver30)
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}
