using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson19_Selenium_WebDriver._Advanced.Core;
using Lesson19_Selenium_WebDriver._Advanced.PageObject;
using OpenQA.Selenium;

namespace Lesson19_Selenium_WebDriver._Advanced.Test
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void LoginStandartUser()
        {
            var page = new LoginPage(driver);
            Browser.Instance.NavigateToUrl(LoginPage.url);
            page.LoginAsStandartUser();
        }
    }
}
