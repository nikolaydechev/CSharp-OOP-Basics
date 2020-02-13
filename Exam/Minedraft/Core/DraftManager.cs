using System;
using System.Collections.Generic;
using System.Linq;

public class DraftManager
{
    private double totalMinedOre;
    private double totalStoredEnergy;
    private string mode;
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.totalStoredEnergy = 0;
        this.mode = "Full";
        this.totalMinedOre = 0;
    }

    public void ExecuteCommand(List<string> cmdArgs, string command)
    {
        switch (command)
        {
            case "RegisterHarvester":
                Console.WriteLine(RegisterHarvester(cmdArgs));
                break;
            case "RegisterProvider":
                Console.WriteLine(RegisterProvider(cmdArgs));
                break;
            case "Day":
                Console.WriteLine(Day());
                break;
            case "Mode":
                Console.WriteLine(Mode(cmdArgs));
                break;
            case "Check":
                Console.WriteLine(Check(cmdArgs));
                break;
            case "Shutdown":
                Console.WriteLine(ShutDown());
                break;
        }
    }

    public string RegisterHarvester(List<string> arguments)
    {
        switch (arguments[0])
        {
            case "Sonic":
                //this.harvesters.Add(arguments[1], new SonicHarvester(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3]), int.Parse(arguments[4])));
                this.harvesters.Add(arguments[1], HarvesterFactory.MakeSonicHarvester(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3]), int.Parse(arguments[4])));
                break;
            case "Hammer":
                //this.harvesters.Add(arguments[1], new HammerHarvester(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3])));
                this.harvesters.Add(arguments[1], HarvesterFactory.MakeHammerHarverster(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3])));
                break;
        }

        return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";
    }

    public string RegisterProvider(List<string> arguments)
    {
        switch (arguments[0])
        {
            case "Solar":
                //this.providers.Add(arguments[1], new SolarProvider(arguments[1], double.Parse(arguments[2])));
                this.providers.Add(arguments[1], ProviderFactory.MakeSolarProvider(arguments[1], double.Parse(arguments[2])));
                break;
            case "Pressure":
                //this.providers.Add(arguments[1], new PressureProvider(arguments[1], double.Parse(arguments[2])));
                this.providers.Add(arguments[1], ProviderFactory.MakePressureProvider(arguments[1], double.Parse(arguments[2])));
                break;
        }
        return $"Successfully registered {arguments[0]} Provider - {arguments[1]}";
    }

    public string Day()
    {
        double allProvidedEnergy =this.providers.Count > 0 ? this.providers.Values.Sum(x => x.EnergyOutput) : 0;
        double sumOfEnergyRequirements = 0;
        double sumCurrentOreOutput = 0;

        switch (mode)
        {
            //All Harvesters consume their FULL energy requirements, and produce their FULL ore output
            case "Full":
                sumOfEnergyRequirements = this.harvesters.Values.Sum(x => x.EnergyRequirement);
                this.totalStoredEnergy += allProvidedEnergy;
                if (sumOfEnergyRequirements <= this.totalStoredEnergy)
                {
                    sumCurrentOreOutput = this.harvesters.Values.Sum(x => x.OreOutput);
                    this.totalMinedOre += sumCurrentOreOutput;
                    this.totalStoredEnergy -= this.harvesters.Values.Sum(x => x.EnergyRequirement);
                }
                break;
            //All Harvesters consume 60 % of their energy requirements, and produce 50 % of their ore output.
            case "Half":
                sumOfEnergyRequirements = this.harvesters.Values.Sum(x => x.EnergyRequirement * 0.6);
                this.totalStoredEnergy += allProvidedEnergy;
                sumOfEnergyRequirements -= sumOfEnergyRequirements;
                if (sumOfEnergyRequirements <= this.totalStoredEnergy)
                {
                    sumCurrentOreOutput = this.harvesters.Values.Sum(x => x.OreOutput * 0.5);
                    this.totalMinedOre += sumCurrentOreOutput;
                    this.totalStoredEnergy -= this.harvesters.Values.Sum(x => x.EnergyRequirement * 0.6);
                }
                break;
            //The Harvesters consume nothing, and produce nothing. They practically do NOT work
            case "Energy":
                totalStoredEnergy += allProvidedEnergy;
                break;
        }

        //var summedEnergyOutput = this.providers.Select(x => x.Value.EnergyOutput).Sum();
        //var summedOreOutput = this.harvesters.Select(x => x.Value.OreOutput).Sum();

        return $"A day has passed." + Environment.NewLine +
               $"Energy Provided: {allProvidedEnergy}" + Environment.NewLine +
               $"Plumbus Ore Mined: {sumCurrentOreOutput}";
    }

    public string Mode(List<string> arguments)
    {
        var mode = arguments[0];
        switch (mode)
        {
            case "Full":
                this.mode = "Full";
                break;
            case "Half":
                this.mode = "Half";
                break;
            case "Energy":
                this.mode = "Energy";
                break;
        }
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        var harvester = this.harvesters.FirstOrDefault(x => x.Key == id).Value;
        var provider = this.providers.FirstOrDefault(x => x.Key == id).Value;

        if (harvester != null)
        {
            return harvester.ToString();
        }
        else if (provider != null)
        {
            return provider.ToString();
        }
        else
        {
            return $"No element found with id - {id}";
        }
    }

    public string ShutDown()
    {
        return $"System Shutdown" + Environment.NewLine +
               $"Total Energy Stored: {this.totalStoredEnergy}" + Environment.NewLine +
               $"Total Mined Plumbus Ore: {this.totalMinedOre}";
    }


}
