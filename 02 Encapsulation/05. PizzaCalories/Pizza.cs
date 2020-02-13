using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PizzaCalories
{
    class Pizza
    {
        private string name;
        private Dough dough;
        private readonly List<Topping> topings;
        private int toppingCount;

        public Pizza(string name, int toppingCount, Dough dough)
        {
            this.Name = name;
            this.ToppingCount = toppingCount;
            this.dough = dough;
            this.topings = new List<Topping>();
        }

        public int ToppingCount
        {
            get { return this.toppingCount; }
            set
            {
                if (value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this.toppingCount = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public double GetTotalCalories()
        {
            return dough.GetCalories() + topings.Sum(x => x.GetCalories());
        }

        public void AddTopping(Topping topping)
        {
            this.topings.Add(topping);
        }
    }
}
