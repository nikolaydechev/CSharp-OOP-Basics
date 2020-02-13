public abstract class Bender
{
    protected Bender(string name, long power)
    {
        this.Name = name;
        this.Power = power;
    }
    
    public string Name
    {
        get;
        private set;
    }

    public long Power
    {
        get;
        private set;
    }

    public abstract decimal GetPower();

    public override string ToString()
    {
        return $"{this.Name}, Power: {this.Power}, ";
    }
}
