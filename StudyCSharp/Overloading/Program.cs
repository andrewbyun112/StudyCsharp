using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        /// <summary>
        /// double형 두 수를 더한다!
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Plus(double a, double b)
        {
            return a + b;
        }

        static double Plus(double a, int b)
        {
            return a + b;
        }

        static double Plus(float a, float b)
        {
            return a + b;
        }
        static int Sum(params int[] args)
        {
            int result = 0;
            foreach(var item in args)
            {
                result += item;
            }
            return result;
        }

        static void MyMethod(string arg1 = "",string arg2 = "")
        {
            Console.WriteLine("mymethod A");
        }

        static void MyMethod()
        {
            Console.WriteLine("mymethod B");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Plus(3.14f, 2.56f));
            //Console.WriteLine(Plus(3.14, 5.6));
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"Sum = {sum}");
            MyMethod();
        }
    }
}
