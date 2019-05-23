using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础练习
{



    class Program
    {
        static void Main(string[] args)
        {
            //冒泡排序 maopao=new 冒泡排序();
            //maopao.PaiXu();

            //字符索引 suoyin=new 字符索引();
            //suoyin.SuoYin();

            //去空格 quKongGe=new 去空格();
            //quKongGe.QuKongGe();

            //控制台接收筛选 kongZhi=new 控制台接收筛选();
            //kongZhi.ShaiXuan();


            //int x = 1;
            //int y = (x++) + (x++);
            //int z = (++x) + (++x);
            //Console.WriteLine("输出结果x={0},y={1},z={2}",x,y,z);
            //Console.ReadKey();

            //B b=new B();
            //Console.ReadKey();

            委托 weituo=new 委托();

            PrintToString method = weituo.Method1;
            weituo.PrintStr(method);

            method += weituo.Method2;
            weituo.PrintStr(method);

            Console.ReadKey();

        }
    }
}
