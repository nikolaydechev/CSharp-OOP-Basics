using System;

namespace _01.Vehicles
{
    public class Bus:Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption + 1.4, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (distance * base.FuelConsumption <= base.FuelQuantity)
            {
                base.FuelQuantity -= distance * base.FuelConsumption;
                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if ((base.FuelQuantity + liters) > base.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                base.FuelQuantity += liters;
            }
        }
    }
}
