using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopy
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass
            {
                MyField1 = MyField1,
                MyField2 = MyField2
            };
            return newCopy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            {
                MyClass source = new MyClass
                {
                    MyField1 = 10,
                    MyField2 = 20       //힙에 field1 10, field2 20존재
                };

                MyClass target = source;
                target.MyField2 = 30;   //field2값이 바껴버림
                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Console.WriteLine("Deep Copy");
            {
                MyClass source = new MyClass
                {
                    MyField1 = 10,
                    MyField2 = 20       //힙에 field1 10, field2 20존재
                };

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;   //또 다른 힙에 field 10, field2 30존재
                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }
        
        }
    }
}
