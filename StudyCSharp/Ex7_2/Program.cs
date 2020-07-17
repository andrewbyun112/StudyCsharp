using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_2
{
    class A
    {

    }
    class B : A
    {

    }
    class C
    {
        public static void Main()
        {
            A a = new A();
            B b = new B();
            A c = new B();
            //B d = new A(); 자식 클래스로 부모 클래스의 인스턴스를 만들 수 없음 !
        }
    }

   
}
