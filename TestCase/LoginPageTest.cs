using Jarvis.JarvisPages;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Jarvis.TestCase
{
    [TestFixture]
    public class LoginPageTest:TestBase
    {
        private LoginPage login;

        [Test,Order(1)]
        public void VerifyLogoOfJarvisOnLoginPage()
        {
            login = new LoginPage();
            login.VerifyLogoOfJarvisOnLoginPage();
        }

        [Test,Order(2)]
        public void ToCheckInvalidLogin()
        {
            login = new LoginPage();
            var UserName = ConfigurationManager.AppSettings["userName"];
            Console.WriteLine(UserName);
            var PassWord = ConfigurationManager.AppSettings["passWord"];
            Console.WriteLine(PassWord);
            login.ToCheckInvalidLogin(UserName, PassWord);
        }
    }
}
