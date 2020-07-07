﻿using System;
using System.IO;

namespace _0707_Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"[{now.ToLocalTime()})] {message}");
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            DateTime now = DateTime.Now;
            writer.WriteLine($"[{now.ToLocalTime()})] {message}");
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;

        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("온도 입력 : ");
                string temperature = Console.ReadLine();
                if (temperature == "q")
                {
                    break;
                }
                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            //ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());
            monitor.start();
        }
    }
}
