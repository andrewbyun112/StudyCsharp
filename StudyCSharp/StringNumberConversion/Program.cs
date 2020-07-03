using System;
using System.Diagnostics;
using static System.Console;

namespace StringNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //int -> string
            int a = 12345;
            string b = a.ToString();
            WriteLine($"b = {b}");

            //float -> string
            float c = 3.141592f;
            string d = c.ToString();
            WriteLine($"d = {d}");

            //string -> int
            string e = "123456";
            int f = Convert.ToInt32(e);
            WriteLine($"f = {f}");

            //string -> float
            string g = "3.141592";
            float h = float.Parse(g);
            WriteLine($"h = {h}");

            //error  
            //string -> 맞지 않은 int값
            //string i = "123456*";
            //int j = Convert.ToInt32(i);
            //WriteLine($"j = {j}");

            string k = "123456*";
            int l;
            if (int.TryParse(k, out l))
            {
                WriteLine($"l = {l}");
            }
            else
            {
                WriteLine("l 변환 시 에러발생, 문자열 확인 요망");
            }
            string m = "3:141592";
            float n;
            if(float.TryParse(m, out n))
            {
                WriteLine($"n = {n}");
            }
            else
            {
                WriteLine("m 변환 시 에러발생, 문자열 확인 요망");
            }
        }
    }
}
