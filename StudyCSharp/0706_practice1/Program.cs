using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0706_practice1
{
    class Program
    {
        static double Square(double arg)
        {
            double result = arg * arg;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("수를 입력하세요 : ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);
            Console.WriteLine($"결과 : {Square(arg)}");
        }
    }
}
