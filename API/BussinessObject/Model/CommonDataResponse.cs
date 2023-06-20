using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.BussinessObject.Model
{
    public class CommonDataResponse<T>
    {
        public bool Status { get; set; }
        public T Result { get; set; }
    }
}
