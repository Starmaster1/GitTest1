using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Home7
{
    public class Cook : Employee, ICooking, ICleaning
    {
        protected string job = "Cook";
        public Cook() { }

        /// <summary>
        /// Метод для готовки для повара
        /// </summary>
        public void ToCook()
        {
            Console.WriteLine($"{job} {this.ToString()} is cooking");
        }
        /// <summary>
        /// Метод для уборки проваром
        /// </summary>
        public void ToClean()
        {
            Console.WriteLine($"{job} {this.ToString()} is cleaning");
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
