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
        public bool IsElementVisible(IWebElement element)
        {
            try
            {
                Console.WriteLine(element.Displayed);
                return true;
            }
            catch
            {
                Console.WriteLine("Element is not been Displayed");
                return false;
            }    
        }
        public bool GetTextofElement(IWebElement element)
        {
            try
            {
                Console.WriteLine(element.Text, "has been Displayed");
                return true;

            }
            catch
            {
                Console.WriteLine("Text is not displaying");
                return false;
            }

        }

        
    }
}
