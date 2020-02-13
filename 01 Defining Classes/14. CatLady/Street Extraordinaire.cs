namespace _14.CatLady
{
    public class Street_Extraordinaire : Cat
    {
        private double decibelsOfMeows;

        public Street_Extraordinaire(string name, double decibelsOfMeows) : base(name)
        {
            this.decibelsOfMeows = decibelsOfMeows;
        }

        public override string ToString()
        {
            return $"StreetExtraordinaire {base.Name} {this.decibelsOfMeows}";
        }
    }
}
