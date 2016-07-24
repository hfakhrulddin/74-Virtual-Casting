using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCasting
{
    class MyDerived : MyBase
    {
        // Overrides the virtual method Meth1 using the override keyword:
        public override string Meth1()
        {
            return "MyDerived-Meth1";
        }
        // Explicitly hide the virtual method Meth2 using the new
        // keyword:
        public new string Meth2()
        {
            return "MyDerived-Meth2";
        }
        // Because no keyword is specified in the following declaration
        // a warning will be issued to alert the programmer that 
        // the method hides the inherited member MyBase.Meth3():
        public string Meth3()
        {
            return "MyDerived-Meth3";
        }
    }
}
