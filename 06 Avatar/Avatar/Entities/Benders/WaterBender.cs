public class WaterBender : Bender
{
    public WaterBender(string name, long power, decimal waterClarity)
        : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public decimal WaterClarity { get; private set; }

    public override decimal GetPower()
    {
        return this.Power * this.WaterClarity;
    }

    public override string ToString()
    {
        return $"###Water Bender: " + base.ToString() + $"Water Clarity: {this.WaterClarity:F2}";
    }
}
