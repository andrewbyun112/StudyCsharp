using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

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
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                if (value.Year >= DateTime.Now.Year)     //2021 2020
                {
                    birthday = DateTime.Now;
                }
                else
                { birthday = value; }
            }
        }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo info = new BirthdayInfo();
            //info.SetName("박서현");
            //info.SetBirthday(new DateTime(1991, 6, 28));
            //Console.WriteLine($"{info.GetName()}, {info.GetBirthDay()}출생");
            info.Name = "박서현";
            info.Birthday = new DateTime(1991, 6, 28);
            Console.WriteLine($"{info.Name}, {info.Birthday}출생");
            Console.WriteLine($"{info.Age}세");

            var myIns = new { Name = "손유진", Home = "부산" };
            Console.WriteLine($"{myIns.Name} / {myIns.Home}");

            var b = new { Subject = "수학", Scores = new int[] { 99, 88, 77 } };
            Console.WriteLine($"{b.Subject}");
            foreach (var item in b.Scores)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}

