using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; 
            Console.WriteLine("请输入你要判断的月份，或按 0 退出："); 
            a = int.Parse(Console.ReadLine()); 
            while (a != 0)
            {
                if (a > 12 || a <0)
                    Console.WriteLine("输入的月份不对"); 
                else if (a>=3&&a <=5)
                    Console.WriteLine("你输入的是春季：");
                else if (a >= 6&&a<=8)
                    Console.WriteLine("你输入的是夏季：");
                else if (a >= 9&&a<=11) 
                    Console.WriteLine("你输入的是秋季：");
                else if (a ==12||a<=2)
                    Console.WriteLine("你输入的是冬季："); 
                Console.WriteLine("请输入你要判断的月份，或按 0 退出：");
                a = int.Parse(Console.ReadLine());
            }
        }    
    }
}
