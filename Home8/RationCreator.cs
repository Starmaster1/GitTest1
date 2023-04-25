using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home8
{
    public class RationCreator
    {
        private static readonly Random Random = new Random();

        private static readonly List<Product> Products = new List<Product>
    {
        new Product("Apple", 52),
        new Product("Banana", 89),
        new Product("Milk", 42),
        new Product("Brad", 265),
        new Product("Cheese", 402),
        new Product("Chicken", 165),
        new Product("Rise", 130),
        new Product("Quinoa", 120),
        new Product("Cucumber", 15),
        new Product("Tomato", 18),
        new Product("Salmon fillet", 200),
        new Product("Walnuts", 190),
        new Product("Strawberries", 50),
        new Product("Almonds", 200),
        new Product("Oatmeal", 150)
    };

        public static void CreateRation(Person person)
        {
            foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
            {
                var products = new List<Product>();
                var totalCalories = 0;
                Product productToAdd = Products[Random.Next(Products.Count)];

                while (totalCalories + productToAdd.Calories <= person.MaxNumberOfCalories)
                {
                    productToAdd = Products[Random.Next(Products.Count)];
                    if (totalCalories + productToAdd.Calories <= person.MaxNumberOfCalories)
                    {
                        products.Add(productToAdd);
                        totalCalories += productToAdd.Calories;
                    }
                }

                person.Ration.Add(dayOfWeek, products);
            }
        }
    }
}
