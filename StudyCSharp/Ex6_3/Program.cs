using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_3
{
    class Program
    {
        public static void Main()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine($"{a} + {b} = {resultA}");

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);
           
            Console.WriteLine($"{x} + {y} = {resultB}");
        }

        /// <summary>
        /// int형 더하기
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        /// <summary>
        /// double형 더하기
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public static void Plus(double x, double y, out double z)
        {
            z = x + y;
        }
    }
}
