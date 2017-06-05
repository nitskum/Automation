using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using PhpTravels.Common;


namespace PhpTravels.PageObjects
{ 
   public class HomePage : Page
    {
        //Constructor inherting the base class constructor
        public HomePage(Browser browser) : base(browser) { }

        //Web Element definitions-->
        
        //One way of locating the web element.
        private By DemoLink = By.CssSelector("div.main-nav-holder a[href*='demo']");

        //Other way of locating the web element.
        [FindsBy(How =How.CssSelector, Using = "div.main-nav-holder a[href*='order']")]
        
        public IWebElement OrderLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.main-nav-holder ul.nav.reset li.has-drop span span")]
        public IWebElement ProductLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href*='documentation']")]
        public IWebElement DocumentationLink { get; set;}

        [FindsBy(How = How.CssSelector, Using = "a[href*='features']")]
        public IWebElement FeaturesLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li a[href*='technology']")]
        public IWebElement TechnologyLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "li a[href*='requirements']")]
        public IWebElement RequirementsLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ul.nav.reset ul.menu.reset li:nth-child(6) a[href*='change-log']")]
        public IWebElement ChangelogLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ul.menu.reset li a[href*='updates']")]
        public IWebElement UpdatesLink { get; set; }

        [FindsBy(How= How.CssSelector, Using = "ul.menu.reset li a[href*='desktop']")]
        public IWebElement DesktopAppLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ul.menu.reset li a[href*='mobile']")]
        public IWebElement MobileAppLink { get; set; }

        [FindsBy(How =How.CssSelector, Using = "ul.menu.reset li a[href*='how-to-get-started']")]
        public IWebElement HowToStartLink { get; set; }

        //------->>>> void methods
        public void ClickDemoLink()
        {
            Log.Write.Info("Clicking Demo Link");
            //cumtomized waitAndClick method which includes wait.
            Wait.WaitAndClick(DemoLink, 10);
        }

        public void ClickOrderLink()
        {
            
            OrderLink.Click();
        }

        public void ClickProductLink()
        {
            
            ProductLink.Click();
        }

        public void ClickPro_DocLink()
        {
            
            DocumentationLink.Click();
        }

        public void ClickPro_FeatureLink()
        {
            
            FeaturesLink.Click();
        }

        public void ClickPro_TechLink()
        {
            
            TechnologyLink.Click();
        }

        public void ClickPro_ReqLink()
        {
            
            RequirementsLink.Click();
        }

        public void ClickPro_ChangelogLink()
        {
           
            ChangelogLink.Click();
        }

        public void ClickPro_UpdatesLink()
        {
            
            UpdatesLink.Click();
        }
        public void ClickPro_DesktopAppLink()
        {
            DesktopAppLink.Click();
        }

        public void ClickPro_MobileAppLink()
        {
            MobileAppLink.Click();
        }

        public void ClickPro_HowToStartLink()
        {
            HowToStartLink.Click();
        }
    }
}
