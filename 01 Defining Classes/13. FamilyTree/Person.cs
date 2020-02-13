namespace _13.FamilyTree
{
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private string birthdate;
        private List<Parent> parents;
        private List<Child> children;

        public string Name => this.name;
        public string BirthDate => this.birthdate;
        public List<Parent> Parents => this.parents;
        public List<Child> Children => this.children;

        public Person(string name, string birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
            this.parents = new List<Parent>();
            this.children = new List<Child>();
        }

        public override string ToString()
        {
            var parents = this.Parents.Count > 0 ? "\n" + string.Join("\n", this.Parents) : "";
            var children = this.Children.Count > 0 ? "\n" + string.Join("\n", this.Children) : "";

            return $"{this.Name} {this.BirthDate}" +
                   $"\nParents:{parents}" +
                   $"\nChildren:{children}";
        }
    }
}
