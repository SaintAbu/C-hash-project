using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2._1
{
    class Employer : People
    {
        String Place;
        public Employer(String name, String age, String place)
        {
            this.Name = name;
            this.Age = age;
            this.Place = place;
        }
        public Employer() { }
        public new void work()
        {
            Console.WriteLine("职工的名字{0}，职工的年龄{1}，职工的地址{2}", Name, Age, Place );
        }
    }
}
