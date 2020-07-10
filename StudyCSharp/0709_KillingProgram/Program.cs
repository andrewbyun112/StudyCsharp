using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0709_KillingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int x = 100, y = 0;
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                y = 2;
                Console.WriteLine($"{x / y}");

                string origin = "RR";
                int val = int.Parse(origin);
                
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"예외가 발생했습니다. : {e.Message}");
                e.HelpLink = "https://docs.microsoft.com/ko-kr/dotnet/api/system.indexoutofrangeexception?view=netcore-3.1";
                Console.WriteLine($"도움말 링크 : {e.HelpLink}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"다른 예외 발생 : {e.Message}");
                Console.WriteLine($"소스 중에 0으로 된 변수 확인");
            }
            catch(Exception e)
            {
                Console.WriteLine($"또 다른 예외 발생 : {e.Message}");
            }
            Console.WriteLine("종료");
        }
    }
}
