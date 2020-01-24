using Jarvis.HelperClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis.JarvisPages
{
    public class ManageOrganisationPage
    {
        IWebDriver driver;
        public ManageOrganisationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//ul[@class='sidebar-menu tree']/li[3]/a/span")]
        public IWebElement ManageOrganisation { get; set; }

        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'List of Organisations')]")]
        public IWebElement listOfOrganisation { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Create Organisation')]")]
        public IWebElement CreateOrganisation { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),' CAPS Messaging')]")]
        public IWebElement ScrollPageCAPSMessaging { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='i_submit']")]
        public IWebElement SaveButton { get; set; }

        /****************************Error Message*********************************/

        [FindsBy(How = How.XPath, Using = "//span[@id='error-messagewptype']")]
        public IWebElement ErrorMessageOfWpDown { get; set; }

        /****************************************************************************/

        public void ClickManageOrganisation()
        {
            ManageOrganisation.Click();
        }

        public void ClickRepairer(String data)
        {
            IWebElement data1= driver.FindElement(By.XPath("//table[@id='organisation']/tbody/tr/td/a[contains(text(),'" + data + "')]"));
            data1.Click();
        }

        public void ListOfOrganisationIsDisplayed()
        {
            new GenericHelper().IsElementVisible(listOfOrganisation);
            new GenericHelper().GetTextofElement(listOfOrganisation);
        }

        public void CreateOrg()
        {
            CreateOrganisation.Click();
        }

        public void ScrollPageToCapsMessaging()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", ScrollPageCAPSMessaging);
            SaveButton.Click();
        }
        public void VerifyErrorMessageWpDropDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", ErrorMessageOfWpDown);
            new GenericHelper().IsElementVisible(ErrorMessageOfWpDown);
            new GenericHelper().GetTextofElement(ErrorMessageOfWpDown);
        }

        

        

    }
}
