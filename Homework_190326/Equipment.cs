using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_190326
{
    public class Equipment
    {
        public int id;
        public string name;
        public int atk;
        public int def;
        public int price;
        public string desc;
        public Character owner;

        public static Equipment CreateEquipmentFromInfo(string[] info)
        {
            int id = int.Parse(info[0]);
            string name = info[1];
            int atk = int.Parse(info[2]);
            int def = int.Parse(info[3]);
            int price = int.Parse(info[4]);
            string desc = info[5];

            Equipment newEquipment = new Equipment(id, name, atk, def, price, desc);

            return newEquipment;
        }

        public Equipment(int id, string name, int atk, int def, int price, string desc)
        {
            this.id = id;
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.price = price;
            this.desc = desc;
        }

        public void ShowSpec()
        {
            Console.WriteLine("id={0},name={1},atk={2},def={3},price={4},desc={5}", id, name, atk, def, price, desc);
        }
    }
}
