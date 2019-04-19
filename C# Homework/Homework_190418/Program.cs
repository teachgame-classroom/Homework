using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_190418
{
    class Program
    {
        static void Main(string[] args)
        {
            CarEngine carEngine = new CarEngine();
            Console.WriteLine("CarEngine IsOn : " + carEngine.IsOn());
            carEngine.TurnOn();
            Console.WriteLine("CarEngine IsOn : " + carEngine.IsOn());
            carEngine.TurnOff();
            Console.WriteLine("CarEngine IsOn : " + carEngine.IsOn());

            SuperEngine superEngine = new SuperEngine();
            Console.WriteLine("SuperEngine IsOn : " + superEngine.IsOn());
            superEngine.TurnOn();
            Console.WriteLine("SuperEngine IsOn : " + superEngine.IsOn());
            superEngine.TurnOff();
            Console.WriteLine("SuperEngine IsOn : " + superEngine.IsOn());

            Console.WriteLine("--------------------");

            CarEngine engine;

            engine = carEngine;

            engine.TurnOn();
            engine.TurnOff();

            Console.WriteLine("--------------------");

            engine = superEngine;

            engine.TurnOn();
            engine.TurnOff();

            Console.ReadKey();
        }
    }
}
