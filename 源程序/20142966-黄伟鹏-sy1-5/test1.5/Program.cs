using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请选择：1.输入矩阵，0.退出"); 
            int flag = int.Parse(Console.ReadLine()); 
            while (flag == 1)
            {
                Console.WriteLine("请输入二维矩阵的行数和列数，用空格分开"); 
                string str = Console.ReadLine(); 
                string[] strr = str.Split(' '); 
                int row = int.Parse(strr[0]); 
                int column = int.Parse(strr[1]); 
                float[,] a = new float[row, column]; 
                Console.WriteLine("请输入二维矩阵元素："); 
                for (int i = 0; i < row; i++)
                {
                    string s = Console.ReadLine(); 
                    string[] ss = s.Split(' '); 
                    if (ss.Length != column) 
                    { 
                        Console.WriteLine("输入列数不对：");
                        break; 
                    } 
                    for (int j = 0; j < column; j++) 
                    { 
                        a[i, j] = float.Parse(ss[j]); 
                    }
                } 
                int c = 0; 
                for (int i = 0; i < row; i++)
                {
                    int maxj = 0;
                    for (int j = 0; j < column; j++) 
                    { 
                        if (a[i, j] > a[i, maxj]) 
                        { 
                            maxj = j;
                        } 
                    } 
                    int minx = 0; 
                    for (int j = 0; j < row; j++) 
                    { 
                        if (a[j, maxj] < a[minx, maxj])                            
                            minx = j; 
                    } 
                    if (a[i, maxj] == a[minx, maxj]) 
                    { 
                        Console.Write("马鞍点[{0}，{1}]：{2}" + '\n', minx, maxj, a[minx, maxj]); c++; 
                    }
                } 
                if (c == 0) 
                    Console.WriteLine("没有马鞍点数");
                else 
                {
                    Console.WriteLine("马鞍点总数为：" + c); 
                } 
                Console.WriteLine("请选择：1.输入矩阵，0.退出"); 
                flag = int.Parse(Console.ReadLine());
            } 
        }
    }
}
