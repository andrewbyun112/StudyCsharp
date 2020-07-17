using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = sbyte.MaxValue;
            WriteLine($"a = {a} ");
            int b = a;
            WriteLine($"b = {b}");


            int x = 128;            
            WriteLine($"x = {x}");
            //           sbyte y = x;                큰타입을 작은타입에 넣을 수 없음
            sbyte y = (sbyte)x;
            WriteLine($"y = {y}");
        }
    }
}
