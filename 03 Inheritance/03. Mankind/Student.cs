using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            protected set
            {
                //bool digitsAndLetters =  Regex.IsMatch(value, "^[A-Za-z0-9]{5,10}$");
                //if (!digitsAndLetters)
                //{
                //    throw new ArgumentException("Invalid faculty number!");
                //}
                if (value.Length < 5 || value.Length > 10 || !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        //public override string ToString()
        //{
        //    return $"First Name: {base.FirstName}\n" +
        //           $"Last Name: {base.LastName}\n" +
        //           $"Faculty number: {this.FacultyNumber}\n";
        //}
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Faculty number: {this.FacultyNumber}");

            return sb.ToString();
        }
    }
}
