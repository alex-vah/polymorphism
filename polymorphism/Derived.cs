using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Derived:Base
    {
        public override void Method()
        {
            base.Method();

            Console.WriteLine("Method from Derived");
        }
        public void NonVirtualMethod()
        {
            Console.WriteLine("NV derived");
        }
    }
}
