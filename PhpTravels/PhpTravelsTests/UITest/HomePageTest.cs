
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhpTravels.Common;
using PhpTravels.PageObjects;
using static PhpTravels.Common.Browser;

namespace PhpTravelsTests.UITest
{
    [TestClass]
    public class HomePageTest
    {
        
        private static Browser browser;
        private static HomePage homePage;

        [TestInitialize]
        public void Initialize()
        {
            browser = new Browser(BrowserType.Firefox);
            browser.Initialize();
            homePage = new HomePage(browser);

        }
        [TestMethod]
        public void User_Go_To_DemoPage()
        {
            homePage.ClickDemoLink();
        }
        [TestMethod]
        public void User_Go_To_OrderPage()
        {
            homePage.ClickOrderLink();
        }
        [TestMethod]
        public void User_Go_To_DocumentationPage()
        {
            homePage.ClickProductLink();
            homePage.ClickPro_DocLink();
        }
        [TestMethod]
        public void User_Go_To_FeaturesPage()
        {
            homePage.ClickProductLink();
            homePage.ClickPro_FeatureLink();
        }
        [TestMethod]
        public void User_Go_To_TechnologyPage()
        {
            homePage.ClickProductLink();
            homePage.ClickPro_TechLink();
        }
        [TestMethod]
        public void User_Go_To_RequirementsPage()
        {
            homePage.ClickProductLink();
            homePage.ClickPro_ReqLink();
        }
        [TestMethod]
        public void User_Go_To_ChangelogPage()
        {
            homePage.ClickProductLink();
            homePage.ClickPro_ChangelogLink();
        }
        [TestMethod]
        public void User_Go_To_UpdatePage()
        {
            homePage.ClickProductLink();
            homePage.ClickPro_UpdatesLink();
        }
        [TestMethod]
        public void User_Go_To_DesktopAppPage()
        {
            homePage.ClickProductLink();
            homePage.ClickPro_DesktopAppLink();
        }
        [TestMethod]
        public void User_Go_To_MobileAppPage()
        {
            homePage.ClickProductLink();
            homePage.ClickPro_MobileAppLink();
        }
        [TestMethod]
        public void User_Go_To_HowToStartPage()
        {
            homePage.ClickProductLink();
            homePage.ClickPro_HowToStartLink();
        }
        [TestCleanup]
        public void Teardown()
        {
            browser.Quit();
        }
        
    }
}
