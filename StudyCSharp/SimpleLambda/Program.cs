using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambda
{
    class Program
    {
        delegate int Calculate(int a, int b);

        //static int Plus(int a, int b)
        //{
        //    return a + b;
        //}
        static void Main(string[] args)
        {
            //Calculate calc = new Calculate(Plus);
            Calculate calc = (a, b) => a + b;
            Console.WriteLine(calc(3, 4));
        }
    }
}
