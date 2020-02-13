using System;

namespace _05.PizzaCalories
{
    class Dough
    {
        private const double white = 1.5;
        private const double wholeGrain = 1.0;
        private const double crispy = 0.9;
        private const double chewy = 1.1;
        private const double homemade = 1.0;

        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }


        public double GetCalories()
        {
            return (this.weight * 2) * GetFlourTypeValue() * GetBakingTechniqueValue();
        }

        private double GetBakingTechniqueValue()
        {
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                return crispy;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                return chewy;
            }
            else if (this.BakingTechnique.ToLower() == "homemade")
            {
                return homemade;
            }
            return 1;
        }

        private double GetFlourTypeValue()
        {
            if (this.FlourType.ToLower() == "white")
            {
                return white;
            }
            else if (this.FlourType.ToLower() == "wholegrain")
            {
                return wholeGrain;
            }

            return 1;
        }
    }
}
