using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Base
    {
        
        public virtual void Method()
        {
            Console.WriteLine("Method from Base class");
        }
        public void NonVirtualMethod()
        {
            Console.WriteLine("NV Base");
        }

    }
}
