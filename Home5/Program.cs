using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Home5;

namespace Home5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string groupName1 = "band 1";
            string groupName2 = "band 2";
            string groupName3 = "band 3";
            string[] names1 = { "Alex", "Mike", "Nicole", "Nataly", "John" };
            string[] names2 = { "Alexei", "Conny", "Jane", "Ruslan", "Danny" };
            string[] names3 = { "Yang", "Polly", "Rob", "Steve", "John" };
            
            Group gr1 = new Group(groupName1);
            Group gr2 = new Group(groupName2);
            Group gr3 = new Group(groupName3);
            Student[] firstGroup = gr1.CreateGroup(names1, groupName1);
            Student[] secondGroup = gr1.CreateGroup(names2, groupName2);
            Student[] thirdGroup = gr1.CreateGroup(names3, groupName3);

            for (int i = 0; i < firstGroup.Length; i++)
            {
                firstGroup[i].SetMark();
            }
            for (int i = 0; i < secondGroup.Length; i++)
            {
                secondGroup[i].SetMark();
            }
            for (int i = 0; i < thirdGroup.Length; i++)
            {
                thirdGroup[i].SetMark();
            }

            gr1.PrintGroup(firstGroup);
            Console.WriteLine("----");
            gr1.BestMathMark(firstGroup);
            Console.WriteLine("----");
            gr1.AverageMathMarks(firstGroup);
            gr1.BestBiologyMark(firstGroup);
        }


    }
}