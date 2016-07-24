using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCasting
{
    class MyBase
    {
        public virtual string Meth1()
        {
            return "MyBase-Meth1";
        }
        public virtual string Meth2()
        {
            return "MyBase-Meth2";
        }
        public virtual string Meth3()
        {
            return "MyBase-Meth3";
        }
    }
}
