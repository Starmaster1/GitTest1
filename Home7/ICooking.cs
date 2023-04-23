using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public interface ICooking
    {
        virtual void ToCook(Employee cook) {
            Console.WriteLine("Is cooking..");

        }
    }
}
