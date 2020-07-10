using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace From
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Using From
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10, };
            IEnumerable<int> result = from n in numbers
                                      where n % 2 == 0
                                      orderby n ascending
                                      select n;
            foreach (var item in result)
                Console.WriteLine($"짝수 : {item}");
            #endregion

        }
    }
}
