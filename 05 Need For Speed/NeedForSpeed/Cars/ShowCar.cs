public class ShowCar : Car
{
    public int Stars { get; set; }

    public ShowCar(string brand, string model, int year, int horsePower, int acceleration, int suspension, int durability)
        : base(brand, model, year, horsePower, acceleration, suspension, durability)
    {
        this.Stars = 0;
    }

    public override string ToString()
    {
        return base.ToString() + $"\n{this.Stars} *";
    }


    public override void Tune(int tuneIndex, string addon)
    {
        base.Tune(tuneIndex, addon);
        this.Stars += tuneIndex;
    }
}
