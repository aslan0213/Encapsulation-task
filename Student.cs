using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }

        public Student(string name, int age, double gpa)
        {
            Name = name;
            Age = age;
            GPA = gpa;
        }
        public void GetStudentInfo()
        {
            Console.WriteLine($"Name: {Name}; Age: {Age}; GPA: {GPA}");
            if (GPA > 90)
            {
                Console.WriteLine("Elaci telebe.");
            }
        }
    }
}
