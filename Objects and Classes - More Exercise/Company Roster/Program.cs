using System;
using System.Collections.Generic;
using System.Linq;

namespace Objects_and_Classes___More_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Departments> departments = new List<Departments>();
            for (int i = 1; i <= n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string employersName = tokens[0];
                decimal salary = decimal.Parse(tokens[1]);
                string departmentName = tokens[2];
                if (!departments.Any(department => department.DepartmentName == departmentName))
                {
                    Departments department = new Departments()
                    {
                        DepartmentName = departmentName,
                    };
                    departments.Add(department);
                }
                departments.Find(department => department.DepartmentName == departmentName).AddEmployees(employersName, salary);
            }
            Departments bestDepartment = departments.OrderByDescending(department => department.totalSalary / department.Employees.Count).First();
            Console.WriteLine($"Highest Average Salary: {bestDepartment.DepartmentName}");
            foreach (Employee employee in bestDepartment.Employees.OrderByDescending(employee => employee.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }
    class Employee
    {
        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
    class Departments
    {
        public Departments()
        {
            Employees = new List<Employee>();
        }
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
        public decimal totalSalary { get; set; }
        public void AddEmployees(string name, decimal salary)
        {
            this.totalSalary += salary;
            this.Employees.Add(new Employee(name, salary));
        }
        public Departments(string departmentName)
        {
            this.DepartmentName = departmentName;
        }
    }
}
