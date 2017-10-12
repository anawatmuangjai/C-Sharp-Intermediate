using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Anawat");
            person.Introduction("James");
        }
    }
}
