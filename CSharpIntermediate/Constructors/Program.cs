using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructors
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1,"Anawat");
            var order = new Order(1,"Apple");
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            foreach (var item in customer.Orders)
            {
                Console.WriteLine("Order ID: {0} , Product: {1}", item.Id, item.ProductName);
            }
        }
    }
}
