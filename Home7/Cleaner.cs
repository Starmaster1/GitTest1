using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public class Cleaner:Employee, ICleaning
    {
        protected string job = "Cleaner";
        public Cleaner() { }

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
