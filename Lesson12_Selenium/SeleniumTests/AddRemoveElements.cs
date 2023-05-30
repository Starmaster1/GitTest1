using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_Selenium.SeleniumTests
{
    public class AddRemoveElements:BaseTest
    {

        [Test]
        public void AddRemove() {
            driver.FindElement(By.LinkText("Add/Remove Elements")).Click();
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Assert.That(driver.Url, Is.EqualTo(expectedUrl_AR));
            driver.FindElement(By.XPath("//*[@id=\"content\"]/div/button")).Click();
            driver.FindElement(By.XPath("//*[@id=\"content\"]/div/button")).Click();
            var deleteButton = driver.FindElement(By.XPath("//button[text()='Delete']"));
            Assert.IsNotNull(deleteButton);
            deleteButton.Click();

        }
    }
}
