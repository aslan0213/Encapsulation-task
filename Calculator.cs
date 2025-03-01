using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    public class Calculator
    {
        public void Difference(double a, double b)
        {
            double result = a - b;
            Console.WriteLine($"{a}-{b}={result}");
        }
        public void Sum(int a, int b)
        {
            double result = a + b;
            Console.WriteLine($"{a}+{b}={result}");
        }

    }
}
