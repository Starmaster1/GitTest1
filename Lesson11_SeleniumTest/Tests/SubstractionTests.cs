using Lesson11_SeleniumTest.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_SeleniumTest.Tests
{
    public class SubstractionTests : BaseTest
    {
        
        [Test]
        [Description("Simple test for addiction")]
        [Category("Simple tests")]
        public void SumTest()
        {
            double x = 2;
            double y = 2;
            var actual = calculator.Subtraction(x, y);
            Assert.That(actual, Is.EqualTo(0));
        }
        [TestCase(0, 1, 1)]
        [Description("Simple TesCase for addiction")]
        [Category("Simple TestCases")]
        public void SumTestCase(double expected, double x, double y)
        {
            var actual = calculator.Subtraction(x, y);
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
