using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_PageObjectPattern.PageObject
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
