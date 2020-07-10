using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLinq
{
    class Profile
    {
        public string Name { get; set; }
        public int Hieght { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Profile> profiles = new List<Profile>
            {
                new Profile {Name = "정우성", Hieght = 186},
                new Profile {Name = "김태희", Hieght = 158},
                new Profile {Name = "고현정", Hieght = 172},
                new Profile {Name = "이문세", Hieght = 178},
                new Profile {Name = "하동훈", Hieght = 171}
            };

            var newProfiles = from item in profiles
                              where item.Hieght < 175
                              orderby item.Name
                              select new
                              {
                                  Name = item.Name,
                                  InchHeight = item.Hieght * 0.393
                              };
            foreach (var item in newProfiles)
            {
                Console.WriteLine($"'{item.Name}', {item.InchHeight} inch");
            }
        }
    }
}
