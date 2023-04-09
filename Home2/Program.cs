using Microsoft.VisualBasic;
using System;

namespace Home2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Task1();
           Task2();
           Task3();
           Task4();

        }

        public static void Task1()
        {
            Console.WriteLine("Enter first operand:");
            
            var operand1 = Console.ReadLine();
            double valOperand1;
           bool s = double.TryParse(operand1, out valOperand1 );
            if ( s == false) {
                Console.WriteLine("Error: Wrong number!!!");
                return;
            }
            Console.WriteLine("Enter second operand:");
            var operand2 = Console.ReadLine();
            double valOperand2;
            s = double.TryParse(operand2, out valOperand2);
            if (s == false)
            {
                Console.WriteLine("Error: Wrong number!!!");
                return;
            }
            Console.WriteLine("Enter sign:");
            string sign = Console.ReadLine();
            double result = 0;
            switch (sign)
            {
                case "+": result = valOperand1 + valOperand2; break;  
                case "-": result = valOperand1 - valOperand2; break;  
                case "*": result = valOperand1 * valOperand2; break;  
                case "/": result = valOperand1 / valOperand2; break;
                default: Console.WriteLine("Error: Wrong sign!!"); return; 
            }
            Console.WriteLine($"Result = {result}");

        }
        public static void Task2()
        {
            Console.WriteLine("Enter number:");

            var number = Console.ReadLine();
            int valNumber;
            bool s = int.TryParse(number, out valNumber);
            if (s == false)
            {
                Console.WriteLine("Error: Wrong number!!!");
                return;
            }
            if (valNumber > 0 && valNumber <= 14)
            {
                Console.WriteLine("Your number is between 0 and 14");
            }
            else if (valNumber > 14 && valNumber <= 35)
            {
                Console.WriteLine("Your number is between 15 and 35");
            }
            else if (valNumber > 36 && valNumber <= 50)
            {
                Console.WriteLine("Your number is between 36 and 50");
            }
            else if (valNumber > 50 && valNumber <= 100)
            {
                Console.WriteLine("Your number is between 50 and 100");
            }
            else {
                Console.WriteLine("Your namber is out of range");
                    };


        }
        public static void Task3()
        {
            Console.WriteLine("Enter word:");

            string rWord = Console.ReadLine();

            switch (rWord)
            {
                case "погода": Console.WriteLine("wether"); break;
                case "дождь": Console.WriteLine("rain"); break;
                case "туман": Console.WriteLine("fog"); break;
                case "облачно": Console.WriteLine("cloud"); break;
                case "снег": Console.WriteLine("snow"); break;
                case "град": Console.WriteLine("hail"); break;
                case "тепло": Console.WriteLine("warm"); break;
                case "холодно": Console.WriteLine("cold"); break;
                case "гроза": Console.WriteLine("thunderstorm"); break;
                case "вьюга": Console.WriteLine("snowstorm"); break;
                default: Console.WriteLine("This word is absent in dictionary"); break;
            }
        }
        public static void Task4()
        {
            Console.WriteLine("Enter number:");

            var number = Console.ReadLine();
            int valNumber;
            bool s = int.TryParse(number, out valNumber);
            if (s == false)
            {
                Console.WriteLine("Error: Wrong number!!!");
                return;
            }
            if (valNumber%2 == 1 )
            {
                Console.WriteLine("Your number is not even number");
            }
            else
            {
                Console.WriteLine("Your number is even number");
            }
        }

    }
}