using static System.Console;

namespace CsharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                WriteLine("ex: HelloApp.exe <이름>");
                return;
            }
            WriteLine($"Hello, {args[0]}!");
        }
    }
}
