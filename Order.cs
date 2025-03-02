using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    public class Order
    {
        public decimal Amount { get; set; }
        public Order(decimal amount)
        {
            Amount = amount;
        }
    }
}
