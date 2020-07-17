using System;
using MyExtension;




namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"2^3 : {2.Square(3)}");

        }
    }
}
