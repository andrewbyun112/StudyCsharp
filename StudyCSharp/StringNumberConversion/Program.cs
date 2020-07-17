using System;

namespace StringNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            string b = a.ToString();
            Console.WriteLine($"b = {b}");


            float c = 3.141592f;
            string d = c.ToString();
            Console.WriteLine($"d = {d}");


            string e = "123456";
            int f = Convert.ToInt32(e);
            Console.WriteLine($"f = {f}");


            string g = "3.141592";
            float h = float.Parse(g);
            Console.WriteLine($"h = {h}");

            //string i = "123456*";           //ERROR!! 
            //int j = Convert.ToInt32(i);

            string k = "123456*";
            int l;
            bool result = int.TryParse(k, out l);
            Console.WriteLine($"result = {result}");
            Console.WriteLine($"l = {l}");

            string i = "3,141592";
            float j;
            if (float.TryParse(i, out j))
            {
                Console.WriteLine($"j = {j}");
            }
            else
            {
                Console.WriteLine("i변환시 에러 발생, 문자열 확인 요망");
            }
        }
    }
}
