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
            cal.Sum(10, 10);
            cal.Difference(10, 10);
            #endregion

            #region Medium taks
            //Medium task 1
            BankAccount bankAccount = new BankAccount(100);
            bankAccount.ShowBalance();
            bankAccount.Deposit(50);
            bankAccount.Withdraw(200);
            bankAccount.Withdraw(2);
            //Medium task 2
            Student std = new Student("Aslan", 20, 95);
            std.GetStudentInfo();
            // Medium task 3
            Employee emp = new Employee("Aslan", "Director", 10000);
            emp.EmployeeInfo();
            emp.IncreaseSalary(5000);
            //Rectangle
            Rectangle rec = new Rectangle(-10, 10);
            rec.CalculatePerimeter();
            rec.CalculateArea();
            #endregion

            #region Hard tasks
            // Hard task 1
            Customer customer = new Customer("Aslan");
            customer.add_Order(new Order(100));
            customer.add_Order(new Order(200));
            customer.TotalOrders();
            //Hard task 2
            Library library = new Library();
            library.AddBook(new Book("C#", "Aslan Memmedov"));
            library.AddBook(new Book("JAVA", "Aslan"));
            library.ShowBooks();

            var results_of_searching = library.Search_Books("C#");
            foreach (var book in results_of_searching)
            {
                Console.WriteLine($"{book.Title}. Author: {book.Author}");
            }
            //Hard task 3
            Company company = new Company();
            company.AddEmployee(new Employee("Aslan", "Team Leader", 2000));
            company.AddEmployee(new Employee("Razil", "Data Engineer", 3000));
            company.AddEmployee(new Employee("Nihad", "Php developer", 10000));
            company.IncreaseSalary(100);
            // Hard task 4
            Store st = new Store();
            st.AddProduct(new Product("Qelem", 1.5m));
            st.AddProduct(new Product("Pozan", 2.5m));
            st.AddProduct(new Product("Defter", 5));
            st.TotalAmount();
            #endregion
        }
    }  
}
