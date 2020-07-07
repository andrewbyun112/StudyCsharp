using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0706_WhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 10;
            //while(i > 0)
            //{
            //    Console.WriteLine($"i : {i--}");
            //}
            List<string> strings = new List<string>();
            strings.Add("Hello");
            strings.Add("Bye");
            strings.Add("Hey");
            List<string> subs = new List<string> { "Banana", "strawberry" };
            strings.AddRange(subs);

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

        }
    }
}
