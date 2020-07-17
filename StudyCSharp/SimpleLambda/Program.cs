using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambda
{
    class Program
    {
        delegate int Calculate(int a, int b);
        delegate string Concatnate(string[] args);

        //static int Plus(int a, int b)
        //{
        //    return a + b;
        //}

        static string StrJoin(string[]arr)
        {
            string result = string.Empty; // = "";
            foreach (var item in arr)
            {
                result += $" {item}";
            }
            return result;
        }
        static void Main(string[] args)
        {
            #region 심플람다
            Calculate calc = (a, b) => a + b;
            Console.WriteLine(calc(3, 4));
            #endregion

            #region 불필요한 부분 주석처리
            //Concatnate concat = (arr) =>
            //{
            //    string result = string.Empty; // = "";
            //    foreach (var item in arr)
            //    {
            //        result += $" {item}";
            //    }
            //    return result;
            //};
            #endregion
            Concatnate concat = new Concatnate(StrJoin);
            Console.WriteLine(concat(args));
        }
    }
}
