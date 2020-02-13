using System;
using System.Collections.Generic;
using System.Linq;

public class CarManager
{
    private Dictionary<int, Car> carList;
    private Dictionary<int, Race> raceList;
    private Garage garage;

    private List<int> racesClosed;

    public CarManager()
    {
        this.carList = new Dictionary<int, Car>();
        this.raceList = new Dictionary<int, Race>();
        this.garage = new Garage();
        this.racesClosed = new List<int>();
    }

    public IReadOnlyDictionary<int, Car> CarList { get { return this.carList; } }
    public IReadOnlyDictionary<int, Race> RaceList { get { return this.raceList; } }

    public void InterpretCommand(string input)
    {
        string[] data = input.Split(' ');
        string command = data[0];

        switch (command)
        {
            case "register":
                Register(int.Parse(data[1]), data[2], data[3], data[4], int.Parse(data[5]), int.Parse(data[6]),
                    int.Parse(data[7]), int.Parse(data[8]), int.Parse(data[9]));
                break;
            case "check":
                Console.WriteLine(Check(int.Parse(data[1])));
                break;
            case "open":
                Open(int.Parse(data[1]), data[2], int.Parse(data[3]), data[4], int.Parse(data[5]));
                break;
            case "participate":
                Participate(int.Parse(data[1]), int.Parse(data[2]));
                break;
            case "start":
                Console.WriteLine(Start(int.Parse(data[1])));
                //this.raceList.Remove((int.Parse(data[1])));
                //var currentRace = this.RaceList.First(x => x.Key == int.Parse(data[1])).Value;
                //currentRace.Participants.Clear();
                //this.raceList.Remove(int.Parse(data[1]));
                break;
            case "park":
                Park(int.Parse(data[1]));
                break;
            case "unpark":
                Unpark(int.Parse(data[1]));
                break;
            case "tune":
                var addOn = string.Join(" ", data.Skip(2));
                Tune(int.Parse(data[1]), addOn);
                break;
            default: throw new ArgumentException("Invalid command!");

        }
    }


    public void Register(int id, string type, string brand, string model, int yearOfProduction,
        int horsepower, int acceleration, int suspension, int durability)
    {
        //int id = int.Parse(data[1]);
        //string type = data[2];
        //string brand = data[3];
        //string model = data[4];
        //int yearOfProduction = int.Parse(data[5]);
        //int horsePower = int.Parse(data[6]);
        //int acceleration = int.Parse(data[7]);
        //int suspension = int.Parse(data[8]);
        //int durability = int.Parse(data[9]);

        switch (type.ToLower())
        {
            case "show":
                carList.Add(id, new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
                break;
            case "performance":
                carList.Add(id, new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
                break;
        }
    }

    public string Check(int id)
    {
        return CarList[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        Race race;
        //int id = int.Parse(data[1]);
        //string type = data[2];
        //int length = int.Parse(data[3]);
        //string route = data[4];
        //int prizePool = int.Parse(data[5]);

        switch (type.ToLower())
        {
            case "drag":
                race = new DragRace(length, route, prizePool);
                //race.TypeOfRace = "DragRace";
                break;
            case "casual":
                race = new CasualRace(length, route, prizePool);
                //race.TypeOfRace = "CasualRace";
                break;
            //case "drift":
            default:
                race = new DriftRace(length, route, prizePool);
                //race.TypeOfRace = "DriftRace";
                break;
        }

        raceList.Add(id, race);
    }

    public void Participate(int carId, int raceId)
    {
        if (!this.garage.ParkedCars.Contains(carId))
        {
            if (this.RaceList.ContainsKey(raceId))
            {
                this.raceList[raceId].Participants.Add(carId, carList[carId]);
            }
        }
    }

    public string Start(int id)
    {
        if (RaceList[id].Participants.Count < 1)
        {
            return $"Cannot start the race with zero participants.";
        }

        var result = RaceList[id].Start();
        racesClosed.Add(id);
        return result;
    }

    public void Park(int id)
    {
        //if (this.raceList.Values.All(x => !x.Participants.ContainsKey(id)))
        //{
        //    this.garage.AddCar(id);
        //}

        foreach (var race in raceList.Where(r => !racesClosed.Contains(r.Key)))
        {
            if (race.Value.Participants.ContainsKey(id))
            {
                return;
            }
        }

        this.garage.AddCar(id);
    }

    public void Unpark(int id)
    {
        if (this.garage.ParkedCars.Contains(id))
        {
            this.garage.RemoveCar(id);
        }
    }

    public void Tune(int tuneIndex, string addOn)
    {
        //if (this.garage.ParkedCars.Count > 0)
        //{
        foreach (var id in garage.ParkedCars)
        {
            carList[id].Tune(tuneIndex, addOn);
        }
        //}
    }
}