using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = ("슈퍼맨", 56, "크립톤");
            Console.WriteLine($"{a.Item1},{a.Item2},{a.Item3}");
            Console.WriteLine($"{a.Item1.GetType()},{a.Item2.GetType()},{a.Item3.GetType()}");

            var b = (Name: "손유진", Age: 25, Home: "부산");
            Console.WriteLine($"{b.Name},{b.Age},{b.Home}");
            b = a;
            Console.WriteLine($"{b.Name},{b.Age},{b.Home}");

            var (name, age, home) = GetInfo();
            Console.WriteLine($"{name},{age},{home}");
        }

        static Tuple<string, int, string> GetInfo()
        {
            return new Tuple<string, int, string>("손유진", 25, "부산");
        }
    }
}
