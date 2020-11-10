using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    //this class makes a sparrow.
    public class Sparrow : Bird, IFly
    {
        public Sparrow()
        {

        }
        public override string Eat()
        {
            return "Sparrow is now eating";
        }
        public override string MakeSound()
        {
            return "kuk kuk, kuk kuk";
        }
        public string Fly()
        {
            return "Sparrow is flying around";
        }
    }
}
