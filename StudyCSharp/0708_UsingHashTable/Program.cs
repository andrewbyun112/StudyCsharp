using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0708_UsingHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["이름"] = "변승재";
            ht["주소"] = "부산광역시 사하구";
            ht["전화번호"] = "010-2923-3120";
            ht["키"] = 178.0;
            ht["결혼여부"] = false;

            Console.WriteLine($"{ht["키"]:0.0}");
            Console.WriteLine($"{ht["결혼여부"]}");
        }
    }
}
