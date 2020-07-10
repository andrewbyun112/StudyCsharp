using System;

namespace _0709_MyException
{
    class InvalidArgumentException : Exception
    {
        public object Argument { get; set; }
        public string Range { get; set; }
        public InvalidArgumentException()
        {            
        }

    }
}
