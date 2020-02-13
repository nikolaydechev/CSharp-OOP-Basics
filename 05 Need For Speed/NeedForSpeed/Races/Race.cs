using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    //private string typeOfRace;
    private int length;
    private string route;
    private int prizePool;
    private Dictionary<int, Car> participants;

    protected Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.participants = new Dictionary<int, Car>();
    }

    public abstract int GetPerformance(int id);

    //public string TypeOfRace { get { return this.typeOfRace; } set { this.typeOfRace = value; } }

    public int Length
    {
        get { return length; }
        set { length = value; }
    }
    public string Route
    {
        get { return this.route; }
        set { this.route = value; }
    }
    public int PrizePool
    {
        get { return prizePool; }
        set { prizePool = value; }
    }
    public Dictionary<int, Car> Participants
    {
        get { return this.participants; }
        set { this.participants = value; }
    }

    public string PrintWinners()
    {
        var sb = new StringBuilder();
        var count = 1;
        var winners = this.Participants
            .OrderByDescending(x => this.GetPerformance(x.Key))
            .Take(3)
            .ToDictionary(x => x.Key, y => y.Value);

        foreach (var winner in winners.Values)
        {
            var currentCarId = winners.First(x => x.Value == winner).Key;
            int moneyWon;
            if (count == 1)
            {
                moneyWon = (prizePool * 50) / 100;
            }
            else if (count == 2)
            {
                moneyWon = (prizePool * 30) / 100;
            }
            else
            {
                moneyWon = (prizePool * 20) / 100;
            }
            sb.AppendLine($"{count++}. {winner.Brand} {winner.Model} {this.GetPerformance(currentCarId)}PP - ${moneyWon}");

        }
        return sb.ToString().Trim();
    }

    public string Start()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.Route} - {this.Length}");
        sb.Append($"{this.PrintWinners()}");

        return sb.ToString().Trim();
    }
}
