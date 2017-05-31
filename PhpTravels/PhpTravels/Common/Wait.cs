using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhpTravels.Common
{
    class  Wait : Page
    {
        public Wait(Browser browser) : base(browser) { }
         
        public static void WaitAndClick(By by, int timeoutInSeconds)
        {
              WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
              wait.Until(ExpectedConditions.ElementIsVisible(by));
              Driver.FindElement(by).Click();

        }

    }
}
