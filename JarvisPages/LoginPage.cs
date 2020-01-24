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
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='login-logo']")]
        public IWebElement JarvisLogo { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Email']")]
        public IWebElement emailAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='Password']")]
        public IWebElement pwd { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Sign In')]")]
        public IWebElement signIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='text-danger validation-summary-errors']/ul/li")]
        public IWebElement invalidLoginMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='col-xs-6']/label")]
        public IWebElement rememberMe { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='col-xs-6 text-right']")]
        public IWebElement forgotPassword { get; set; }

        public void VerifyLogoOfJarvisOnLoginPage()
        {
            new GenericHelper().IsElementVisible(JarvisLogo);
        }

        public void CheckRememberIsDisplayed()
        {
            new GenericHelper().IsElementVisible(rememberMe);
            new GenericHelper().GetTextofElement(rememberMe);
        }

        public void ForgotPassWordIsVisible()
        {
            new GenericHelper().IsElementVisible(forgotPassword);
            new GenericHelper().GetTextofElement(forgotPassword);
        }

        public void ToCheckInvalidLogin(string username, string password)
        {
            emailAddress.SendKeys(username);
            pwd.SendKeys(password);
            signIn.Click();
            var generichelper=new GenericHelper();
            generichelper.GetTextofElement(invalidLoginMessage);
        }

        public void GetLogin(string username, string password)
        {
            emailAddress.SendKeys(username);
            pwd.SendKeys(password);
            signIn.Click();
        }

        public DashboardPage NavigateToDashboardPage()
        {
            return new DashboardPage(driver);
        }

       
    }
}
