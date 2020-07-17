using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int Int)
        {
            return Int * Int;
        }
        public static int Power(this int Int, int exponent)
        {
            int result = Int;
            for (int i = 0; i < exponent; i++)
            {
                result *= Int;
            }
            return result;
        }
    }
}
