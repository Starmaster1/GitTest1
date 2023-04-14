using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    public class Student
    {
        public int id;
        public string name;
        public int age;
        public string group;
        public int mathMark;
        public int physicalEducationMark;
        public int biologyMark;
        public int reward;


        public Student(string name, int age, string group)
        {
            Random id = new Random();
            this.id = id.Next(1, 5);
            this.name = name;
            this.age = age;
            this.group = group;
            Random random = new Random();
            this.mathMark = random.Next(1, 5);
            Random mathMark = new Random();
            this.biologyMark = random.Next(1, 5);
        }

        public void WhoAreYou()
        {
            Console.WriteLine($"I am {name}, I`m {age}, and at group {group}");
        }

        public void SetMark()
        {
                Random random = new Random();
                int mark = random.Next(1,10);
                this.biologyMark = mark;
                mark = random.Next(1,10);
                this.mathMark = mark;
                mark = random.Next(1, 10);
                this.physicalEducationMark = mark;
            
        }

    }
}
