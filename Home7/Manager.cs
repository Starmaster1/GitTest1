using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public class Manager : Employee, ICooking, IManaging
    {
        protected string job = "Manager";
        public Manager() { }
        /// <summary>
        /// Метод для готовки для менеджера
        /// </summary>
        public void ToCook()
        {
            Console.WriteLine($"Manager {this.ToString()} is cooking");
        }
        /// <summary>
        /// Метод для управления менеджером
        /// </summary>
        public void ToManage()
        {
            Console.WriteLine($"Manager {this.ToString()} is managing");
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
