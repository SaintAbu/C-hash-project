using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2._2
{
    public interface IShape
    {
        double Gramlength();
        double Area();
        int Sides{get;}
        void displayresult();
    }
    public interface Idisplayresult
    {
        void displayresult();
    }
    public class Square : IShape, Idisplayresult
    {
        private int sides;
        public int sidelength;
        public Square()
        {
            sides = 4;
        }
        public int Sides
        {
            get { return sides; }
        }
        public double Area() 	
        { return ((double)(sidelength * sidelength)); }
        public double Gramlength() 
        { return ((double)(Sides * sidelength)); }
      
        void IShape.displayresult() 
        {
            Console.WriteLine("\n计算正多边形的周长面积：");
            Console.WriteLine("正{0}边形", this.Sides);
            Console.WriteLine("边长是：{0}", this.sidelength);
            Console.WriteLine("周长是：{0}", this.Gramlength());
            Console.WriteLine("面积是：{0}", this.Area());
        }
       void Idisplayresult.displayresult()
        { 
            Console.WriteLine("显示图形"); 
        }
    }
    public class Circle : IShape, Idisplayresult
    {
        private int sides;
        public int sidelength;
        public Circle()
        {
            sides = 0;
        }
        public int Sides
        {
            get { return sides; }
        }
        public double Area()
        { return ((double)(sidelength * sidelength*3.14)); }
        public double Gramlength()
        { return ((double)(2 * sidelength*3.14)); }

        void IShape.displayresult()
        {
            Console.WriteLine("\n计算圆的周长面积：");
            Console.WriteLine("正{0}边形", this.Sides);
            Console.WriteLine("边长是：{0}", this.sidelength);
            Console.WriteLine("周长是：{0}", this.Gramlength());
            Console.WriteLine("面积是：{0}", this.Area());
        }
        void Idisplayresult.displayresult()
        {
            Console.WriteLine("显示图形");
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                Square tt = new Square();
                tt.sidelength = 6;
                IShape sh = ( IShape)tt;
                sh.displayresult();
                Idisplayresult dis1 = (Idisplayresult)tt;
                dis1.displayresult();
                Circle ll = new Circle();
                ll.sidelength = 6;
                IShape al = (IShape)ll;
                al.displayresult();
                Idisplayresult di = (Idisplayresult)ll;
                di.displayresult();
                Console.ReadLine();

            }
        }
   

}
