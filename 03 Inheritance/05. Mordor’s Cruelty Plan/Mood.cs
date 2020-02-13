namespace _05.Mordor_s_Cruelty_Plan
{
    abstract class Mood
    {
        private string mood;

        public Mood(string mood)
        {
            this.mood = mood;
        }

        public string MoodType
        {
            get { return this.mood; }
        }
    }
}
