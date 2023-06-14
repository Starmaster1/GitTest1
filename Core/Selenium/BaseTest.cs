using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selenium
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public void SetUp()
        {

        }
        [TearDown] 
        public void TearDown() {
           // Browser.Instance.CloseBrowser();
        }
    }
}
