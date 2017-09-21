using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2._1
{
     class Student:People 
    {
        String School;
        public Student(String name, String age, String school)
        {
            this.Name = name;
            this.Age = age;
            this.School = school;
        }
        public Student() { }
        public new void work()
        {
            Console.WriteLine("学生的名字{0}，学生的年龄{1}，学生的学校{2}",Name,Age,School);
        }
    }
}
