using Jarvis.JarvisPages;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jarvis.TestCase
{
    [TestFixture]
    public class ManageOrganisationTest:TestBase
    {
        [Test,Order(1)]
        public void GetLogin()
        {
            var loginpage = new LoginPage(driver);
            var Username = ConfigurationManager.AppSettings["userName"];
            var Password = ConfigurationManager.AppSettings["ValidPassWord"];
            loginpage.GetLogin(Username, Password);
            Thread.Sleep(3000);
        }

        [Test,Order(2)]
        public void ClickManageOrganisation()
        {
            var manageorganisation = new ManageOrganisationPage(driver);
            manageorganisation.ClickManageOrganisation();
            Thread.Sleep(3000);
        }

        [Test, Order(3)]
        public void ListOfOrganisationIsDisplayed()
        {
            var manageorganisation = new ManageOrganisationPage(driver);
            manageorganisation.ListOfOrganisationIsDisplayed();
        }

        [Test, Order(4)]
        public void CreateOrg()
        {
            var manageorganisation = new ManageOrganisationPage(driver);
            manageorganisation.CreateOrg();
            Thread.Sleep(3000);
        }
        [Test, Order(5)]
        public void ScrollPageToCapsMessaging()
        {
            var manageorganisation = new ManageOrganisationPage(driver);
            manageorganisation.ScrollPageToCapsMessaging();
            Thread.Sleep(5000);
        }

        [Test, Order(6)]
        public void VerifyErrorMessageWpDropDown()
        {
            var manageorganisation = new ManageOrganisationPage(driver);
            manageorganisation.VerifyErrorMessageWpDropDown();
        }





    }
}
