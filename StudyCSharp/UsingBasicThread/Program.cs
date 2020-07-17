using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingBasicThread
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(500);
            }
        }
        static void DoAnything()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoAnything : {i}");
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(DoSomething));
            Thread thread1 = new Thread(new ThreadStart(DoAnything));

            Console.WriteLine("Starting thread...");
            thread.Start(); //스레드 시작 (DoSomething)호출
            thread1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(500);
            }
            Console.WriteLine("Waiting until thread stop...");
            thread.Join();

            Console.WriteLine("finished");
        }
    }
}
