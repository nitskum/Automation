using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PhpTravels.Common
{
    public abstract class Page
    {
        public static Browser Browser { get; set; }

        public static IWebDriver Driver { get; set; }

        public Page(Browser browser)
        {
            Browser = browser;
            Driver = browser.Driver;
            PageFactory.InitElements(Driver, this);
        }
    }
}
