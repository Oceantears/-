using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 读取写入文件
{
    class Program
    {
        /// <summary>
        /// using和IDisponsable接口进行文件的写入和读取
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using (StreamWriter sw=new StreamWriter(new FileStream("num.txt",FileMode.Create,FileAccess.Write)))
            {
                sw.Write("I have a big hourse");
            }

            using (StreamReader sr=new StreamReader("num.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            Console.ReadKey();
        }
    }
}
