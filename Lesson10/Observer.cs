using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public class Observer
    {
        private House house;

        public Observer(House house)
        {
            this.house = house;
           house.PriceChanged += Update;
        }

        public void Update(object sender, EventArgs e)
        {
            Console.WriteLine("Price of house is changed to " + house.GetPrice());
        }
    }
}
