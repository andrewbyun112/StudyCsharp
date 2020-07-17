using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterruptThread
{
    class SideTask
    {
        int count = 0;

        public SideTask(int count)
        {
            this.count = count;
        }
        public void KeepAlive()
        {
            try
            {
                Console.WriteLine("Running Thread isn't gonna be interrupted");
                //Thread.SpinWait(1000000000);

                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Console.WriteLine("Entering into WaitJoinSleep ...");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine(ex.Message);
                Thread.ResetAbort();
            }
            catch (ThreadInterruptedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Clearing resorce..");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(500);
            Thread th = new Thread(new ThreadStart(task.KeepAlive));
            th.IsBackground = false;

            Console.WriteLine("Starting thread...");
            th.Start();

            Thread.Sleep(100);

            //Console.WriteLine("Intterrupting thread...");
            //th.Interrupt();
            th.Suspend();

            Console.WriteLine("Waiting");
            Thread.Sleep(3000);
            th.Resume();

            Console.WriteLine("Waiting until thread stops...");
            th.Join();

            Console.WriteLine("Finished");
        }
    }
}
