using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    public class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public Customer(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }
        public void add_Order(Order order)
        {
            Orders.Add(order);
        }
        public void TotalOrders()
        {
            Console.WriteLine(Orders.Sum(order => order.Amount)); 
        }
    }
    public class Order
    {
        public decimal Amount { get; set; }
        public Order(decimal amount)
        {
            Amount = amount;
        }
    }
}
