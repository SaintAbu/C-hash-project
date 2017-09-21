using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 课堂例子
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("黄伟鹏","男",1997);
            person.Print();
            Teacher teacher = new Teacher("黄伟鹏","男",1997,"20142966",2014);
            teacher.Print();
        }
    }
}
