using System.Collections.Generic;

namespace _06.CompanyRoaster
{
    public class Department
    {
        private string department;
        private List<double> salaries;

        public Department()
        {
            this.salaries = new List<double>();
        }

        public string DepartmentName
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public List<double> Salaries
        {
            get { return this.salaries; }
            set { this.salaries = value; }
        }
    }
}
