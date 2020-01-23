using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace Jarvis
{
    [TestFixture]
    public class TestBase
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void GetBrowser()
        {
            driver = new ChromeDriver();
            driver.Url = "http://13.71.162.88/";
            driver.Manage().Window.Maximize();
        }        
        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
