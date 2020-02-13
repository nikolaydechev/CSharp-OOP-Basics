namespace _12.Google
{
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Parent> parents;
        private List<Child> children;
        private List<Pokemon> pokemons;

        public string Name { get { return this.name; } set { this.name = value; } }
        public Company CompanyData { get { return this.company; } set { this.company = value; } }
        public List<Parent> ParentsData { get { return this.parents; } set { this.parents = value; } }
        public List<Child> ChildrenData { get { return this.children; } set { this.children = value; } }
        public List<Pokemon> PokemonsData { get { return this.pokemons; } set { this.pokemons = value; } }
        public Car CarData { get { return this.car; } set { this.car = value; } }

        public Person(string name)
        {
            this.name = name;
            this.company = new Company();
            this.car = new Car();
            this.parents = new List<Parent>();
            this.children = new List<Child>();
            this.pokemons = new List<Pokemon>();
        }

        public class Company
        {
            private string companyName;
            private string department;
            private double? salary;

            public string CompanyName { get { return this.companyName; } set { this.companyName = value; } }
            public string Department { get { return this.department; } set { this.department = value; } }
            public double? Salary { get { return this.salary; } set { this.salary = value; } }

            public override string ToString()
            {
                if (string.IsNullOrEmpty(companyName))
                {
                    return "";
                }
                return $"\n{this.companyName} {this.department} {this.salary:F2}";
            }

        }

        public class Pokemon
        {
            private string name;
            private string type;

            public Pokemon()
            {
            }

            public Pokemon(string name, string type)
            {
                this.name = name;
                this.type = type;
            }

            public override string ToString()
            {
                return $"{this.name} {this.type}";
            }
        }

        public class Parent
        {
            private string name;
            private string birthday;

            public Parent()
            {
            }

            public Parent(string name, string birthday)
            {
                this.name = name;
                this.birthday = birthday;
            }

            public override string ToString()
            {
                return $"{this.name} {this.birthday}";
            }
        }

        public class Child
        {
            private string name;
            private string birthday;

            public Child()
            {
            }

            public Child(string name, string birthday)
            {
                this.name = name;
                this.birthday = birthday;
            }

            public override string ToString()
            {
                return $"{this.name} {this.birthday}";
            }
        }

        public class Car
        {
            private string model;
            private double? speed;

            public string Model { get { return this.model; } set { this.model = value; } }
            public double? Speed { get { return this.speed; } set { this.speed = value; } }

            public override string ToString()
            {
                if (string.IsNullOrEmpty(model))
                {
                    return "";
                }
                return $"\n{this.model} {this.speed}";
            }
        }


        public override string ToString()
        {
            var pokemons = this.PokemonsData.Count > 0 ? "\n" + string.Join("\n", this.PokemonsData) : "";
            var parents = this.ParentsData.Count > 0 ? "\n" + string.Join("\n", this.ParentsData) : "";
            var children = this.ChildrenData.Count > 0 ? "\n" + string.Join("\n", this.ChildrenData) : "";

            return this.Name +
                $"\nCompany:{this.CompanyData}" +
                $"\nCar:{this.CarData}" +
                $"\nPokemon:{pokemons}" +
                $"\nParents:{parents}" +
                $"\nChildren:{children}";
        }

    }
}
