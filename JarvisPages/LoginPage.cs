using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jarvis.HelperClass;

namespace Jarvis.JarvisPages
{
    public class LoginPage:TestBase
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='login-logo']")]
        public IWebElement JarvisLogo { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Email']")]
        public IWebElement emailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Password']")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Sign In')]")]
        public IWebElement signIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='text-danger validation-summary-errors']/ul")]
        public IWebElement invalidLoginMessage { get; set; }

        public void VerifyLogoOfJarvisOnLoginPage()
        {
            new GenericHelper().IsElementVisible("JarvisLogo");
        }

        public void ToCheckInvalidLogin(string un,string pwd)
        {
            emailAddress.SendKeys(un);
            emailAddress.SendKeys(pwd);
            signIn.Click();
            new GenericHelper().IsElementVisible("invalidLoginMessage");
        }

        public void GetLogin(string userName, string passWord)
        {
            emailAddress.SendKeys(userName);
            emailAddress.SendKeys(passWord);
            signIn.Click();
        }
       
    }
}
