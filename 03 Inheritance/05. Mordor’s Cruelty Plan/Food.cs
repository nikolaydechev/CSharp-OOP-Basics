namespace _05.Mordor_s_Cruelty_Plan
{
    abstract class Food
    {
        //public abstract int FoodPoints { get; set; }

        protected int happinessPoints;

        public Food(int happinessPoints)
        {
            this.happinessPoints = happinessPoints;
        }

        public int HapinessPoints
        {
            get { return this.happinessPoints; }
        }
    }
}
