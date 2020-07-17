using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 20; //박싱
            object b = (int)a; //언박싱
        }
    }
}
