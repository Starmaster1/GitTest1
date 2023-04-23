using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public interface ICleaning
    {
        void ToClean()
        {
            Console.WriteLine("Is cleaning..");
        }
    }
}
