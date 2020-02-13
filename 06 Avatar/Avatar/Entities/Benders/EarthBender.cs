public class EarthBender : Bender
{

    public EarthBender(string name, long power, decimal groundSaturation)
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public decimal GroundSaturation { get; private set; }

    public override decimal GetPower()
    {
        return this.Power * this.GroundSaturation;
    }

    public override string ToString()
    {
        return $"###Earth Bender: " + base.ToString() + $"Ground Saturation: {this.GroundSaturation:F2}";
    }
}
