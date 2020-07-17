using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingFrom
{
    class subject
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }
    class Program
    {
        class Profile
        {
            public string Name { get; set; }
            public int Height { get; set; }
        }
        static void Main(string[] args)
        {
            #region using From
            //int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };
            //IEnumerable<int> result = from n in numbers
            //                          where n%2 == 0
            //                          orderby n
            //                          select n;
            ////var result = from n in numbers
            ////             where n % 2 == 0
            ////             orderby n
            ////             select n;      //==select *

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion


            #region usingProfiles
            //List<Profile> profiles = new List<Profile>
            //{
            //    new Profile{Name = "정우성", Height = 186 },
            //    new Profile{Name = "장동건", Height = 182},
            //    new Profile{Name = "원빈", Height = 173},
            //    new Profile{Name = "고현정",Height = 172},
            //    new Profile{Name = "이승기",Height = 181},
            //};
            //var newProfiles = from item in profiles
            //                  where item.Height > 175
            //                  orderby item.Name
            //                  select new
            //                  {
            //                      Name = item.Name,
            //                      InchHeight = item.Height * 0.393
            //                  };
            #endregion

            List<subject> subjects = new List<subject>
            {
                new subject {Name = "연두반", Score = new int[] {99,80,70,24,52 } },
                new subject {Name = "분홍반", Score = new int[] {60,45,87,72 } },
                new subject {Name = "파랑반", Score = new int[] {92,30,85,94 } },
                new subject {Name = "노랑반", Score = new int[] {90,88,0} },
            };

            var newSubjects = from c in subjects
                              from s in c.Score
                              where s < 60
                              orderby s
                              select new { c.Name, Lowest = s  };
            foreach (var item in newSubjects)
            {
                Console.WriteLine($"낙제 : {item.Name}, {item.Lowest}");
            }
        }
    }
}
