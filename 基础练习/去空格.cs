using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础练习
{
    class 去空格
    {
        //将字符串“    Hello        World,你    好 世界     ！      ”两端空格去掉，并且将其中的所有其他空格都换成一个空格；
        public void QuKongGe()
        {
            string msg = "    Hello        World,你    好 世界     !      ";
            msg = msg.Trim();                            //移除字符串前后的空格；
            string[] words = msg.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            msg = string.Join(" ", words);
            Console.WriteLine("========================" + msg + "======================");
            Console.ReadKey();
        }
    }
}
