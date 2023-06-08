using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Selenium_WebDriver._Advanced.PageObject
{
    internal class Item : BasePage
    {
        public const string url = "https://www.saucedemo.com/inventory-item.html?id=0";

        public Item(WebDriver webDriver) : base(webDriver)
        {

        }
        public override void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }
        public void AddToCart()
        {

        }

    }
}
