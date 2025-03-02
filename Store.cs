using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_task
{
    internal class Store
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product p)
        {
            products.Add(p);
            Console.WriteLine($"Mehsul elave olundu.(Adi: {p.p_name}. Qiymeti: {p.p_Price}).");
        }
        public void TotalAmount()
        {
            decimal TotalAmount = 0;
            foreach (var product in products)
            {
                TotalAmount += product.p_Price;
            }
            Console.Write($"Mehsullarin umumi deyeri: {TotalAmount}");
        }
    }
}
