using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = null;       숫자형이나 정수형은 null허용안함!
            string a = null;    //string은 null값 허용!
            int? b = null;
            double? c = null;
            float? d = null;

            WriteLine(b.HasValue);
            WriteLine(c == null);
            //WriteLine(a == null || a == "");
            WriteLine(string.IsNullOrEmpty(a));
            

        }
    }
}
