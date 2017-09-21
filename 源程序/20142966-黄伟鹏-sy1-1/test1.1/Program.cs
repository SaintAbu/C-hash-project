using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请选择计算三角形 0， 长方形 1， 退出2");
            Console.WriteLine("请选择：");
            int select = Convert.ToInt32(Console.ReadLine());
            if (select == 0)
            {
                Console.WriteLine("请输入三角形的第一条边的长度：");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入三角形的第二条边的长度：");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入三角形的第三条边的长度：");
                int c = Convert.ToInt32(Console.ReadLine());
                double s, s1, area;
                s = a + b + c;
                s1 = s / 2;
                area = Math.Sqrt(s1 * (s1 - a) * (s1 - b) * (s1 - c));
                if (((a + b < c) || (a + c < b) || (b + c < a)))
                {
                    Console.WriteLine("不符合三角形");
                }
                else
                {
                   
                    Console.WriteLine("三角形的周长为：" + s + "\r\n");
                    Console.WriteLine("三角形的面积为：" + area + "\r\n");
                }
                
            }
            else if (select == 1)
            {
                Console.WriteLine("请输入长方形的长：");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入长方形的宽：");
                int b = Convert.ToInt32(Console.ReadLine());
                double s, area;
                s = (a + b) * 2;
                area = a * b;
                Console.WriteLine("长方形的周长为：" +s + "\r\n");
                Console.WriteLine("长方形的面积为：" + area+ "\r\n");
            }
        }
    }
}
