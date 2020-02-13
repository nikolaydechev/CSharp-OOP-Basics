using System;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption + 1.6, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (distance * base.FuelConsumption <= base.FuelQuantity)
            {
                base.FuelQuantity -= distance * base.FuelConsumption;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            base.FuelQuantity += liters - (liters * 0.05);
        }
    }
}
