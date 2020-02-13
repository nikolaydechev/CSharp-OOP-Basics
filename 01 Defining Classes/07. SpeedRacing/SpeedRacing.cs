using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SpeedRacing
{
    public class SpeedRacing
    {
        public static void Main()
        {
            var cars = new List<Car>();
            var N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                var inputArgs = Console.ReadLine().Split(' ');
                var car = new Car(inputArgs[0], double.Parse(inputArgs[1]), double.Parse(inputArgs[2]));
                cars.Add(car);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentCar = cars.FirstOrDefault(x => x.Model == cmdArgs[1]);

                if (currentCar != null && currentCar.IsMovingCarPossible(double.Parse(cmdArgs[2])))
                {
                    currentCar.FuelAmount -= double.Parse(cmdArgs[2]) * currentCar.FuelConsumption;
                    currentCar.DistanceTravelled += double.Parse(cmdArgs[2]);
                }
                else
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTravelled}");
            }
        }
    }
}
