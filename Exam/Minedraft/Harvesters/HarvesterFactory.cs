public class HarvesterFactory
{
    private HarvesterFactory() { }

    public static HammerHarvester MakeHammerHarverster(string id, double oreOutput, double energyRequirement)
    {
        return new HammerHarvester(id, oreOutput, energyRequirement);
    }

    public static SonicHarvester MakeSonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
    {
        return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
    }
}
