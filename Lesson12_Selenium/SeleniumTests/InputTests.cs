using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Selenium.SeleniumTests
{
    [TestFixture]
    public class InputTests : BaseTest
    {
        [Test]
        public void EnterNubers()
        {
            driver.FindElement(By.LinkText("Inputs")).Click();
            var input = driver.FindElement(By.TagName("input"));
            input.SendKeys("100");

            input.Clear();

            input.SendKeys("48");
        }
    }
}
