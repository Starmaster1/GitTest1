using BussinessObject_SalesForce;
using Core.Selenium;
using Core.Selenium.Elements;
using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace BussinessObject_SalesForce.Pages
{
    public class LoginPage
    {
        private Input userNameInput = new(By.XPath("//input[@name='username']"));
        private Input passwordInput = new(By.XPath("//input[@name='pw']"));
        private Button loginButton = new("Login");

        private Button ContactTab = new(By.XPath("//*[@data-id='Contact']//span"));

        public LoginPage OpenPage()
        {
            Browser.Instance.NavigateToUrl("https://ttt-a8-dev-ed.develop.my.salesforce.com/");
            return this;
        }

        public LoginPage Login(UserModel user)
        {
            userNameInput.GetElement().SendKeys(user.Name);
            passwordInput.GetElement().SendKeys(user.Password);
            loginButton.GetElement().Click();

            return this;
        }

        public NewAccountModal OpenNewAccountModal()
        {
            Browser.Instance.NavigateToUrl("");
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();
            return new NewAccountModal();
        }

        public NewContactModal OpenNewContactModal()
        {
            // Browser.Instance.NavigateToUrl("https://ivaonvoooo3-dev-ed.develop.lightning.force.com/lightning/o/Contact/list?filterName=Recent");
            var contactTab = Browser.Instance.Driver.FindElement(By.XPath("//*[@data-id='Contact']//span"));

            ContactTab.ClickElementViaJs();
            new Button(By.XPath("//div[@title='New']")).GetElement().Click();

            return new NewContactModal();
        }
    }
}
