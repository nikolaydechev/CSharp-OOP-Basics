using System;

public class Provider
{
    private string id;
    private double energyOutput;

    protected Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    public string Id
    {
        get
        {
            return this.id;
        }
        protected set { this.id = value; }
    }

    public double EnergyOutput
    {
        get
        {
            return this.energyOutput;
        }
        protected set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
            }
            this.energyOutput = value;
        }
    }

    public override string ToString()
    {
        return $"Energy Output: {this.EnergyOutput}";
    }
}
