using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础练习
{
    class 控制台接收筛选
    {
        //制作一个控制台小程序，要求：用户可以在控制台输入学生姓名，当用户输入“quit”（不区分大小写）时，程序停止接收用户的输入，并显示用户输入的个数，以及每个学生的姓名
        //显示姓“王”的同学的个数；
        public void ShaiXuan()
        {
            string name = string.Empty;

            int count = 0;          //姓“王”的同学个数
            List<string> list=new List<string>();
            List<string> list1=new List<string>();
            do
            {
                Console.WriteLine("请输入学生姓名：");
                name = Console.ReadLine();

                if (name.IndexOf('王') == 0)
                {
                    count++;
                    list1.Add(name);
                }

                list.Add(name);
            } while (name.ToLower()!="quit");

            list.RemoveAt(list.Count-1);

            Console.WriteLine("共输入学生个数为{0}",list.Count);
            Console.WriteLine("他们分别是：");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("姓“王”的同学的个数为：{0}",count);
            Console.WriteLine("他们分别是：");

            foreach (string item1 in list1)
            {
                Console.WriteLine(item1);
            }

            Console.ReadKey();
        }
    }
}
