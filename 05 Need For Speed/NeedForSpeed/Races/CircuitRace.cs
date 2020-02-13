public class CircuitRace : Race
{
    private int laps;

    public CircuitRace(int length, string route, int prizePool, int laps)
        : base(length, route, prizePool)
    {
        this.laps = laps;
    }

    public override int GetPerformance(int id)
    {
        throw new System.NotImplementedException();
    }
}
