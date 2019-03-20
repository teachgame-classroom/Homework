using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_190319
{
    class Program
    {
        static void Main(string[] args)
        {
            Student xiaolang = new Student("小狼", "男", 17, 95, 95, 90);

            xiaolang.SayHello();
            xiaolang.PrintScore();

            Student s1 = new Student("小狼1", "男", 17, 60, 50, 40);
            s1.PrintScore();

            Student s2 = new Student("小狼2", "男", 17, 75, 88, 85);
            s2.PrintScore();
        }
    }
}
