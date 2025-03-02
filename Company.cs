using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    public class Company
    {
        private List<Employee> employees = new List<Employee>();
        
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine("Isci elave olundu.");
        }

        public void IncreaseSalary(decimal amount)
        {
            if (amount > 0)
            {
                foreach (var emp in employees)
                {
                    emp.Salary += amount;
                }
                Console.WriteLine($"Maaslar {amount} AZN mebelginde artirildi.");
                Console.WriteLine("Yeni Maaslar: ");
                foreach (var emp in employees)
                {
                    Console.WriteLine($"Name: {emp.Name}. Salary: {emp.Salary}");
                }
            }
            else
                Console.WriteLine("Artirilan mebleg musbet olmalidir.");
        }

    }
}
