//교안에 없는 내용
using System;
using System.Globalization;
using static System.Console;


namespace StringSerachApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string greeting = "Good Morning, Good";
            WriteLine(greeting);

            WriteLine($"IndexOf 'Good' : {greeting.IndexOf("Good")}");  //Good이 어디에 속하는지?,문자열 위치
            WriteLine($"LastIndexOf 'Good' : {greeting.LastIndexOf("Good")}");//마지막 Good속한곳, 14번째
            WriteLine($"IndexOf 'n' : {greeting.IndexOf('n')}");//문자하나 위치 찾기
            WriteLine($"LastIndexOf 'n' : {greeting.LastIndexOf('n')}");//n 마지막 위치 찾기
            //StartWith
            WriteLine($"StartsWith 'Good' : {greeting.StartsWith("Good")}");
            WriteLine($"StartsWith 'Morning' : {greeting.StartsWith("Morning")}");
            //Contains
            WriteLine($"Contains 'Good' : {greeting.Contains("Good")}");
            //Repalce
            WriteLine($"Replace 'Morning' to 'Evening' : {greeting.Replace("Morning", "Evening")}");

            if(greeting.Contains("Morning"))
            {
                greeting.Replace("Morning", "Evening");
            }
            WriteLine($"ToLower : {greeting.ToLower()}");
            WriteLine($"ToUpper : {greeting.ToUpper()}");
            WriteLine($"Insert : {greeting.Insert(greeting.IndexOf("Morning") -1 , " Very")}");

            WriteLine($"Remove : '{"I don't Love You".Remove(2, 6)}'");
            WriteLine($"Trim : '{" No Space ".Trim()}'");
            WriteLine($"Trim : '{" No Space ".TrimStart()}'");
            WriteLine($"Trim : '{" No Space ".TrimEnd()}'");

            string codes = "MSFT,GOOG,AMZN,AAPL, RHT";
            var result = codes.Split(',');
            foreach(var item in result)
            {
                WriteLine($"each item {item.Trim()}");
            }
            WriteLine($"substring : {greeting.Substring(0, 4)}");
            WriteLine($"substring : {greeting.Substring(5)}");
            */

            /*
            WriteLine(string.Format("{0}DEF", "ABC"));
            WriteLine(string.Format("{0,-10}DEF", "ABC"));
            WriteLine(string.Format("{0,10}DEF", "ABC"));
            */
            DateTime dt = DateTime.Now;
            
            WriteLine(string.Format("{0:yyyy-MM-dd HH:mm:ss}", dt));
            WriteLine(string.Format("{0:y yy yyy yyyy}", dt));
            WriteLine(string.Format("{0:M MM MMM MMMM}", dt));

            WriteLine(dt.ToString("d/M/yyyy HH:mm:ss", new CultureInfo("en-US")));
            decimal mvalue = 27000000m;
            WriteLine(string.Format("price {0:C}", mvalue));
            WriteLine(string.Format($"price {mvalue:C}"));
            

            
        }
    }
}
