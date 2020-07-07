using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _0706_IfElseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("숫자를 입력하세요 : ");
            string input = ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                if (number > 0)
                {
                    if (number % 2 == 0) {
                        WriteLine($"{number}는 짝수");
                    }
                    else {
                        WriteLine($"{number}는 홀수");
                    }
                }
            }
            else
            {
                WriteLine("입력값이 숫자가 아닙니다.");
                return;
            }
        }
    }
}
