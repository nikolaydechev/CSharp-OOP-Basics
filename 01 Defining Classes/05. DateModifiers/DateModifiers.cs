using System;

namespace _05.DateModifiers
{
    public class DateModifiers
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var dateMofifier = new DateModifier(firstDate, secondDate);
            double days = dateMofifier.GetDifferenceBetweenDates(dateMofifier);

            Console.WriteLine(days);
        }
    }
}
