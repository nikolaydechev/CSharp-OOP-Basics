using System;

namespace _05.DateModifiers
{
    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public string FirstDate
        {
            get { return this.firstDate; }
        }

        public string SecondDate
        {
            get { return this.secondDate; }
        }

        public DateModifier(string firstDate, string secondDate)
        {
            this.firstDate = firstDate;
            this.secondDate = secondDate;
        }

        public double GetDifferenceBetweenDates(DateModifier dateModifier)
        {
            return Math.Abs((DateTime.Parse(dateModifier.FirstDate) - DateTime.Parse(dateModifier.SecondDate)).TotalDays);
        }
    }
}
