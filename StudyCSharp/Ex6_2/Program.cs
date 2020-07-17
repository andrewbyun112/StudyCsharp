using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_2
{
    class Program
    {
        public static void Main()
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, out mean);
            Console.WriteLine($"평균 : {mean}");
        }

        public static void Mean(double a, double b, double c, double d, double e, out double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
