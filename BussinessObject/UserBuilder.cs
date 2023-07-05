using Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject_SalesForce
{
    public class UserBuilder
    {

        public static UserModel GetStandartUser()
        {
            return new UserModel
            {
                Name = TestContext.Parameters.Get("StandartUserName")!,
                Password = TestContext.Parameters.Get("StandartUserPassword")!,
            };
        }
    }
}
