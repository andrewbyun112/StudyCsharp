using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0708_UsingArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //making array//리스트 맨 마지막 추가
            //ArrayList list = new ArrayList();
            ArrayList list = new ArrayList() { 123, 456, 789 };
            for (int i = 0; i < 10; i++)
            {
                //list.Add(i);
                int iresult = list.Add(i);
                Console.WriteLine($"{iresult}번째에 데이터 {i} 추가 완료");
            }
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            //remove//인덱스위치값 삭제
            list.RemoveAt(2); 

            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            //insert//인덱스위치에 값을 추가
            list.Insert(4, 4.5); 
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            //clear//전체 삭제
            list.Clear(); 
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
