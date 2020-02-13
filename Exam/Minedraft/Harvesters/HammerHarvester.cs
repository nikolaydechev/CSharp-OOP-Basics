using System;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        if (EnergyRequirement + EnergyRequirement > 20000 ||
            EnergyRequirement + EnergyRequirement < 0)
        {
            throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
        }
        this.OreOutput = this.OreOutput + this.OreOutput * 2;
        this.EnergyRequirement += this.EnergyRequirement;
    }

    //public override double OreOutput
    //{
    //    get
    //    {
    //        return base.OreOutput;
    //    }
    //    protected set
    //    {
    //        if (base.OreOutput < 0)
    //        {
    //            throw new ArgumentException($"Harvester is not registered, because of it's {nameof(OreOutput)}");
    //        }
    //        base.OreOutput = value;
    //    }
    //}

    //public override double EnergyRequirement
    //{
    //    get
    //    {
    //        return base.EnergyRequirement;
    //    }
    //    protected set
    //    {
    //        if (EnergyRequirement + EnergyRequirement > 20000 ||
    //            EnergyRequirement + EnergyRequirement < 0)
    //        {
    //            throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
    //        }
    //        this.EnergyRequirement = value;
    //    }
    //}

    public override string ToString()
    {
        return $"Hammer Harvester - {this.Id}" + Environment.NewLine + base.ToString();
    }
}
