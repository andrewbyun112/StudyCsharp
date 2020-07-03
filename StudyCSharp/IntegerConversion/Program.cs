using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IntegerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = sbyte.MaxValue;
            WriteLine($"a = {a}");

            int b = a;
            WriteLine($"b = {b}");

            int x = 128;
            WriteLine($"x = {x}");

            //sbyte y = x;      //error - int형식을 sbyte형식으로 변환할 수 없음
            sbyte y = (sbyte)x;
            WriteLine($"y = {y}");

        }
    }
}
