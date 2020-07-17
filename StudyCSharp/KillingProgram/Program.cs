using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KillingProgram
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

                string svalue = "";
                Console.WriteLine($"{svalue}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"딴 예외 발생 : {ex.Message}");
                Console.WriteLine($"소스 중에 0으로 된 변수 잘 확인하세요~");
            }
            
            catch(Exception ex)
            {
                Console.WriteLine($"ㅁㄹ...,,{ex.Message}");
            }


        }
    }
}
