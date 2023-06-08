using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_PageObjectPattern.Core
{
    internal class Browser
    {

        private static Browser instance = null;
            private IWebDriver driver;
        public IWebDriver Driver { get { return driver; } }
        public static Browser  Instance { 
            get { 
                if(instance == null)
                {
                    instance = new Browser();
                }
                return instance; } }

        private Browser() {
            //choose browser

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless"); //Запуск в headless режиме, то есть без отображения GUI

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void NaigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
