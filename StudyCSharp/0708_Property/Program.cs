using System;
using System.Security.Cryptography.X509Certificates;

namespace _0708_Property
{
    class BirthdayInfo
    {

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public string GetName()
        //{
        //    return this.name;
        //}
        //public void SetBirthday(DateTime birth)
        //{
        //    this.birthday = birth;
        //}

        //public DateTime GetBirthDay()
        //{
        //    return birthday;
        //}
        public string Name { get; set; } = "Unknown";

        public DateTime Birthday { get; set; } = new DateTime(1900, 1, 1);

        public string PhoneNumber { get; set; } = "010-0000-0000";

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo origin = new BirthdayInfo();
            Console.WriteLine($"{origin.Name}, {origin.Birthday}출생");
            Console.WriteLine($"{origin.Age}세");
            Console.WriteLine($"{origin.PhoneNumber}");


            BirthdayInfo info = new BirthdayInfo();
            //info.SetName("박서현");
            //info.SetBirthday(new DateTime(1991, 6, 28));
            //Console.WriteLine($"{info.GetName()}, {info.GetBirthDay()}출생");
            info.Name = "박서현";
            info.Birthday = new DateTime(1991, 6, 28);
            info.PhoneNumber = "010-1111-1111";
            Console.WriteLine($"{info.Name}, {info.Birthday}출생");
            Console.WriteLine($"{info.Age}세");
            Console.WriteLine($"{info.PhoneNumber}");

            var myIns = new { Name = "변승재", Home = "부산" };
            Console.WriteLine($"{myIns.Name} / {myIns.Home}");
            // myIns.Home = "부산";
            var b = new { Subject = "수학", Scores = new int[] { 99, 88, 77 } };
            Console.WriteLine($"{b.Subject}");
            foreach (var item in b.Scores)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
