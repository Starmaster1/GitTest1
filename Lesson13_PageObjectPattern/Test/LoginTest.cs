using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson13_PageObjectPattern.PageObject;
using OpenQA.Selenium;

namespace Lesson13_PageObjectPattern.Test
{
    internal class LoginTest : BaseTest
    {
        [Test]
        public void LoginStandartUser()
        {
            var page = new LoginPage(driver);
            page.OpenPage();
            page.LoginAsStandartUser();
        }
    }
}
