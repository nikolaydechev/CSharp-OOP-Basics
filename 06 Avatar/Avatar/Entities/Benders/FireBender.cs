public class FireBender : Bender
{

    public FireBender(string name, long power, decimal heatAggression)
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public decimal HeatAggression { get; private set; }

    public override decimal GetPower()
    {
        return this.Power * this.HeatAggression;
    }

    public override string ToString()
    {
        return $"###Fire Bender: " + base.ToString() + $"Heat Aggression: {this.HeatAggression:F2}";
    }
}
