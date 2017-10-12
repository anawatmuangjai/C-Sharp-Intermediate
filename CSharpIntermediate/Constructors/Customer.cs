using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        // Overloading and this keyword is mean default constructor
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        // Overloading and this(id) keyword is mean previous constructor
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
