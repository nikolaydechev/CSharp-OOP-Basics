using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.CarSalesman
{
    public class CarSalesman
    {
        public static void Main()
        {
            var cars = new List<Car>();
            var engines = new List<Engine>();
            var N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] engineData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var engine = new Engine(engineData[0], double.Parse(engineData[1]));

                if (engineData.Length >= 3)
                {
                    double displacement;
                    bool isNumber = double.TryParse(engineData[2], out displacement);

                    if (!isNumber)
                    {
                        engine.Efficiency = engineData[2];
                    }
                    else
                    {
                        engine.Displacement = displacement;
                        if (engineData.Length > 3)
                        {
                            engine.Efficiency = engineData[3];
                        }
                    }
                }

                engines.Add(engine);
            }

            var M = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                string[] carData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentEngine = engines.First(x => x.Model == carData[1]);
                var car = new Car(carData[0], currentEngine);

                if (carData.Length >= 3)
                {
                    double weight;
                    bool isNumber = double.TryParse(carData[2], out weight);

                    if (!isNumber)
                    {
                        car.Color = carData[2];
                    }
                    else
                    {
                        car.Weight = weight;
                        if (carData.Length > 3)
                        {
                            car.Color = carData[3];
                        }
                    }
                }

                cars.Add(car);
            }
            
            cars.ForEach(Console.WriteLine);
        }
    }
}

