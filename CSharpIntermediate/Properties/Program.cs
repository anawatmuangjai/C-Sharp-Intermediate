using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Properties
{

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1993, 1, 1));
            Console.WriteLine(person.Age);
        }
    }
}
