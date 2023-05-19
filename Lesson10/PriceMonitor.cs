using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public delegate void ShowPriceDelegate(int price);

    public class PriceMonitor
    {
        private readonly ShowPriceDelegate _showPriceDelegate;
        private readonly Random _random = new Random();

        public PriceMonitor(ShowPriceDelegate showPriceDelegate)
        {
            _showPriceDelegate = showPriceDelegate;
        }

        public void GeneratePrice()
        {
            int price = _random.Next(1000000, 5000000);
            _showPriceDelegate(price);
        }
    }
}
