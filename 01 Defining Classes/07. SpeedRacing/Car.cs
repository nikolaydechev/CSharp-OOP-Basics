namespace _07.SpeedRacing
{
    public class Car
    {
        private readonly string model;
        private double fuelAmount;
        private readonly double fuelConsumption;
        private double distanceTravelled;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
            distanceTravelled = 0;
        }

        public string Model { get { return this.model; } }

        public double FuelConsumption { get { return this.fuelConsumption; } }

        public double DistanceTravelled
        {
            get { return this.distanceTravelled; }
            set { this.distanceTravelled = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }


        public bool IsMovingCarPossible(double amountOfKm)
        {
            if ((fuelAmount / fuelConsumption) >= amountOfKm)
            {
                return true;
            }
            return false;
        }
    }
}
