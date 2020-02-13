using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CompanyRoaster
{
    public class CompanyRoaster
    {
        public static void Main()
        {
            var departments = new List<Department>();
            var employees = new List<Employee>();
            var N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                var employeeData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var employee = new Employee(employeeData[0], double.Parse(employeeData[1]), employeeData[2], employeeData[3]);

                if (departments.All(x => x.DepartmentName != employeeData[3]))
                {
                    var department = new Department();
                    department.DepartmentName = employeeData[3];
                    department.Salaries.Add(double.Parse(employeeData[1]));
                    departments.Add(department);
                }
                else
                {
                    var currentDepartment = departments.First(x => x.DepartmentName == employeeData[3]);
                    currentDepartment.Salaries.Add(double.Parse(employeeData[1]));
                }

                string[] emailAndAge = employeeData.Skip(4).ToArray();

                string email = "";
                int age = 0;

                if (emailAndAge.Length >= 1)
                {
                    if (!string.IsNullOrEmpty(emailAndAge[0]))
                    {
                        var isAge = int.TryParse(emailAndAge[0], out age);

                        if (!isAge)
                        {
                            email = emailAndAge[0];
                            if (emailAndAge.Length > 1)
                            {
                                age = int.Parse(emailAndAge[1]);
                            }
                        }
                        else
                        {
                            age = int.Parse(emailAndAge[0]);
                            if (emailAndAge.Length > 1)
                            {
                                email = emailAndAge[1];
                            }
                        }
                    }
                }

                employee.Email = !string.IsNullOrEmpty(email) ? email : employee.Email;
                employee.Age = age != 0 ? age : employee.Age;

                employees.Add(employee);
            }

            var highestAverageSalaryDepartment = departments.OrderByDescending(x => x.Salaries.Sum()).FirstOrDefault();
            

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.DepartmentName}");

            foreach (var employee in employees
                                            .Where(x => x.Department == highestAverageSalaryDepartment.DepartmentName)
                                            .OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }


            /// SOLUTION WITHOUT DEPARTMENT CLASS //

            //var depart = employees
            //    .GroupBy(em => em.Department)
            //    .Select(gr => new
            //    {
            //        Name = gr.Key,
            //        AverageSalary = gr.Average(em => em.Salary),
            //        Employees = gr
            //    })
            //    .OrderByDescending(gr => gr.AverageSalary)
            //    .FirstOrDefault();
        }
    }
}
