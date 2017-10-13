using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Anawat";
            Console.WriteLine(cookie["name"]);
        }
    }
}
