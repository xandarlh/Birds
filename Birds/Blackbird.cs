using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    //this class makes a blackbird.
    public class Blackbird : Bird, IFly
    {
        
        public override string Eat()
        {
            return "Blackbird is now eating";
        }
        public override string MakeSound()
        {
            return "brr brr, skrrt skrrt";
        }
        public string Fly()
        {
            return "Blackbird is now flying around";
        }
    }
}
