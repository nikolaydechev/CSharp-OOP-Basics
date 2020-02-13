using System;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) 
        : base(id, energyOutput)
    {
        if (EnergyOutput + EnergyOutput * 0.5 >= 10000 ||
                    EnergyOutput + EnergyOutput * 0.5 < 0)
        {
            throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
        }
        this.EnergyOutput = this.EnergyOutput + (this.EnergyOutput * 0.5);
    }

    //public override double EnergyOutput
    //{
    //    get
    //    {
    //        return base.EnergyOutput;
    //    }
    //    protected set
    //    {
    //        if (base.EnergyOutput + base.EnergyOutput * 0.5m > 10000 ||
    //            base.EnergyOutput + base.EnergyOutput * 0.5m < 0)
    //        {
    //            throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
    //        }
    //        base.EnergyOutput = value;
    //    }
    //}

    public override string ToString()
    {
        return $"Pressure Provider - {this.Id}" + Environment.NewLine + base.ToString();
    }
}
