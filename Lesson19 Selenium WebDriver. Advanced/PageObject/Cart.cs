using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Selenium_WebDriver._Advanced.PageObject
{
    internal class Cart : BasePage
    {
        private By ShoppingCartLink = By.ClassName("shopping_cart_link");
        public const string url = "https://www.saucedemo.com/cart.html";

        public Cart(WebDriver webDriver) : base(webDriver)
        {

        }

        public override void OpenPage()
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ContinueShopping()
        {

        }
        public void Checkout()
        {

        }
        public void Remove()
        {

        }


    }
}
