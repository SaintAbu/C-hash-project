using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组中的数值,以空格分开");
            string str = Console.ReadLine();
            string[] sarr = str.Split(' ');
            float[] a = new float[sarr.Length];
            float q = 0, p = 0;
            for (int i = 0; i < sarr.Length; i++)
            {
                a[i] = float.Parse(sarr[i]);
                if (a[i] % 2 == 0)
                    q = q + a[i];
                else
                    p = p + a[i];
            }
                Console.WriteLine("奇数之和为：{0}", p);
                Console.WriteLine("偶数之和为：{0}", q);
        }
    }
}
