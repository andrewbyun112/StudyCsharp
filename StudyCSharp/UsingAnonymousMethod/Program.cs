using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAnonymousMethod
{
    delegate int Compare<T>(T a, T b);
    class Program
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            //if (a > b) return 1;
            //else if (a == b) return 0;
            //else return -1;
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            //if (a < b) return 1;
            //else if (a == b) return 0;
            //else return -1;
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            T temp;

            for (int i = 0; i < DataSet.Length - 1; i++)
            {
                for (int j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };
            Console.WriteLine("sorting Ascending...");
            BubbleSort<int>(array, delegate (int a, int b)
            {
                return a.CompareTo(b);
            });

            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            Console.WriteLine("\nSorting descending...");
            BubbleSort<int>(array, delegate (int a, int b)
            {
                return a.CompareTo(b) * -1;
            });
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }

}
