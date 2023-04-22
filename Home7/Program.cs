namespace Home7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant()
            {
                Title = "McDonalds",
                Description = "Fast food restaurant",
                Capacity = 10
            };
            restaurant.WellcomeTo();

            Cook cook = new Cook()
            {
                Name = "Alexander"
            };
            cook.ToCook();
            cook.ToClean();

            Manager manager = new Manager()
            {
                Name = "Sergey"
            };

            manager.ToManage();
            manager.ToCook();

            Cleaner cleaner = new Cleaner()
            {
                Name = "Natasha"
            };
            cleaner.ToClean();


        }
    }
}