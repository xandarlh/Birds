using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public abstract class Bird
    {       
        public Bird()
        {

        }
        public abstract string Eat();
        public abstract string MakeSound();
    }
}
