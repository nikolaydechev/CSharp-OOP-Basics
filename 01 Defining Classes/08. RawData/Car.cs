using System.Collections.Generic;

namespace _08.RawData
{
    public class Car
    {
        private string model;
        private Cargo cargo;
        private Engine engine;
        private List<Tire> tires;

        public string Model => this.model;

        public Car(string model, Cargo cargo, Engine engine, List<Tire> tires)
        {
            this.model = model;
            this.cargo = cargo;
            this.engine = engine;
            this.tires = tires;
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }
        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }
        public List<Tire> Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }


    }
}




