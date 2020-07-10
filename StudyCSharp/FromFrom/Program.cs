using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromFrom
{
    //class Profile
    //{
    //    public string Name { get; set; }
    //    public int Hieght { get; set; }
    //}

    class Subject
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Subject> subjects = new List<Subject>
            {
                new Subject {Name = "연두반", Score = new int[] {99, 80, 70, 24,52}},
                new Subject {Name = "분홍반", Score = new int[] {60, 45, 87, 72}},
                new Subject {Name = "파랑반", Score = new int[] {92, 30, 85, 94}},
                new Subject {Name = "노랑반", Score = new int[] {90, 88, 0 }},
            };
            var newSubjects = from s in subjects
                              from d in s.Score
                              where d < 60
                              orderby s.Name
                              select new { s.Name, Lowest = d };

            foreach (var item in newSubjects)
            {
                Console.WriteLine($"낙제 : {item.Name}, {item.Lowest}");
            }
        }
    }
}
