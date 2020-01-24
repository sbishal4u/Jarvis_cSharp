using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Jarvis.HelperClass;

namespace Jarvis.JarvisPages
{
    public class DashboardPage
    {
        IWebDriver driver;
        public DashboardPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='content-wrapper']//section/h1")]
        public IWebElement DashboardText { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Update Website Information')]")]
        public IWebElement UpdateWebsiteInformation { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Update Your Personal Information')]")]
        public IWebElement ClickUpdatePersonalInfo { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Save Changes')]")]
        public IWebElement SaveChange { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Dashboard')]")]
        public IWebElement DashboardButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Update Website Information')]")]
        public IWebElement UpdateInfoButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='box-header with-border'][2]/h3[contains(text(),'General Information')]")]
        public IWebElement scrollPage { get; set; }





        public void CheckDashBoardIsVisible()
        {
            new GenericHelper().IsElementVisible(DashboardText);
            new GenericHelper().GetTextofElement(DashboardText);
        }

        public void ClickUpdateYourPersonalInfo()
        {
            ClickUpdatePersonalInfo.Click();
            SaveChange.Click();
        }

        public void ClickDashboard()
        {
            DashboardButton.Click();
        }
        public void ScrollPage()
        {
            new JavaScriptHelper().ScrollThePage(scrollPage);
        }
        public ManageOrganisationPage NavigateToManageOrganisation()
        {
            return new ManageOrganisationPage(driver);
        }

       

    }
}
