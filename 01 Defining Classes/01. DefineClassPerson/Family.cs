using System.Collections.Generic;
using System.Linq;

namespace _01.DefineClassPerson
{
    public class Family
    {
        private List<Person> people;

        public List<Person> People
        {
            get { return this.people; }
        }

        public Family()
        {
            this.people = new List<Person>();
        }
        
        public void AddMember(Person member)
        {
            people.Add(member);
        }

        //public Person GetOldestMember()
        //{
        //    int maxAge = people.Max(x => x.Age);
        //    return people.First(x => x.Age == maxAge);
        //}
    }
}
