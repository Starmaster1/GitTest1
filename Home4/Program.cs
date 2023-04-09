using System.Data.SqlTypes;

namespace Home4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
        }
        /// <summary>
        /// 1. Задать строку содержащую внутри цифры и несколько повторений слова test, Заменить в строке все вхождения 'test' на 'testing'
        /// </summary>
        public static void Task1()
        {
            string s = "3241test21234test12343241test";
            string t = "test";
            string t1 = "testing";
            Console.WriteLine(s.Replace(t, t1));
        }
        /// <summary>
        /// 2. Создайте переменные, которые будут хранить следующие слова: 
        /// (Welcome, to, the, TMS, lessons)
        /// выполните конкатенацию слов и выведите на экран следующую фразу: 
        /// Welcome to the TMS lessons.
        /// </summary>
        public static void Task2()
        {
            string s1 = "Welcome";
            string s2 = "to";
            string s3 = "the";
            string s4 = "TMS";
            string s5 = "lessons";
            string b = " ";
            string result = string.Concat('"',s1,'"',b,'"',s2,'"',b, '"', s3, '"', b, '"', s4, '"', b, '"', s5, '"');
            Console.WriteLine(result);
        }
        /// <summary>
        /// 3. Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart, а также всё, что после них во вторую secondPart.
        /// Результат вывести в консоль.
        /// </summary>
        public static void Task3()
        {
            string text = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string toFind = "abc";
            string firstPart = text.Substring(0, text.IndexOf(toFind));
            string secondPart = text.Substring(text.IndexOf(toFind) + toFind.Length);
            Console.WriteLine($"First part: {firstPart}");
            Console.WriteLine($"First part: {secondPart}");
        }
        /// <summary>
        /// 4. Дана строка: Good day 
        /// Необходимо с помощью метода substring удалить слово "Good". 
        /// После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        /// Заменить последний "!" на "?" и вывести результат на консоль.
        /// </summary>
        public static void Task4()
        {
            string text = "Good day";
            string toSubstring = "Good";
            text = text.Substring(toSubstring.Length, text.Length - toSubstring.Length);
            text = text.Insert(0, "The Best");
            text = text.Insert(text.IndexOf("y") + 1, "!!!!!!!!!");
            text = text.Remove(text.Length - 1);
            text = text.Insert(text.Length, "?");
            Console.WriteLine(text);
        }
        /// <summary>
        /// 5. Введите с консоли строку, которая будет содержать буквы и цифры. 
        /// Удалите из исходной строки все цифры и выведите их на экран.(Использовать метод Char.IsDigit(), 
        /// его не разбирали на уроке, посмотрите, пожалуйста, документацию этого метода самостоятельно)
        /// </summary>
        public static void Task5()
        {
            Console.WriteLine("Enter a string, that contains a numbers and letters: ");
            string text = Console.ReadLine();
            if (text is null || text == "")
            {
                Console.WriteLine("You should enter something.");
            }
            string temp = "";
            foreach (var item in text)
            {
                if (Char.IsDigit(item))
                {
                    temp = string.Concat(temp,item);
                }
            }
            text = temp;
            Console.WriteLine(text);
        }
        /// <summary>
        /// 6. Задайте 2 предложения из консоли. 
        /// Для каждого слова первого предложения определите количество его вхождений во второе предложение.
        /// </summary>
        public static void Task6()
        {
            Console.WriteLine("Enter a first string: ");
            string text1 = Console.ReadLine();
            Console.WriteLine("Enter a second string: ");
            string text2 = Console.ReadLine();
            string[] words1 = text1.Split(' ');
            string[] words2 = text2.Split(' ');
            int counter = 0;
            //foreach (string word in words2)
            //{
            //    Console.WriteLine(word);
            //}
            foreach (string word in words1)
            {
                foreach (string word2 in words2)
                {
                    if (word.Equals(word2))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"{counter}");
        }
    }
}