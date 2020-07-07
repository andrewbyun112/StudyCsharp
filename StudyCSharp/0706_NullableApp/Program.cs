using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0706_NullableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = null; //int는 null을 허용하지 않는 값 형식
            int? a = null;
            double? b = null;
            float? c = null;
            string s = null;

            Console.WriteLine(a.HasValue);
            //Console.WriteLine(a.Value); //error
            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }
            Console.WriteLine(b == null);
            Console.WriteLine(s == null || s == "");
            Console.WriteLine(string.IsNullOrEmpty(s));
            Console.WriteLine(string.IsNullOrWhiteSpace(s));

            c = 3.141592f;
            if (c.HasValue)
            {
                Console.WriteLine($"c = {c.Value}");
            }
        }
    }
}
