using System;

namespace _01.Vehicles
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var busInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
                var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
                var bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

                var N = int.Parse(Console.ReadLine());

                for (int i = 0; i < N; i++)
                {
                    var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    switch (command[0])
                    {
                        case "Drive":
                            var distance = double.Parse(command[2]);
                            switch (command[1])
                            {
                                case "Car":
                                    car.Drive(distance);
                                    break;
                                case "Truck":
                                    truck.Drive(distance);
                                    break;
                                case "Bus":
                                    bus.Drive(distance);
                                    break;
                            }
                            break;

                        case "Refuel":
                            var litersToRefuel = double.Parse(command[2]);
                            switch (command[1])
                            {
                                case "Car":
                                    car.Refuel(litersToRefuel);
                                    break;
                                case "Truck":
                                    truck.Refuel(litersToRefuel);
                                    break;
                                case "Bus":
                                    bus.Refuel(litersToRefuel);
                                    break;
                            }
                            break;

                        case "DriveEmpty":
                            distance = double.Parse(command[2]);
                            bus.FuelConsumption -= 1.4;
                            bus.Drive(distance);
                            break;
                    }
                }

                Console.WriteLine("Car: {0:F2}", car.FuelQuantity);
                Console.WriteLine("Truck: {0:F2}", truck.FuelQuantity);
                Console.WriteLine("Bus: {0:F2}", bus.FuelQuantity);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
