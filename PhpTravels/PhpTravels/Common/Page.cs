using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace PhpTravels.Common
{
    public abstract class Page
    {
        protected Browser Browser { get; set; }

        protected IWebDriver Driver { get; set; }

        public Page(Browser browser)
        {
            this.Browser = browser;
            this.Driver = browser.Driver;
            PageFactory.InitElements(this.Driver, this);
        }
    }
}
