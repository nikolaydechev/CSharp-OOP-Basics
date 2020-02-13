using System;
using System.Collections.Generic;
using System.Linq;

public class NationsBuilder
{
    private Dictionary<string, List<Bender>> benders;
    private Dictionary<string, List<Monument>> monuments;

    private Dictionary<string, decimal> warResults;
    private List<string> warIssued;

    public NationsBuilder()
    {
        this.benders = new Dictionary<string, List<Bender>>();
        this.monuments = new Dictionary<string, List<Monument>>();
        this.warResults = new Dictionary<string, decimal>();
        this.warIssued = new List<string>();
    }

    private IReadOnlyDictionary<string, List<Bender>> Benders => this.benders;
    private IReadOnlyDictionary<string, List<Monument>> Monuments => this.monuments;

    public void ExecuteCommand(List<string> data)
    {
        var command = data[0];

        switch (command.ToLower())
        {
            case "bender":
                AssignBender(data);
                break;
            case "monument":
                AssignMonument(data);
                break;
            case "status":
                Console.WriteLine(GetStatus(data[1]));
                break;
            case "war":
                IssueWar(data[1]);
                break;
            case "quit":
                Console.WriteLine(GetWarsRecord());
                break;
        }
    }

    public void AssignBender(List<string> benderArgs)
    {
        switch (benderArgs[1].ToLower())
        {
            case "air":
                if (!this.Benders.ContainsKey("Air"))
                {
                    this.benders.Add("Air", new List<Bender>());
                }
                this.benders["Air"].Add(new AirBender(benderArgs[2], long.Parse(benderArgs[3]), decimal.Parse(benderArgs[4])));

                break;
            case "water":
                if (!this.benders.ContainsKey("Water"))
                {
                    this.benders["Water"] = new List<Bender>();
                }
                this.benders["Water"].Add(new WaterBender(benderArgs[2], int.Parse(benderArgs[3]), decimal.Parse(benderArgs[4])));
                break;
            case "fire":
                if (!this.benders.ContainsKey("Fire"))
                {
                    this.benders["Fire"] = new List<Bender>();
                }
                this.benders["Fire"].Add(new FireBender(benderArgs[2], int.Parse(benderArgs[3]), decimal.Parse(benderArgs[4])));
                break;
            case "earth":
                if (!this.benders.ContainsKey("Earth"))
                {
                    this.benders["Earth"] = new List<Bender>();
                }
                this.benders["Earth"].Add(new EarthBender(benderArgs[2], int.Parse(benderArgs[3]), decimal.Parse(benderArgs[4])));
                break;
        }
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        switch (monumentArgs[1].ToLower())
        {
            case "air":
                if (!this.monuments.ContainsKey("Air"))
                {
                    this.monuments.Add("Air", new List<Monument>());
                }
                this.monuments["Air"].Add(new AirMonument(monumentArgs[2], int.Parse(monumentArgs[3])));
                break;
            case "water":
                if (!this.monuments.ContainsKey("Water"))
                {
                    this.monuments["Water"] = new List<Monument>();
                }
                this.monuments["Water"].Add(new WaterMonument(monumentArgs[2], int.Parse(monumentArgs[3])));
                break;
            case "fire":
                if (!this.monuments.ContainsKey("Fire"))
                {
                    this.monuments["Fire"] = new List<Monument>();
                }
                this.monuments["Fire"].Add(new FireMonument(monumentArgs[2], int.Parse(monumentArgs[3])));
                break;
            case "earth":
                if (!this.monuments.ContainsKey("Earth"))
                {
                    this.monuments["Earth"] = new List<Monument>();
                }
                this.monuments["Earth"].Add(new EarthMonument(monumentArgs[2], int.Parse(monumentArgs[3])));
                break;
        }
    }

    public string GetStatus(string nationsType)
    {
        var bendersForPrint = benders.ContainsKey(nationsType)
            ? "\n" + string.Join("\n", this.Benders[nationsType])
            : " None";
        var monumentsForPrint = monuments.ContainsKey(nationsType)
            ? "\n" + string.Join("\n", this.Monuments[nationsType])
            : " None";

        switch (nationsType.ToLower())
        {
            case "air":
                return $"{nationsType} Nation" +
                       $"\nBenders:{bendersForPrint}" +
                       $"\nMonuments:{monumentsForPrint}";
            case "water":
                return $"{nationsType} Nation" +
                       $"\nBenders:{bendersForPrint}" +
                       $"\nMonuments:{monumentsForPrint}";
            case "fire":
                return $"{nationsType} Nation" +
                       $"\nBenders:{bendersForPrint}" +
                       $"\nMonuments:{monumentsForPrint}";
            default: //"earth"
                return $"{nationsType} Nation" +
                       $"\nBenders:{bendersForPrint}" +
                       $"\nMonuments:{monumentsForPrint}";
        }
    }

    public void IssueWar(string nationsType)
    {
        warIssued.Add($"War {warIssued.Count + 1} issued by {nationsType}");
        warResults.Add("Air", CalculateTotalPower("Air"));
        warResults.Add("Earth", CalculateTotalPower("Earth"));
        warResults.Add("Fire", CalculateTotalPower("Fire"));
        warResults.Add("Water", CalculateTotalPower("Water"));

        var winner = warResults.First(x => x.Value.Equals(warResults.Values.Max())).Key;

        this.benders = this.benders
            .Where(x => x.Key.Contains(winner))
            .ToDictionary(x => x.Key, x => x.Value);

        this.monuments = this.monuments
            .Where(x => x.Key.Contains(winner))
            .ToDictionary(x => x.Key, x => x.Value);

        warResults.Clear();
    }

    public string GetWarsRecord()
    {
        return string.Join("\n", this.warIssued);
    }

    public decimal CalculateTotalPower(string nationsType)
    {
        var nationTypeTotalPower = this.Benders.ContainsKey(nationsType)
            ? this.Benders[nationsType].Select(x => x.GetPower()).Sum()
            : 0;
        var sumOfAffinities = this.Monuments.ContainsKey(nationsType)
            ? this.Monuments[nationsType].Select(x => x.GetAffinity()).Sum()
            : 0;
        var bonuses = (nationTypeTotalPower / 100) * sumOfAffinities;

        return nationTypeTotalPower + bonuses;
    }
}
