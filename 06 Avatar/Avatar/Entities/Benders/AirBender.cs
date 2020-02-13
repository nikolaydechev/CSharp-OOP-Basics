public class AirBender : Bender
{

    public AirBender(string name, long power, decimal aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegirty = aerialIntegrity;
    }

    public decimal AerialIntegirty { get; private set; }

    public override decimal GetPower()
    {
        return this.Power * this.AerialIntegirty;
    }

    public override string ToString()
    {
        return $"###Air Bender: " + base.ToString() + $"Aerial Integrity: {this.AerialIntegirty:F2}";
    }
}
