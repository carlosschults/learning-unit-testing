using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUnitTesting
{
    public class Employee
    {
        public string Name { get; private set; }
        
        public string JobTitle { get; private set; }

        public decimal Salary { get; private set; }

        public Employee(string name, string jobTitle, decimal salary)
        {
            Name = name;
            JobTitle = jobTitle;
            Salary = salary;
        }

        public string Introduce()
        {
            return $"Hi! My name is {Name} and I work as a {JobTitle}.";
        }

        public void GiveRaise(decimal percentage)
        {
            Salary = Salary + (Salary * (percentage / 100));
        }
    }
}
