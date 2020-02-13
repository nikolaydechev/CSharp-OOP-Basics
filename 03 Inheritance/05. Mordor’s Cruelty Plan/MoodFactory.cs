namespace _05.Mordor_s_Cruelty_Plan
{
    class MoodFactory
    {
        class Sad : Mood
        {
            public Sad() : base("Sad")
            {
            }
        }
        class Angry : Mood
        {
            public Angry() : base("Angry")
            {
            }
        }
        class Happy : Mood
        {
            public Happy() : base("Happy")
            {
            }
        }
        class JavaScript : Mood
        {
            public JavaScript() : base("JavaScript")
            {
            }
        }

        public static Mood GetCorrespondingMood(int moodFactor)
        {
            if (moodFactor < -5)
                return new Angry();
            else if (moodFactor <= 0)
                return new Sad();
            else if (moodFactor <= 15)
                return new Happy();
            else
                return new JavaScript();
        }
    }
}
