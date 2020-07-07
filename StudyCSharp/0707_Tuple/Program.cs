using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0707_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = ("슈퍼맨", 56, "크립톤");
            Console.WriteLine($"{a.Item1}, {a.Item2}, {a.Item3}");
            Console.WriteLine($"{a.Item1.GetType()}, {a.Item2.GetType()}, {a.Item3.GetType()}");

            var b = (Name: "Andrew", Age: 30, Home : "부산");
            Console.WriteLine($"{b.Age}, {b.Name}, {b.Home}");

            b = a;
            Console.WriteLine($"{b.Age}, {b.Name}, {b.Home}");

            var (name, age, home) = b;
            Console.WriteLine($"{name}, {age}, {home}");
        }
    }
}
