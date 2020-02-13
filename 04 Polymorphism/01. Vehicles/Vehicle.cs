using System;

namespace _01.Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.tankCapacity = tankCapacity;
        }

        public double TankCapacity
        {
            get { return this.tankCapacity; }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public abstract void Drive(double distance);

        public abstract void Refuel(double liters);
    }
}
