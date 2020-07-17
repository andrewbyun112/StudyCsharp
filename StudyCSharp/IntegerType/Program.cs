using static System.Console;

namespace IntegerType
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte a = sbyte.MaxValue;          //signed byte
            //byte b = byte.MinValue;

            //short c = short.MinValue;
            //ushort d = ushort.MinValue;

            //int e = int.MinValue;
            //uint f = uint.MinValue;

            //long g = long.MinValue;
            //ulong h = ulong.MinValue;
            //ulong i = 200_0000_0000;

            //WriteLine(i);

            //byte a = 240;
            //WriteLine($"a={a}");

            //byte b = 0b1111_0000;
            //WriteLine($"b={b}");

            //byte c = 0XF0;
            //WriteLine($"C={c}");

            //uint d = 0X1234_abcd;
            //WriteLine($"d={d}");

            byte d = byte.MaxValue;
            WriteLine($"d={d}");
            d += 1;
            WriteLine($"d = {d}");
            d += 1;
            WriteLine($"d = {d}");

            float f = float.MaxValue;
            double g = double.MaxValue;
        }
    }
}
