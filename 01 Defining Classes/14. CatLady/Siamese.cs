namespace _14.CatLady
{
    public class Siamese : Cat
    {
        private double earSize;

        public Siamese(string name, double earsize) : base(name)
        {
            this.earSize = earsize;
        }

        public override string ToString()
        {
            return $"Siamese {base.Name} {this.earSize}";
        }
    }
}
