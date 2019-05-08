using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础练习
{
    class 字符索引
    {
        //有如下字符串：“患者：“大夫，我咳嗽的很重。”   大夫：“你多大年纪？”    患者：“七十五岁。”  大夫：“二十岁咳嗽么？”  患者：“不咳嗽。”
        //大夫：“四十岁咳嗽么？”   患者：“也不咳嗽。”   大夫：“那现在不咳嗽，要等到什么时候咳嗽？”
        //1.统计出字符串中“咳嗽”出现的次数，以及每次“咳嗽”出现的索引位置；2.统计出每个字符出现的次数；
        public void SuoYin()
        {
            string msg = "患者：“大夫，我咳嗽的很重。”   大夫：“你多大年纪？”    患者：“七十五岁。”  大夫：“二十岁咳嗽么？”  患者：“不咳嗽。”" +
                         "大夫：“四十岁咳嗽么？”   患者：“也不咳嗽。”   大夫：“那现在不咳嗽，要等到什么时候咳嗽？”";
            //IndexOf()   查找索引,如果没有找到，返回-1
            int count = 0;     //“咳嗽”出现的次数
            int index = 0;      //“咳嗽”的索引位置
            while ((index = msg.IndexOf("咳嗽",index)) != -1)
            {
                count++;
                Console.WriteLine("第{0}次出现“咳嗽”的位置是：{1}",count,index);
                index = index + "咳嗽".Length;
            }
            Console.WriteLine("“咳嗽”总共出现了{0}次",count);
            

            Dictionary<char,int> dic=new Dictionary<char, int>();
            for (int i = 0; i < msg.Length; i++)
            {
                if (!dic.ContainsKey(msg[i]))
                {
                    dic.Add(msg[i],1);
                }
                else
                {
                    dic[msg[i]]++;
                }
            }

            foreach (KeyValuePair<char,int>item in dic)
            {
                Console.WriteLine("字符丨{0}丨出现的次数是:"+"  "+"{1}",item.Key,item.Value);
            }
            Console.ReadKey();
        }

    }
}
