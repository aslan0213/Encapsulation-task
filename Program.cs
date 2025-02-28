namespace Encapsulation_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Simple tasks
            // Simple task 1
            Person p1 = new Person("Aslan", 20);
            p1.ShowInformation();
            // Simple task 2
            Car car = new Car("Mercedes", 2020);
            car.ShowInfo();
            //Simple task 3
            Calculator cal = new Calculator();
            cal.Sum(10,10);
            cal.Difference(10,10);
            #endregion


        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person (string name, int age)
        {
            this.Age = age;
            this.Name = name;
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Name: {Name}, age: {Age}");
        }

    }

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

    public class Calculator
    {
       
        public void Difference(double a,double b)
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

    public class BankAccount
    {
        private decimal balance;
        public decimal Balance { get { return balance; } }
    }
}
