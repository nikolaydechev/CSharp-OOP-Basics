namespace _10.CarSalesman
{
    public class Engine
    {
        private string model;
        private double power;
        private double displacement;
        private string efficiency;

        public string Model { get { return this.model; } }
        public double Power { get { return this.power; } }
        public double Displacement { get { return this.displacement; } set { this.displacement = value; } }
        public string Efficiency { get { return this.efficiency; } set { this.efficiency = value; } }

        public Engine(string model, double power)
        {
            this.model = model;
            this.power = power;
            this.displacement = 0;
            this.efficiency = "n/a";
        }
    }
}
