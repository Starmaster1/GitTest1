using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    public class Therapist : Doctor
    {
        public Therapist(string name) : base(name)
        {
        }
        public override void Treat(IlnessType ilness)
        {

        }
    }
}
