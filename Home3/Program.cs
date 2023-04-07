using System;
using System.Collections.Generic;

namespace Home3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task0();
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            Task7();
        }

        static void Task0()
        {
            int[] array = new int[] { 1, 4, 5, 6, 24, 1, 6, 3, 4, 4 };
            Console.WriteLine($"Enter number of array:");
            var number = Console.ReadLine();
            double valNumber;
            bool s = double.TryParse(number, out valNumber);
            if (s == false)
            {
                Console.WriteLine("Error: This is not a number!!!");
                return;
            }
            else if (valNumber < 0)
            {
                Console.WriteLine("Error: Nubmer must be > 0");
            }
            for (int i = 0; i < 10; i++)
            {
                if (array[i] == valNumber)
                {
                    Console.WriteLine("I found it!!");
                    return;
                }
            };
            Console.WriteLine("Array dosnt have the number :(");
        }

        static void Task1()
        {
            int[] array = { 1, 4, 5, 6, 24, 1, 6, 3, 4, 4 };
            int[] newArray = new int[10];

            Console.WriteLine("Old array: ");
            foreach (int i in array)
            {
                Console.Write($"{i},");
            }

            Console.WriteLine($" Enter number to delete from array:");
            var number = Console.ReadLine();
            bool s = int.TryParse(number, out int valNumber);
            if (s == false)
            {
                Console.WriteLine("Error: This is not a number!!!");
                return;
            }
            else if (valNumber < 0)
            {
                Console.WriteLine("Error: Nubmer must be > 0");
            }

            if (array.Contains(valNumber))
            {
                foreach (int element in array)
                {
                    newArray = array.Where(val => val != valNumber).ToArray();
                }
                Console.WriteLine($"  Array without {valNumber}: ");
                foreach (int element in newArray)
                {
                    Console.Write($"{element},");
                }
            }
            else
            {
                Console.WriteLine("Array dosnt have the number :(");
            }
        }

        static void Task2()
        {
            var rand = new Random();
            Console.WriteLine("Enter range of array: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int range) == false)
            {
                Console.WriteLine("Error: Wrong number!!!");
            }
            int[] array = new int[range];
            Console.WriteLine("Array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 20);
                Console.Write($"{array[i]},");
            }
            Console.WriteLine("\nAverage: " + array.Average());
            Console.WriteLine("Max: " + array.Max());
            Console.WriteLine("Min: " + array.Min());
        }

        static void Task3()
        {
            int[] array1 = { 1, 4, 4, 2, 4 };
            int[] array2 = { 2, 3, 7, 10, 40 };
            Console.WriteLine("First array is: ");
            foreach (int element in array1)
            {
                Console.Write($"{element},");
            };
            Console.WriteLine("\nSecond array is: ");
            foreach (int element in array2)
            {
                Console.Write($"{element},");
            };
            if (array1.Average() > array2.Average())
            {
                Console.WriteLine("\nAverage of first array is greater then second array");
            }
            else { Console.WriteLine("\nAverage of Second array is greater then first array"); }
        }

        public static void Task4()
        {
            int[] array = { 1, 4, 3, 2, 5 };
            Console.WriteLine("Array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]},");
            }
            Console.WriteLine("\nNew array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    array[i] = 0;
                }
                Console.Write($"{array[i]},");
            }
        }

        public static void Task5()
        {
            string[] maleName = { "Sasha", "Mike", "Paul", "Steven", "Alex", "Pasha" };
            string[] femaleName = { "Kate", "Nataly", "Jenna", "Julia", "Ann" };

            Console.WriteLine("\nMale names after sort: \n");
            Array.Sort(maleName);
            Array.Sort(femaleName);
            foreach (var item in maleName)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Female names after sort: \n");
            foreach (var item in femaleName)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void Task6()
        {
            int[] array = { 6, 3, 1, 8, 7 };
            Console.WriteLine("Unsorted array is: ");
            foreach (var item in array)
            {
                Console.Write($"{item},");
            }
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    }
                }
            }
            Console.WriteLine("\nSorted array is: ");
            foreach (var item in array)
            {
                Console.Write($"{item},");
            }
        }

        public static void Task7()
        {
            int[,] array = { { 3, 2 }, { 4, 5 }, { 6, 7 }, { 8, 9 }, { 10, 11 } };
            int[] sum = new int[array.GetLength(0)];
            Console.WriteLine("Numbers at array is:\n");
            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    sum[j] += array[j, i];
                    Console.Write($"{array[j, i]},");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Sum of numbers at 2D array is:");
            foreach (var item in sum)
            {
                Console.Write($"{item}, ");
            }
        }

    }
}