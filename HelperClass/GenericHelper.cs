using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Jarvis.HelperClass
{
    public class GenericHelper
    {
        IWebDriver driver;   
        public bool IsElementVisible(string element)
        {
            try
            {
                bool isElementDisplayed = driver.FindElement(By.XPath(element)).Displayed;
                Console.WriteLine(element, "has been Displayed");
                return true;
            }

            catch
            {
                Console.WriteLine(element, "has not been Displayed");
                return false;
            }
            
        }

    }
}
