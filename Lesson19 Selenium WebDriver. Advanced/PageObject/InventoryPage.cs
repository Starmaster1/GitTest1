using Lesson19_Selenium_WebDriver._Advanced.Core.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Selenium_WebDriver._Advanced.PageObject
{
    internal class InventoryPage : BasePage
    {
        private BaseElement CartLink = new(By.ClassName("shoping_cart_link"));

        private By AddToCartButton = By.Id("add-to-cart-sauce-labs-backpack");
        private By RemoveButton = By.XPath("//*[@id='remove-sauce-labs-backpack']");
        private By SortAZSelect = By.XPath("//*[@class='product_sort_container']/option[@value='az']");
        private By SortZASelect = By.XPath("//*[@class='product_sort_container']/option[@value='za']");
        private By SortLowToHighSelect = By.XPath("//*[@class='product_sort_container']/option[@value='lohi']");
        private By SortHighToLowSelect = By.XPath("//*[@class='product_sort_container']/option[@value='hilo']");
        public const string url = "https://www.saucedemo.com/inventory.html";

        public InventoryPage(WebDriver webDriver) : base(webDriver)
        {
            
        }

        public override void OpenPage() => driver.Navigate().GoToUrl(url);
        public void AddToCart() => driver.FindElement(AddToCartButton).Click();
        public void Remove() => driver.FindElement(RemoveButton).Click();
        public void SortAZ() => driver.FindElement(SortAZSelect).Click();
        public void SortZA() => driver.FindElement(SortZASelect).Click();
        public void SortLowToHigh() => driver.FindElement(SortLowToHighSelect).Click();
        public void SortHighToLow() => driver.FindElement(SortHighToLowSelect).Click();

        internal void ClickOnCartIcon()
        {
            CartLink.GetElement().Click();
        }

    }
}
