using System;

namespace _01.Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption + 0.9, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (distance * base.FuelConsumption <= base.FuelQuantity)
            {
                base.FuelQuantity -= distance * base.FuelConsumption;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
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
