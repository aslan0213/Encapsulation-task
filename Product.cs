using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    internal class Product
    {
        public string p_name { get; set; }
        private decimal p_price;

        public decimal p_Price
        {
            get { return p_price; }
            set { p_price = (value < 0) ? 0 : p_price = value; }
        }

        public Product(string name, decimal price)
        {
            p_name = name;
            p_price = price;
        }
    }
}
