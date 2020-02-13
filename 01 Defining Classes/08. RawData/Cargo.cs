namespace _08.RawData
{
    public class Cargo
    {
        private string cargoType;
        private int cargoWeight;

        public string CargoType { get { return this.cargoType; }  }
        

        public Cargo(string cargoType, int cargoWeight)
        {
            this.cargoType = cargoType;
            this.cargoWeight = cargoWeight;
        }
    }
}
