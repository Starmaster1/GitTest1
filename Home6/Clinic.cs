using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{
    public class Clinic
    {
        public string Title { get; set; }

        public Clinic(string title)
        {
            Title = title;
        }
        public void Registration(IlnessType ilnessType)
        {
            switch (ilnessType)
            {
                case IlnessType.Eyes:
                    Console.WriteLine("You should got go ophthalmologist");
                    break;
                case IlnessType.Teeth: 
                    Console.WriteLine("You should got go dentist");
                    break;
                case IlnessType.Other: 
                    Console.WriteLine("You should got go other doctor");
                    break;

            }
        }
    }
}
