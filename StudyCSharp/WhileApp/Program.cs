using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace WhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //while(true)
            //{
            //    Console.WriteLine("HelloWorld!");
            //}
            List<string> strings = new List<string>();
            strings.Add("Hello");
            strings.Add("Bye");
            strings.Add("Hey~"); 
            //하나하나 넣을 때

            List<string> subs = new List<string> { "Banana", "Strawberry" };
            strings.AddRange(subs);
            //한꺼번에 넣을 때

            foreach(var item in strings)
            {
                WriteLine(item);
            }
        }
    }
}
