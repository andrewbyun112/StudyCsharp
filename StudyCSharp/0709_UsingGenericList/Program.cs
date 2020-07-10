using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0709_UsingGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            list.RemoveAt(2);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            list.Insert(2, 2);

            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
