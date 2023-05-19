using System;

namespace Lesson10
{
    public class Program
    {
        static void Main(string[] args)
        {

            PriceMonitor monitor = new PriceMonitor(ShowPrice);
            monitor.GeneratePrice();

            //Observerable (event)
            House house = new House("House1", 100);
            Observer observer1 = new Observer(house);
            house.SetPrice(110);
            house.SetPrice(200);
            house.SetPrice(245);

            //LINQ 1
            List<string> words = new List<string>()
            {
                "Word",
                "String3",
                "B",
                "Plain",
                "Plain",
                "Queen",
                "Green",
                "Green3",
                "a",
                "333"
            };
            //LINQ1
            LINQ obj = new LINQ();
            obj.FirstOneLetter(words);
            //LINQ2
            obj.ContainsEE(words);
            //LINQ3
            obj.LastMinMax(words, 3, 5);
            //LINQ4
            obj.CountUnicWords(words);
            //LINQ5
            obj.Skip4Contains3(words);
            //LINQ6
            obj.ShortestWord(words);
            //LINQ7
            obj.DictToList(words);
        }
        public static void ShowPrice(int price)
        {
            Console.WriteLine($"A price for a housing: {price}");
        }
    }
}
