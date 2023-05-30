using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lesson13_PageObjectPattern.Test
{
    internal class BaseTest
    {
        protected WebDriver driver;
        protected string expectedUrl_AR = "https://the-internet.herokuapp.com/add_remove_elements/";

        [SetUp]
        public void SetUp()
        {
           driver = new ChromeDriver();
           // driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TearDown]
        public void TearDown()
        {
            // driver.Close(); // Закрывает текущую вкладку
           // driver.Quit();
        }

    }
}
