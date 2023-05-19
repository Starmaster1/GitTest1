using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public class House
    {
        public event EventHandler PriceChanged;
        public string Name { get; set; }
        public double Price { get; set; }

        public House(string Name, int price)
        {
            this.Name = Name;
            this.Price = price;
        }
        public double GetPrice()
        {
            return this.Price;
        }
        public void SetPrice(int price)
        {
            this.Price = price;
            PriceChanged?.Invoke(this, EventArgs.Empty);
        }


    }
}
