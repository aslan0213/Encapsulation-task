using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Name: {Name}, age: {Age}");
        }

    }
}
