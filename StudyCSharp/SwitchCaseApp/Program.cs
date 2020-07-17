using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace SwitchCaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = null;
            string s = ReadLine();
            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;
            switch(obj)
            {
                case int i:
                    WriteLine($"{i}는 int 형식");
                    break;
                case float f when f >= 0:
                    WriteLine($"{f}는 0보다 큰 float 형식");
                    break;
                case float f:
                    WriteLine($"{f}는 0보다 작은 float 형식");
                    break;
                default:
                    WriteLine($"{obj}는 모르는 형식");
                    break;
            }
        }
    }
}
