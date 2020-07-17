using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstraintsOnTypeParameters
{
    class StructArray<T> where T : struct //T는 값형식형태로 쓰겠다, class 하면 string만 가능
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }
    class RefArray<T> where T : class //T는 string만 가능
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }

    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base   //U는 Base클래스만 쓸 수 있음
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }
        public void CopyArray<T>(T[] source) where T:U //U나 Base나 차이없음,
        {
            source.CopyTo(Array, 0);    //복사
        }

    }

    class Program
    {
        public static T createInstance<T>() where T : new()
        {
            return new T();
        }
        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);   //int배열로 size3
            a.Array[0] = 0;
            RefArray<string> b = new RefArray<string>(3);   //string배열로 size3
            b.Array[0] = "Hello";

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = createInstance<Derived>();


        }
    }
}
