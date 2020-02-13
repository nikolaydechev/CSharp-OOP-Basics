namespace _14.CatLady
{
    public class Cymric : Cat
    {
        private double furLength;

        public Cymric(string name, double furLenght) : base(name)
        {
            this.furLength = furLenght;
        }

        public override string ToString()
        {
            return $"Cymric {base.Name} {this.furLength:F2}";
        }
    }
}
