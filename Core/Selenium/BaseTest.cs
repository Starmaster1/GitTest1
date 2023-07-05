using Allure.Commons;
using NUnit.Allure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selenium
{
    [AllureNUnit]
    public class BaseTest
    {
        private AllureLifecycle allure;

        [OneTimeSetUp]
        public void SetUp()
        {
            allure = AllureLifecycle.Instance;
        }
        [TearDown] 
        public void TearDown() {
           Browser.Instance.CloseBrowser();
        }
    }
}
