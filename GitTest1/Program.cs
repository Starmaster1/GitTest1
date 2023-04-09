// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // My homework №1.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?"); 
            var name = Console.ReadLine();
            Console.WriteLine("Hello, "+name);
        }
    }
}