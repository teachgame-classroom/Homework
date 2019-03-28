using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_190318
{
    class Warrior
    {
        public string name;
        public int hp;
        public int atk;

        public Warrior(string var_name, int var_hp, int var_atk)
        {
            this.name = var_name;
            this.hp = var_hp;
            this.atk = var_atk;
        }

        public void ChangeName(string pNewName)
        {
            name = pNewName;
        }

        public void Hurt(int pAtk)
        {
            hp = hp - pAtk;
            // 也可以写作 hp -= pAtk;
        }

        public void AtkUp(int pAmount)
        {
            if(pAmount > 0)
            {
                atk = atk + pAmount;
                // 也可以写作 atk += pAmount;
            }
        }

        public void HpUp(int pAmount)
        {
            if(pAmount > 0)
            {
                hp = hp + pAmount;
                // 也可以写作 hp += pAmount;
            }
        }

        public void LevelUp(int pHpUp, int pAtkUp)
        {
            HpUp(pHpUp);
            AtkUp(pAtkUp);
        }

        public void ShowProfile()
        {
            Console.WriteLine("姓名：" + name + "，生命值：" + hp + "攻击力：" + atk);
        }
    }
}
