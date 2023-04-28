using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home8
{
    public class Product
    {

        public string Title { get; set; }
        public int Calories { get; set; }
        
        public Product(string key, int value)
        {
            this.Title = key;
            this.Calories = value;
        }
        public void ProductInfo()
        {
            Console.WriteLine($"{this.Title} = {this.Calories} Calories");
        }


        public override bool Equals(object? obj)
        {
            return obj is Product product &&
                   Title == product.Title;
        }
    }
}
