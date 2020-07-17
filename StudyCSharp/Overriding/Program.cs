using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class ArmorSuite
    {
        public virtual void Initalize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initalize()
        {
            base.Initalize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initalize()
        {
            base.Initalize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArmorSuite armorSuite = new ArmorSuite();
            armorSuite.Initalize();

            ArmorSuite ironMan = new IronMan();
            ironMan.Initalize();

            ArmorSuite warMachine = new WarMachine();
            warMachine.Initalize();
        }
    }
}
