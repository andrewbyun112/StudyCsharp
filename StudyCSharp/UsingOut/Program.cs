using System;

namespace UsingOut
{
    class Program
    {
        static void Divide(int a, int b, out int quontient, out int remainder)
        {
            quontient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20, b = 3;
            Divide(a, b, out int c, out int d);
            Console.WriteLine($"a : {a}, b : {b}, c : {c}, d : {d}");
        }
    }
}
