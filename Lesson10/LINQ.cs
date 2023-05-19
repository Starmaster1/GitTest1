using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public class LINQ
    {
        //public LINQ() { }
        
        /// <summary>
        /// LINQ 1
        /// </summary>
        /// <param name="words"></param>
        public void FirstOneLetter(List<string> words)
        {
            string result = words.Where(e => e.Length > 0 && e.Length < 2).First();
            Console.WriteLine(result);
        }

        /// <summary>
        /// LINQ 2
        /// </summary>
        /// <param name="words"></param>
        public void ContainsEE(List<string> words)
        {
            string result = words.Where(e => e.Contains("ee")).Last();
            Console.WriteLine(result);

        }
        /// <summary>
        /// LINQ 3
        /// </summary>
        /// <param name="words"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public void LastMinMax(List<string> words, int min, int max)
        {
            string result = words.Where(e => e.Length > min && e.Length < max).Last();
        }
        /// <summary>
        /// LINQ 4
        /// </summary>
        /// <param name="words"></param>
        public void CountUnicWords(List<string> words)
        {
            int count = words.Distinct().Count();
            Console.WriteLine(count);
        }
        /// <summary>
        /// LINQ 5
        /// </summary>
        /// <param name="words"></param>
        public void Skip4Contains3(List<string> words)
        {
            var results = words.Skip(4).Where(x => x.Contains("3"));
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// LINQ 6
        /// </summary>
        /// <param name="words"></param>
        public void ShortestWord(List<string> words)
        {
            int shortestWord = words.Select(s => s.Length).Min();
            Console.WriteLine(shortestWord);
        }
        /// <summary>
        /// LINQ 7 Dict to List
        /// </summary>
        /// <param name="words"></param>
        public void DictToList(List<string> words)
        {
        Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "apple", 1 },
            { "banana", 2 },
            { "cherry", 3 }
        };
        List<KeyValuePair<int, string>> list = dict.Select(x => new KeyValuePair<int, string>(x.Value, x.Key)).ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }

}
}
