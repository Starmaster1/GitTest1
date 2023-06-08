using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Selenium_WebDriver._Advanced.PageObject
{
    internal abstract class BasePage
    {
        protected WebDriver driver;
        public BasePage(WebDriver webDriver)
        {
            driver = webDriver;
        }
        public abstract void OpenPage();
    }
}
