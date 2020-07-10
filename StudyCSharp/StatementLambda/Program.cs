using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementLambda
{
    class Program
    {
        delegate string Concatnate(string[] args);

        static string StrJoin(string[] arr)
        {
            string result = string.Empty;
            foreach (var item in arr)
            {
                result += $"{item}";
            }
            return result;
        }
        static void Main(string[] args)
        {
            #region 심플람다
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
