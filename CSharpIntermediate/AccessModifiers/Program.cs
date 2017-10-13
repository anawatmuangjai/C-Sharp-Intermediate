using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1993, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
