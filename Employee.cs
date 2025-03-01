using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; private set; }
        public Employee(string name, string position, decimal salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }
        public void EmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}; position: {Position}; salary: {Salary}");
        }
        public void IncreaseSalary(decimal amount)
        {
            if (amount > 0)
            {
                Salary += amount;
                Console.WriteLine($"{Name}'s salary was increased by amount of {amount} AZN. Salary: {Salary} AZN.");
            }
            else
            {
                Console.WriteLine("Increasing amount must be positive number.");
            }
        }
    }
}
