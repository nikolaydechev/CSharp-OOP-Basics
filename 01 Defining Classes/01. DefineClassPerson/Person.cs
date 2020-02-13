namespace _01.DefineClassPerson
{
    public class Person
    {
        public string name;
        public int age;
        
        public int Age
        {
            get { return this.age; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person(int age)
            :this()
        {
            this.age = age;
        }

        public Person(string name, int age)
            :this(age)
        {
            this.name = name;
        }

    }
}
