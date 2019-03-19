using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_190318
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("张三", "男", 18);
            human.ShowProfile();
            human.ChangeName("李四");
            human.ChangeAge(19);
            human.ShowProfile();

            Warrior warrior = new Warrior("关羽", 100, 70);
            warrior.ShowProfile();
            warrior.HpUp(25);
            warrior.AtkUp(10);
            warrior.ShowProfile();
            warrior.LevelUp(100, 50);
            warrior.ShowProfile();
            warrior.LevelUp(-100, -20);
            warrior.ShowProfile();
        }
    }
}
