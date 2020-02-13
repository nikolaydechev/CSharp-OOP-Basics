namespace _03.WildFarm
{
    public abstract class Food
    {
        private int quantity;

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public static Food FoodFactory(string food, int quantity)
        {
            if (food.ToLower() == "vegetable")
            {
                return new Vegetable(quantity);
            }
            else
            {
                return new Meat(quantity);
            }
        }
    }
}
