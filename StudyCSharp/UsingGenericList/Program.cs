using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> intList = new List<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    intList.Add(i);
            //}

            //foreach (var item in intList)
            //{
            //    Write($"{item},");
            //}

            //intList.RemoveAt(2);
            //intList.Insert(3, 45);
            //WriteLine("");

            //foreach (var item in intList)
            //{
            //    Write($"{item},");
            //}
            //WriteLine("");

            //Queue<double> q = new Queue<double>();
            //q.Enqueue(11.1);
            //q.Enqueue(22.2);
            //q.Enqueue(33.3);
            //q.Enqueue(44.4);

            //while (q.Count > 0)
            //{
            //    WriteLine(q.Dequeue());
            //}

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic["하나"] = 1;
            dic["둘"] = 2;
            dic["셋"] = 3;
            dic["넷"] = 4;

            WriteLine(dic["하나"]);
        }
    }
}
