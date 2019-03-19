using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_190318
{
    class Human
    {
        public string name;
        public string sex;
        public int age;

        public Human(string var_name, string var_sex, int var_age)
        {
            name = var_name;
            sex = var_sex;
            age = var_age;
        }

        public void ChangeName(string pNewName)
        {
            name = pNewName;
        }

        public void ChangeAge(int pNewAge)
        {
            age = pNewAge;
        }

        public void ShowProfile()
        {
            Console.WriteLine("姓名：" + name + "，性别：" + sex + "，年龄：" + age);
        }
    }
}
