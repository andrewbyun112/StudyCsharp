using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumApp
{
    class Program
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
        static void Main(string[] args)
        {
            WriteLine((int)DialogResult.YES);
            WriteLine((int)DialogResult.NO);
            WriteLine((int)DialogResult.CANCEL);
            WriteLine((int)DialogResult.CONFIRM);
            WriteLine((int)DialogResult.OK);
        }
    }
}
