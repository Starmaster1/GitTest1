using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home8
{
    public class Person
    {
        public string Name { get; set; }
        public int MaxNumberOfCalories { get; set; }
        public Dictionary<DayOfWeek, List<Product>> Ration { get; set; }

        public Person(string name, int maxNumberOfCalories)
        {
            Name = name;
            MaxNumberOfCalories = maxNumberOfCalories;
            Ration = new Dictionary<DayOfWeek, List<Product>>();
        }

        public void CheckRation()
        {
            foreach (var day in Ration)
            {
                var totalCalories = 0;
                foreach (var product in day.Value)
                {
                    totalCalories += product.Calories;
                }

                while (totalCalories > MaxNumberOfCalories)
                {
                    var productToRemove = day.Value[0];
                    day.Value.Remove(productToRemove);
                    totalCalories -= productToRemove.Calories;
                }
            }
        }
        public void PersonInfo()
        {
            Console.WriteLine($"{this.Name} - MAX {this.MaxNumberOfCalories} Calories");
        }
        public void PersonRationInfo()
        {
            Console.WriteLine($"{this.Name} have a week ration:");
            foreach (var item in this.Ration)
            {
            int totalCalories = 0;
                foreach (var product in item.Value)
                {
                Console.WriteLine($"{item.Key} - {product.Title}/{product.Calories}");
                    totalCalories += product.Calories;
                }
                Console.WriteLine($"Total Calories for week: {totalCalories}\n");
            }
        }
    }

}
