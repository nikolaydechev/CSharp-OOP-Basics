namespace _05.Mordor_s_Cruelty_Plan
{
    class FoodFactory
    {
        public class Cram : Food
        {
            public Cram() : base(2)
            {
            }
        }

        public class Lembas : Food
        {
            public Lembas() : base(3)
            {
            }
        }

        public class Apple : Food
        {
            public Apple() : base(1)
            {
            }
        }

        public class Melon : Food
        {
            public Melon() : base(1)
            {
            }
        }
        public class HoneyCake : Food
        {
            public HoneyCake() : base(5)
            {
            }
        }
        public class Mushrooms : Food
        {
            public Mushrooms() : base(-10)
            {
            }
        }

        public class OtherFood : Food
        {
            public OtherFood() : base(-1)
            {
            }
        }


        public static Food GetFood(string food)
        {
            switch (food)
            {
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "apple":
                    return new FoodFactory.Apple();
                case "melon":
                    return new FoodFactory.Melon();
                case "honeycake":
                    return new FoodFactory.HoneyCake();
                case "mushrooms":
                    return new FoodFactory.Mushrooms();
                default:
                    return new FoodFactory.OtherFood();
            }
        }
    }
}
