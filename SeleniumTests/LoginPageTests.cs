using BussinessObject_SalesForce;
using BussinessObject_SalesForce.Pages;
using Core.Selenium;
using Allure.Commons;
using NUnit.Allure.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleForceTests
{
    public class LoginPageTests : BaseTest
    {
        [Test]
        [AllureDescription("Login to Saleforce as standart user")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Alexander")]
        public void LoginAsStandartUser()
        {
            var user = UserBuilder.GetStandartUser();
            new LoginPage()
                .OpenPage()
                .Login(user);
            string expectedUrl = "https://ttt-a8-dev-ed.develop.lightning.force.com/lightning/setup/SetupOneHome/home";
            Assert.AreEqual(expectedUrl, Browser.Instance.GetCurrentUrl());
        }
    }
}
