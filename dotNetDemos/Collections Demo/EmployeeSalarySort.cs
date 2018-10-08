using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    class Employee : IComparable<Employee>
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee other)
        {
            if (this.Salary > other.Salary)
                return 1;
            else
                return -1;
        }
    }
    class EmployeeSalaryComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Salary > y.Salary)
                return 1;
            else
                return -1;
        }
    }
    class EmployeeSalarySort
    {
        static void Main()
        {
            List<Employee> eList = new List<Employee>
            {
                new Employee{ EmpId = 101, Name = "A", Salary = 8908},
                new Employee{ EmpId = 1011, Name = "A1", Salary = 5908},
                new Employee{ EmpId = 10111, Name = "A2", Salary = 3908},
                new Employee{ EmpId = 101111, Name = "A3", Salary = 1908}
            };
            eList.Sort();
            //eList.OrderBy();
            foreach( var emp in eList)
            {
                Console.WriteLine($"{emp.Name}    {emp.Salary}");
            }
        }
    }
}
