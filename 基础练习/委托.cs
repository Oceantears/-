using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础练习
{

    public delegate void PrintToString();

    class 委托
    {
 
        public void PrintStr(PrintToString print)
        {
            print();
        }

        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
}
