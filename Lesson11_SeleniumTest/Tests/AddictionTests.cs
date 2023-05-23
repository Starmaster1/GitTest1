using Lesson11_SeleniumTest.Calc;

namespace Lesson11_SeleniumTest.Tests
{
    [TestFixture]
    public class AddictionTests : BaseTest
    {

        Calculator calculator = new();
        [Test]
        [Description("Simple test for addiction")]
        [Category("Simple tests")]
        public void SumTest()
        {
            double x = 2;
            double y = 2;
            var actual = calculator.Add(x, y);
            Assert.That(actual, Is.EqualTo(4));
        }
        [TestCase(2, 1, 1)]
        [Description("Simple TesCase for addiction")]
        [Category("Simple TestCases")]
        public void SumTestCase(double expected, double x, double y)
        {
            var actual = calculator.Add(x, y);
            Assert.That(actual, Is.EqualTo(expected));
        }



    }
}