using System;
using System.Text;

namespace _03.Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHours = workHoursPerDay;
        }

        public decimal WorkingHours
        {
            get { return this.workHoursPerDay; }
            protected set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            protected set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }


        //public override string ToString()
        //{
        //    return $"First Name: {base.FirstName}\n" +
        //           $"Last Name: {base.LastName}\n" +
        //           $"Week Salary: {this.WeekSalary:F2}\n" +
        //           $"Hours per day: {this.WorkingHours:F2}\n" +
        //           $"Salary per hour: {this.weekSalary/(this.WorkingHours * 5M):F2}";
        //}
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.WorkingHours:f2}")
                .AppendLine($"Salary per hour: {this.weekSalary / (this.WorkingHours * 5M):F2}");

            return sb.ToString();
        }
    }
}
