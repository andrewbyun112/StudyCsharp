using static System.Console;

namespace IntegralTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            sbyte a = sbyte.MaxValue;
            byte b = byte.MinValue;

            short c = short.MinValue;
            ushort d = ushort.MaxValue;

            int e = int.MinValue;
            uint f = uint.MaxValue;

            long g = long.MaxValue;
            ulong h = ulong.MaxValue;

            ulong i = 20_000_000_000;

            WriteLine($"a = {a}\nb = {b}\nc = {c}\nd = {d}\ne = {e}\nf = {f}\ng = {g}\nh = {h}\ni = {i}");
            */

            //byte a = 255;
            //WriteLine($"a = {a}");
            //byte b = 0b1111_1111;
            //WriteLine($"b = {b}");
            //byte c = 0xFF;
            //WriteLine($"c = {c}");

            /*
            byte d = byte.MaxValue;
            WriteLine($"d = {d}");
            //overflow
            d += 1;                             
            WriteLine($"d = {d}");
            d += 1;                             
            WriteLine($"d = {d}");

            float f = float.MaxValue;
            double g = double.MaxValue;
            WriteLine($"f =  {f}, g = {g}");
            */

            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';

            Write(a);
            Write(b);
            Write(c);
            Write(d);
            Write(e);
            WriteLine();

            string f = "안녕하세요?";
            WriteLine(f);
        }
    }
}
