using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBase mF = new MyBase();

            System.Console.WriteLine(mF.Meth1());
            System.Console.WriteLine(mF.Meth2());
            System.Console.WriteLine(mF.Meth3());
            Console.WriteLine();

            MyDerived mD = new MyDerived();

            System.Console.WriteLine(mD.Meth1());
            System.Console.WriteLine(mD.Meth2());
            System.Console.WriteLine(mD.Meth3());
            Console.WriteLine();

            MyBase mB = (MyBase)mD;

            System.Console.WriteLine(mB.Meth1());
            System.Console.WriteLine(mB.Meth2());
            System.Console.WriteLine(mB.Meth3());

            Console.ReadLine();
        }
    }
}
