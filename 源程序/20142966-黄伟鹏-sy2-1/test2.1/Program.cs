using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("小阿布", "8", "石家庄铁道大学");
            student.work();
            Employer employer = new Employer("阿布","18","石家庄北二环");
            employer.work();

        }
    }
}
