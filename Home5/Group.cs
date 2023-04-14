using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5
{
    public class Group
    {
        public string groupName;

        public Group(string name)
        {
            this.groupName = name;
        }
        public Student[] CreateGroup(string[] names, string groupName)
        {
            this.groupName = groupName;
            Random random = new Random();
            Student[] arrayOfStudents = new Student[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                arrayOfStudents[i] = new Student(names[i], random.Next(18, 30), this.groupName);
            }
            return arrayOfStudents;
        }
        public void PrintGroup(Student[] arrayOfStudents)
        {
            Console.WriteLine("Student list:");
            foreach (var item in arrayOfStudents)
            {
                Console.WriteLine($"ID: {item.id}, Name: {item.name}, Age: {item.age}, Group: {item.group},\n Marks: Biology Mark: {item.biologyMark}, Math Mark: {item.mathMark}, PhysicalEducation Mark: {item.physicalEducationMark} Reward: {item.reward}");
            }
        }
        /// <summary>
        /// Метод для вывода студента с лучшей оценкой по Математике и установка вознаграждения
        /// </summary>
        /// <param name="arrayOfStudents"></param>
        public void BestMathMark(Student[] arrayOfStudents)
        {
            int max = 0;
            int counter = 0;
            foreach (var i in arrayOfStudents)
            {
                if (i.mathMark > max)
                {
                    max = i.mathMark;
                    ++counter;
                }
            }
            Console.WriteLine("Student of the best math mark is:");
            Console.WriteLine($"ID: {arrayOfStudents[counter].id}, Name: {arrayOfStudents[counter].name}, Math Mark: {arrayOfStudents[counter].mathMark}");
            Console.WriteLine("Set reward for biology mark:");
            var reward = Console.ReadLine();
            if (int.TryParse(reward, out arrayOfStudents[counter].reward) == false)
            {
                Console.WriteLine("Error: This is not a number!!!");
                return;
            }
            else if (arrayOfStudents[counter].reward < 0)
            {
                Console.WriteLine("Error: Reward value must be > 0");
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// Метод для вывода студента с лучшей оценкой по Physical Education
        /// </summary>
        /// <param name="arrayOfStudents"></param>
        public void BestPhysicalEduMark(Student[] arrayOfStudents)
        {
            int max = 0;
            int counter = 0;
            foreach (var i in arrayOfStudents)
            {
                if (i.physicalEducationMark > max)
                {
                    max = i.physicalEducationMark;
                    ++counter;
                }
            }
            Console.WriteLine("Student of the best Physycal Education mark is:");
            Console.WriteLine($"ID: {arrayOfStudents[counter].id}, Name: {arrayOfStudents[counter].name}, Math Mark: {arrayOfStudents[counter].physicalEducationMark}");
            Console.WriteLine("Set reward for Physical Education mark:");
            var reward = Console.ReadLine();
            if (int.TryParse(reward, out arrayOfStudents[counter].reward) == false)
            {
                Console.WriteLine("Error: This is not a number!!!");
                return;
            }
            else if (arrayOfStudents[counter].reward < 0)
            {
                Console.WriteLine("Error: Reward value must be > 0");
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// Метод для вывода студента с лучшей оценкой по Biology и установка вознаграждения
        /// </summary>
        /// <param name="arrayOfStudents"></param>
        public void BestBiologyMark(Student[] arrayOfStudents)
        {
            int max = 0;
            int counter = 0;
            foreach (var i in arrayOfStudents)
            {
                if (i.biologyMark > max)
                {
                    max = i.biologyMark;
                    ++counter;
                }
            }
            Console.WriteLine("Student of the best Physycal Education mark is:");
            Console.WriteLine($"ID: {arrayOfStudents[counter].id}, Name: {arrayOfStudents[counter].name}, Biology Mark: {arrayOfStudents[counter].biologyMark}");
            Console.WriteLine("Set reward for biology mark:");
            var reward = Console.ReadLine();
            if (int.TryParse(reward, out arrayOfStudents[counter].reward) == false)
            {
                Console.WriteLine("Error: This is not a number!!!");
                return;
            }
            else if (arrayOfStudents[counter].reward < 0)
            {
                Console.WriteLine("Error: Reward value must be > 0");
            }
            else
            {
                return;
            }

        }
        /// <summary>
        /// Метод для вывода средней оценки по Математике в группе 
        /// </summary>
        /// <param name="arrayOfStudents"></param>
        public void AverageMathMarks(Student[] arrayOfStudents)
        {
            int sum = 0;
            foreach (var i in arrayOfStudents)
            {
                sum += i.mathMark;
            }
            double avr = Convert.ToDouble(sum) / arrayOfStudents.Length;

            Console.WriteLine($"Average Math mark at group {this.groupName} is: {avr}");
        }
        /// <summary>
        /// Метод для вывода средней оценки по Биологии в группе 
        /// </summary>
        /// <param name="arrayOfStudents"></param>
        public void AverageBiologyMarks(Student[] arrayOfStudents)
        {
            int sum = 0;
            foreach (var i in arrayOfStudents)
            {
                sum += i.biologyMark;
            }
            double avr = Convert.ToDouble(sum) / arrayOfStudents.Length;

            Console.WriteLine($"Average Biology mark at group {this.groupName} is: {avr}");
        }
        public void AveragePhysicalEduMarks(Student[] arrayOfStudents)
        {
            int sum = 0;
            foreach (var i in arrayOfStudents)
            {
                sum += i.physicalEducationMark;
            }
            double avr = Convert.ToDouble(sum) / arrayOfStudents.Length;

            Console.WriteLine($"Average Physical Education mark at group {this.groupName} is: {avr}");
        }



    }
}
