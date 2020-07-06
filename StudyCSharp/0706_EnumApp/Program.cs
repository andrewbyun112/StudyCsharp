using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0706_EnumApp
{
    class Program
    {
        enum DialogResult
        {
            YES = 10,
            NO = 20,
            CANCEL,
            CONFIRM,
            OK
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(DialogResult.OK);
            //Console.WriteLine((int)DialogResult.OK);
            DialogResult result = DialogResult.YES;
            if (result == DialogResult.YES)
            {
                Console.WriteLine("YES를 선택했습니다.");
            }

        }
    }
}
