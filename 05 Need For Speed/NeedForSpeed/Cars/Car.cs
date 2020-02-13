using System.Collections.Generic;
using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsePower;
    private int acceleration;
    private int suspension;
    private int durability;
    

    public Car(string brand, string model, int year, int horsePower, int acceleration, int suspension, int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.HorsePower = horsePower;
        this.YearOfProduction = year;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    //public int Stars { get { return this.stars; } set { this.stars = value; } }
    //public List<string> AddOnsList { get { return this.addOns; } set { this.addOns = value; } }

    public string Brand { get { return this.brand; } set { this.brand = value; } }
    public string Model { get { return this.model; } set { this.model = value; } }
    public int YearOfProduction { get { return this.yearOfProduction; } set { this.yearOfProduction = value; } }
    public int HorsePower { get { return this.horsePower; } set { this.horsePower = value; } }
    public int Acceleration { get { return this.acceleration; } set { this.acceleration = value; } }
    public int Suspension { get { return this.suspension; } set { this.suspension = value; } }
    public int Durability { get { return this.durability; } set { this.durability = value; } }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}");
        sb.AppendLine($"{this.HorsePower} HP, 100 m/h in {this.Acceleration} s");
        sb.Append($"{this.Suspension} Suspension force, {this.Durability} Durability");

        return sb.ToString().Trim();
    }

    public virtual void Tune(int tuneIndex, string addon)
    {
        this.HorsePower += tuneIndex;
        this.Suspension += tuneIndex * 50 / 100; 
    }

    //public int PerformancePoints(string raceType)
    //{
    //    switch (raceType)
    //    {
    //        case "CasualRace":
    //            //OverallPerformance
    //            return (this.HorsePower / this.Acceleration) + (this.Suspension + this.Durability);
    //        case "DragRace":
    //            //EnginePerformance
    //            return this.HorsePower / this.Acceleration;
    //        //case "DriftRace":
    //        default:
    //            //SuspensionPerformance
    //            return this.Suspension + this.Durability;
    //    }
    //}
}
