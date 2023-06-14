using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selenium.Elements
{
    public class BaseElement
    {
        protected IWebDriver WebDriver => Browser.Instance.Driver;
        protected By locator;
        public IWebElement GetElement() => WebDriver.FindElement(locator);

        public BaseElement(By locator)
        {
            this.locator = locator;
        }

        public BaseElement(string xpath)
        {
            locator = By.XPath(xpath);
        }

        public object ClickElementViaJs()
        {
            return Browser.Instance.ExecuteScript("arguments[0].click();", GetElement());
        }
    }
}
