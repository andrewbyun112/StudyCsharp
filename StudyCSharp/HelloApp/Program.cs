//using System;
using static System.Console; //class를 정적으로 이 프로그램 안에서 항상 쓰겠다고 선언

/// <summary>
/// HelloApp namespace
/// </summary>
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                //Console.WriteLine("ex: HelloApp.exe <이름>");       //Console에 alt+Enter해보기-> Console. 지우면 using System 필요없어짐
                WriteLine("ex: HelloApp.exe <이름>");
                return;
            }
            //Console.WriteLine("Hello, {0}!", args[0]);   //old version (using static System.Console; 안 쓴 경우)
            //Console.WriteLine($"Hello, {args[0]}!" );   //lastest version (using static System.Console; 안 쓴 경우)
            WriteLine($"Hello, {args[0]}!");                    //using static System.Console; 쓴 경우
        }
    }
}
