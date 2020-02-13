using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.RawData
{
    public class RawData
    {
        public static void Main()
        {
            var cars = new List<Car>();
            var N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var cargo = new Cargo(carInfo[4], int.Parse(carInfo[3]));
                var engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
                var tire1 = new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6]));
                var tire2 = new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8]));
                var tire3 = new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10]));
                var tire4 = new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12]));

                var car = new Car(carInfo[0], cargo, engine, new List<Tire>() { tire1, tire2, tire3, tire4 });
                cars.Add(car);

            }

            var command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    var wantedCars = cars.Where(x => x.Cargo.CargoType == "fragile")
                                         .Where(y => y.Tires.Any(z => z.Pressure < 1));
                    
                    foreach (var wantedCar in wantedCars)
                    {
                        Console.WriteLine(wantedCar.Model);
                    }
                    break;

                case "flamable":

                    foreach (var wantedCar in cars.Where(x => x.Cargo.CargoType == "flamable")
                                                  .Where(y => y.Engine.EnginePower > 250))
                    {
                        Console.WriteLine(wantedCar.Model);
                    }
                    break;
            }
        }
    }
}
