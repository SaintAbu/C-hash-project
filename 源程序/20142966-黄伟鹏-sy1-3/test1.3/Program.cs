using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n >= 1)
            {
                if (n % 2 == 0 && n % 3 == 0 && n % 4 == 0)
                {
                    break;
                }
                else
                {
                    n++;
                }
            }
             Console.WriteLine("这筐鸡蛋至少有{0}个", n+1 ); 
        }
    }
}
