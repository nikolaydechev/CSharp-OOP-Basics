using System;
using System.Collections.Generic;

namespace _04.ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(Money)} cannot be negative");
                }

                this.money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (this.Money >= product.Price)
            {
                this.products.Add(product);
                this.Money -= product.Price;
            }
            else
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            if (products.Count > 0)
            {
                return $"{this.Name} - {string.Join(", ", this.products)}";
            }
            else
            {
                return $"{this.Name} - Nothing bought";
            }
        }
    }
}
