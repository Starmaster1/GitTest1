using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Selenium.SeleniumTests
{
    internal class CheckboxTests : BaseTest
    {
        [Test]
        public void CheckBox()
        {
            driver.FindElement(By.LinkText("CheckBoxes")).Click();

            List<IWebElement> checkBoxes = driver.FindElements(By.TagName("input")).ToList();
            Assert.IsNotEmpty(checkBoxes);


        }
    }
}
