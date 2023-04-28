using System;

namespace Home9
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new() { "Alexander", "Andrew", "Mike", "Nataly", "Kate", "July" };
            List<int> age = new() { 30, 23, 17, 94, 43, 34 };
            List<int> salary = new() { 300, 23, 172, 940, 423, 3410 };
            List<Person> persons = new List<Person>();
            for (int i = 0; i < names.Count; i++)
            {
                try
                {
                    var person = new Person(names[i], age[i], salary[i]);
                    persons.Add(person);
                    Console.WriteLine($"{person.Name}, age: {person.Age} and salary: {person.Salary} was created");
                }
                catch (AgeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (SalaryException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("People with names, starts with A letter are:");
            var peopleWithA = persons.Where(p => p.Name.StartsWith("A"));
            foreach (var person in peopleWithA)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("People how younger 30y.o. and salary greater then 1000 are:");
            var youngRichPeople = persons.Where(p => p.Age < 30 && p.Salary > 1000);
            foreach (var person in youngRichPeople)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("There first man how older then 50y.o. is:");
            var oldPerson = persons.FirstOrDefault(p => p.Age > 50);
            if (oldPerson != null)
            {
                Console.WriteLine(oldPerson.Name);
            }


        }
    }
}