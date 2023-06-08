using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson19_Selenium_WebDriver._Advanced.Core
{
    public class UserBuilder
    {
        public static UserModel GetStandartUser() => new()
        {
            Name = TestContext.Parameters.Get("StandartUserName"),
            Password = TestContext.Parameters.Get("StandartUserPassword"),
        };
    }
}
