using System;

namespace _05.PizzaCalories
{
    class Topping
    {
        private string toppingType;
        private double weight;

        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        public string ToppingType
        {
            get
            {
                return this.toppingType;
            }
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.toppingType = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }


        public double GetCalories()
        {
            return (this.weight * 2) * GetToppingTypeValue();
        }

        private double GetToppingTypeValue()
        {
            if (this.ToppingType.ToLower() == "meat")
            {
                return 1.2;
            }
            else if (this.ToppingType.ToLower() == "veggies")
            {
                return 0.8;
            }
            else if (this.ToppingType.ToLower() == "cheese")
            {
                return 1.1;
            }
            else if (this.ToppingType.ToLower() == "sauce")
            {
                return 0.9;
            }

            return 1;
        }
    }
}
