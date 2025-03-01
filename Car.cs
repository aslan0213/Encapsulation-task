using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    public class Car
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public Car(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Year: {Year}");
        }
    }
}
