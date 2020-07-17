using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    class Cat
    {
        public string Name;
        public Color Color;

        public void Meow()
        {
            Console.WriteLine($"{Name}, 야옹~");
        }

        public Cat(string name, Color color)
        {
            Name = name;
            Color = color;
        }
        
        //~Cat()
        //{
        //    Console.WriteLine("Destruct!!");
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Color = Color.White;
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");
        }
    }
}
