using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0708_DerivedFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 30, 20, 7, 1 };
            Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Base type of array : {array.GetType().BaseType}");
        }
    }
}
