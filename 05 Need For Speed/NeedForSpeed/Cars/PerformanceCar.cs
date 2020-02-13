using System.Collections.Generic;

public class PerformanceCar : Car
{
    public List<string> addOns { get; set; }

    public PerformanceCar(string brand, string model, int year, int horsePower, int acceleration, int suspension, int durability)
        : base(brand, model, year, horsePower , acceleration, suspension, durability)
    {
        this.HorsePower += this.HorsePower * 50 / 100;
        this.Suspension -= this.Suspension * 25 / 100;
        this.addOns = new List<string>();
    }


    public override void Tune(int tuneIndex, string addon)
    {
        base.Tune(tuneIndex, addon);
        this.addOns.Add(addon);
    }

    public override string ToString()
    {
        string addons = this.addOns.Count > 0 ? string.Join(", ", this.addOns) : "None";
        return base.ToString() + $"\nAdd-ons: {addons}";
    }


}
