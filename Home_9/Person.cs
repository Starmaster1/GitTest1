using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9
{
    public class Person
    {
        private int _age;
        private int _salary;

        public string Name { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18)
                {
                    throw new AgeException($"{Name} Age must be at least 18");
                }
                _age = value;
            }
        }

        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value < 100)
                {
                    throw new SalaryException($"{Name} - Salary must be at least 100");
                }
                _salary = value;
            }
        }

        public Person(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
