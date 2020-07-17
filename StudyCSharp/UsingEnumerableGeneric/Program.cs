using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System;

namespace UsingEnumerableGeneric
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        private int position = -1;

        public MyList()
        {
            array = new T[3];
        }
        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach (var item in str_list)
            {
                Console.WriteLine($"'{item}'");
            }
            Console.WriteLine();
        }
    }

}
