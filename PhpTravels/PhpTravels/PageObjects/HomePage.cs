using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using PhpTravels.Common;
using System.Threading;

namespace PhpTravels.PageObjects
{
   public class HomePage : Page
    {
        public HomePage(Browser browser) : base(browser) { }
        
        //Web Element definitions-->

        [FindsBy(How = How.CssSelector, Using = "div.main-nav-holder a[href*='demo']")]
        public IWebElement DemoLink { get; set; }

        [FindsBy(How =How.CssSelector, Using = "div.main-nav-holder a[href*='order']")]
        public IWebElement OrderLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.main-nav-holder span:contains('Product')")]
        public IWebElement ProductLink { get; set; }
        public void ClickDemoLink()
        {
            Thread.Sleep(1000);
            DemoLink.Click();
        }

        public void ClickOrderLink()
        {
            Thread.Sleep(1000);
            OrderLink.Click();
        }

        public void ClickProductLink()
        {
            Thread.Sleep(1000);
            ProductLink.Clear();
        }

    }
}
