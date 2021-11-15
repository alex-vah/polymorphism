using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived instance = new Derived();
            instance.Method();
            instance.NonVirtualMethod();

            Base instanceUp = instance;
            instanceUp.Method();
            instanceUp.NonVirtualMethod();

            Derived instanceDown = (Derived)instanceUp;
            instanceDown.Method();
            instanceUp.NonVirtualMethod();
        }
    }
}
