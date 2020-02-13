namespace _10.CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private double weight;
        private string color;

        public Engine Engine
        {
            get { return this.engine; }
        }

        public string Model
        {
            get { return this.model; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = 0;
            this.color = "n/a";
        }

        public override string ToString()
        {
            var carWeight = this.Weight == 0 ? "n/a" : this.Weight.ToString();
            var engineDisplacement = this.Engine.Displacement == 0 ? "n/a" : this.Engine.Displacement.ToString();

            return $"{this.Model}:\n" +
                   $"  {this.Engine.Model}:\n" +
                   $"    Power: {this.Engine.Power}\n" +
                   $"    Displacement: {engineDisplacement}\n" +
                   $"    Efficiency: {this.Engine.Efficiency}\n" +
                   $"  Weight: {carWeight}\n" +
                   $"  Color: {this.Color}";
        }
    }
}