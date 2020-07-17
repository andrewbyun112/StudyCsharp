using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList { 123, 456, 789 };

            Hashtable ht = new Hashtable();
            ht["이름"] = "손유진";
            ht["주소"] = "부산광역시 부산 진구";
            ht["전번"] = "010-1234-5678";
            ht["키"] = 170.0;
            ht["결혼여부"] = false;

            Console.WriteLine($"{ht["결혼여부"]}");
        }
    }
}
