using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    public class Doctor
    {
        public string Name { get; set; }
        public Doctor(string name)
        {
            Name = name;

        }
        public virtual void Treat(IlnessType ilness)
        {
            
        }


    }
}
