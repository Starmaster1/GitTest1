namespace Home8
{
    public class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Alexander", 2000);
            RationCreator.CreateRation(person);
            person.CheckRation();
            person.PersonInfo();
            person.PersonRationInfo();
        }
    }
}