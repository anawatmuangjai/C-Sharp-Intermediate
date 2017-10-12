using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace ObjectInitializers
{

    class Program
    {
        static void Main(string[] args)
        {
            // Object initializer
            var person = new Person
            {
                FirstName = "Anawat",
                LastName = "Muangjai"
            };

            Console.WriteLine("{0} {1}",person.FirstName, person.LastName);
        }
    }
}
