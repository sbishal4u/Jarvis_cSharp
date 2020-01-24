using Jarvis.JarvisPages;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Threading;

namespace Jarvis.TestCase
{
    [TestFixture]
    public class LoginPageTest:TestBase
    {

        [Test,Order(1)]
        public void VerifyLogoOfJarvisOnLoginPage()
        {
            var loginpage=new LoginPage(driver);
            loginpage.VerifyLogoOfJarvisOnLoginPage();
        }
        [Test, Order(2)]
        public void CheckRememberIsDisplayed()
        {
            var loginpage = new LoginPage(driver);
            loginpage.CheckRememberIsDisplayed();
        }

        [Test, Order(3)]
        public void ForgotPassWordIsVisible()
        {
            var loginpage = new LoginPage(driver);
            loginpage.ForgotPassWordIsVisible();
        }

        [Test,Order(4)]
        public void ToCheckInvalidLogin()
        {
            var loginpage = new LoginPage(driver);
            var Username = ConfigurationManager.AppSettings["userName"];
            var Password = ConfigurationManager.AppSettings["passWord"];
            loginpage.ToCheckInvalidLogin(Username, Password);
            Thread.Sleep(5000);  
        }

        [Test,Order(5)]
        public void GetLogin()
        {
            var loginpage = new LoginPage(driver);
            var Username = ConfigurationManager.AppSettings["userName"];
            var Password = ConfigurationManager.AppSettings["ValidPassWord"];
            loginpage.GetLogin(Username, Password);
        }

    }
}
