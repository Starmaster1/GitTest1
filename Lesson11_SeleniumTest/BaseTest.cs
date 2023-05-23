using Lesson11_SeleniumTest.Calc;

namespace Lesson11_SeleniumTest
{
    public class BaseTest
    {
        protected double x = 0;
        protected double y = 0;
        protected Calculator calculator = new();
        protected double actual = 0;
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            Console.WriteLine("This is Onetime Setup");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This is setup");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("This is TearDown");
        }

        [OneTimeTearDown]
        public void OneTImeTearDown()
        {
            Console.WriteLine("This is OneTimeTearDown");
        }
    }
}
