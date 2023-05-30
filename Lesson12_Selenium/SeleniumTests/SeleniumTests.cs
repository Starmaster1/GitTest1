using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Selenium.SeleniumTests
{
    [TestFixture]
    public class SeleniumTests : BaseTest
    {
        [Test]
        public void OpenWindow()
        {
            
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
            var expectedUrl = "https://the-internet.herokuapp.com/add_remove_elements/";
            //check url
            Assert.That(driver.Url, Is.EqualTo(expectedUrl));

            var addedbutton = driver.FindElement(By.TagName("button"));
            addedbutton.Click();
            addedbutton.Click();
            addedbutton.Click();
            addedbutton.Click();
            addedbutton.Click();
            Assert.IsNotNull(addedbutton);
            driver.FindElement(By.ClassName("added-manually")).Click();
        }
    }
}
