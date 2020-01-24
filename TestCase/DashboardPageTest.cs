using Jarvis.JarvisPages;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Jarvis.TestCase
{
    [TestFixture]
    public class DashboardPageTest :TestBase
    {
        [Test, Order(1)]
        public void GetLogin()
        {
            var loginpage = new LoginPage(driver);
            var Username = ConfigurationManager.AppSettings["userName"];
            var Password = ConfigurationManager.AppSettings["ValidPassWord"];
            loginpage.GetLogin(Username, Password);
            Thread.Sleep(5000);
        }
        [Test, Order(2)]
        public void CheckDashBoardIsVisible()
        {
            var dashboard=new DashboardPage(driver);
            dashboard.CheckDashBoardIsVisible();
            Thread.Sleep(5000);
        }

        [Test, Order(3)]
        public void ClickUpdateYourPersonalInfo()
        {
            var dashboard = new DashboardPage(driver);
            dashboard.ClickUpdateYourPersonalInfo();
            Thread.Sleep(5000);
        }

        [Test, Order(4)]
        public void ClickDashboard()
        {
            var dashboard = new DashboardPage(driver);
            dashboard.ClickDashboard();
            Thread.Sleep(5000);
            dashboard.ScrollPage();
        }

    }
}
