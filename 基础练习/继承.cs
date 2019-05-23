using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础练习
{
    class 继承
    {
        public 继承()
        {
            PrintFields();
        }

        public virtual void PrintFields() { }
    }

    class B:继承
    {
        private int x = 1;
        private int y;

        public B()
        {
            y = -1;
        }

        public override void PrintFields()
        {
            Console.WriteLine("x={0},y={1}",x,y);
        }
    }
}
