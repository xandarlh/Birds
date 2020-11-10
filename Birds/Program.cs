using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird sparrow = new Sparrow();
            Console.WriteLine(sparrow.GetType().Name.ToString() + ":");
            Console.WriteLine(((IFly)sparrow).Fly());
            Console.WriteLine(sparrow.MakeSound());

            Console.WriteLine("");

            Bird blackbird = new Blackbird();
            Console.WriteLine(blackbird.GetType().Name.ToString() + ":");
            Console.WriteLine(((IFly)blackbird).Fly());
            Console.WriteLine(blackbird.MakeSound());
            Console.ReadLine();
        }
    }
}
