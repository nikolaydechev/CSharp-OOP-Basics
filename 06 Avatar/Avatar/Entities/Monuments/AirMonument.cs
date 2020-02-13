public class AirMonument : Monument
{
    public AirMonument(string name, int airAffinity)
        : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public int AirAffinity { get; private set; }

    public override string ToString()
    {
        return $"###Air Monument: {this.Name}, Air Affinity: {this.AirAffinity}";
    }

    public override int GetAffinity()
    {
        return AirAffinity;
    }
}
