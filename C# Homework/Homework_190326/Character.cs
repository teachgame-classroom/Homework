using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_190326
{
    public class Character
    {
        string name;
        int hp;
        int atk;
        Equipment equipment;

        public Character(string name, int hp, int atk)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
        }

        public void Hurt(int amount)
        {
            int equipmentDefense = 0;

            if(HasEquipment())
            {
                equipmentDefense = equipment.def;
            }

            int finalDamage = amount - equipmentDefense;

            finalDamage = Math.Max(finalDamage, 1);

            hp -= amount;
            Console.WriteLine("{0}受到了{1}点伤害，生命值减为{2}", name, amount, hp);
        }

        public void Attack(Character target)
        {
            int equipmentDamage = 0;

            if (HasEquipment())
            {
                equipmentDamage = equipment.atk;
            }

            int finalDamage = atk + equipmentDamage;

            target.Hurt(finalDamage);
        }

        private bool HasEquipment()
        {
            return equipment != null;
        }

        // 装备一件装备，grabByForce-强行抢夺已经被其他人装备的装备
        public void Equip(Equipment equipment, bool grabByForce)
        {
            // 装备没有被其他角色拥有的时候，直接装备
            if(equipment.owner == null)
            {
                // 如果当前有装备其他装备，要先把当前装备的装备的所有者设为空，再更换装备
                if(HasEquipment())
                {
                    this.equipment.owner = null;
                }

                this.equipment = equipment;
                equipment.owner = this;

                if (HasEquipment())
                {
                    Console.WriteLine("{0}装备了{1}", name, equipment.name);
                }
                else
                {
                    Console.WriteLine("无法装备！");
                }
            }
            else // 装备已经被其他人拥有的时候，如果“强行抢夺”为false，就无法装备，否则让其他人卸下装备，装备到自己身上
            {
                if(grabByForce == false)
                {
                    Console.WriteLine("{0}已经被{1}拥有，不能被{2}装备", equipment.name, equipment.owner.name, this.name);
                }
                else
                {
                    equipment.owner.UnEquip();
                    this.equipment = equipment;
                    equipment.owner = this;

                    if (HasEquipment())
                    {
                        Console.WriteLine("{0}装备了{1}", name, equipment.name);
                    }
                    else
                    {
                        Console.WriteLine("无法装备！");
                    }
                }
            }
        }

        public void UnEquip()
        {
            if(HasEquipment())
            {
                string equipmentName = equipment.name;
                equipment.owner = null;
                equipment = null;
                Console.WriteLine("{0}卸下了{1}装备", this.name, equipmentName);
            }
            else
            {
                Console.WriteLine("{0}没有装备可以卸下", this.name);
            }
        }
    }
}
