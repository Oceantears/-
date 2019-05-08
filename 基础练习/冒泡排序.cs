using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础练习
{
    class 冒泡排序
    {
        //通过冒泡排序对数组{1，3，5，7，90，2，4，6，8，10}实现升序排列
        public void PaiXu()
        {
            int[] arrInt = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            for (int i = 0; i < arrInt.Length-1; i++)            //i表示数组中已经排序了的数的个数
            {
                for (int j = 0; j < arrInt.Length - 1 - i; j++)    //j表示正在排序的数的位置
                {
                    if (arrInt[j] > arrInt[j + 1])
                    {
                        arrInt[j] = arrInt[j] + arrInt[j + 1];
                        arrInt[j + 1] = arrInt[j] - arrInt[j + 1];
                        arrInt[j] = arrInt[j] - arrInt[j + 1];
                    }
                }
            }
            Console.WriteLine("数组升序排列为：");
            foreach (int num in arrInt)
            {
                Console.Write(num+"  ");
            }

            Console.ReadKey();
        }
        

    }
}
