using Lesson13_PageObjectPattern.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_PageObjectPattern.Test
{
    internal class InventoryTest : BaseTest
    {
        [Test]
        public void AddToCard()
        {
            var page = new InventoryPage(driver);
            var loginPage = new LoginPage(driver);
            page.OpenPage();
            loginPage.LoginAsStandartUser();
            page.AddToCart();
        }
        [Test]
        public void RemoveFromCard()
        {
            var page = new InventoryPage(driver);
            var loginPage = new LoginPage(driver);
            page.OpenPage();
            loginPage.LoginAsStandartUser();
            page.AddToCart();
            page.Remove();
        }
        [Test]
        public void SortAZ()
        {
            var page = new InventoryPage(driver);
            var loginPage = new LoginPage(driver);
            page.OpenPage();
            loginPage.LoginAsStandartUser();
            page.SortAZ();
        }
        [Test]
        public void SortZA()
        {
            var page = new InventoryPage(driver);
            var loginPage = new LoginPage(driver);
            page.OpenPage();
            loginPage.LoginAsStandartUser();
            page.SortZA();
        }
        [Test]
        public void SortLowToHigh()
        {
            var page = new InventoryPage(driver);
            var loginPage = new LoginPage(driver);
            page.OpenPage();
            loginPage.LoginAsStandartUser();
            page.SortLowToHigh();
        }
        [Test]
        public void SortHighToLow()
        {
            var page = new InventoryPage(driver);
            var loginPage = new LoginPage(driver);
            page.OpenPage();
            loginPage.LoginAsStandartUser();
            page.SortHighToLow();
        }
    }
}
