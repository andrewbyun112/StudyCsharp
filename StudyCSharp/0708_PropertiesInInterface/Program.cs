﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0708_PropertiesInInterface
{
    interface INamedValue
    {
        string Name { get; set; }
        string Value { get; set; }
        string GetOtherValue();
    }

    abstract class Product
    {
        private static int Serial = 0;

        public string SerialID
        {
            get { return String.Format($"{Serial++:d5}"); }
        }

        abstract public DateTime ProductDate { get; set; }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate { get; set; }
    }

    class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public string GetOtherValue()
        {
            return "Value";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue
            {
                Name = "이름",
                Value = "변승재"
            };
            NamedValue height = new NamedValue
            {
                Name = "키",
                Value = "178cm"
            };
            NamedValue weight = new NamedValue
            {
                Name = "몸무게",
                Value = "70kg"
            };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}
