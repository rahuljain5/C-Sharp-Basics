using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProgrammingDemo
{
    class Employee : Person
    {
        public SalaryCalculator TheSalaryCalculator { get; set; }
        public Employee()
        {
            Address = new Address();
        }
    }
}
