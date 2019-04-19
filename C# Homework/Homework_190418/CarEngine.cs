using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_190418
{
    class CarEngine
    {
        protected bool isOn;

        public CarEngine()
        {
            this.isOn = false;
            Console.WriteLine("创建引擎");
        }

        public virtual void TurnOn()
        {
            this.isOn = true;
            Console.WriteLine("引擎发动");
        }

        public virtual void TurnOff()
        {
            this.isOn = false;
            Console.WriteLine("引擎熄火");
        }

        public bool IsOn()
        {
            return isOn;
        }
    }
}
