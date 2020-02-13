namespace _06.Анималс
{
    class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            :base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return Sound.Dog;
        }
    }
}
