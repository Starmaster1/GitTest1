using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public class Restaurant
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public Manager Manager { get; set; }
        public Cook Cook { get; set; }
        public Cleaner Cleaner { get; set; }

        /// <summary>
        /// Wellcoming message
        /// </summary>
        public void WellcomeTo()
        {
            Console.WriteLine($"Wellocome to {Description} {Title}! \n Avaiable capacity is {Capacity}");
        }


    }
}
