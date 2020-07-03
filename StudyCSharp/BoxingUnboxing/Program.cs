using static System.Console;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 20;      //boxing
            int b = (int)a;       //unboxing//unboxing할 때는 타입에 맞춰줘야함
            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
        }
    }
}
