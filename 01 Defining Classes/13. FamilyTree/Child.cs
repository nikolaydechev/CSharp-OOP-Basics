namespace _13.FamilyTree
{
    public class Child
    {
        private readonly string name;
        private readonly string birthdate;

        public string Name => this.name;
        public string BirthDate => this.birthdate;

        public Child(string name, string birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.BirthDate}";
        }
    }
}
