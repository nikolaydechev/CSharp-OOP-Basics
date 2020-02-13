public class ProviderFactory
{
    private ProviderFactory(){}

    public static SolarProvider MakeSolarProvider(string id, double energyOutput)
    {
        return new SolarProvider(id, energyOutput);
    }

    public static PressureProvider MakePressureProvider(string id, double energyOutput)
    {
        return new PressureProvider(id, energyOutput);
    }
}