
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
            homePage.ClickPro_DocLink();
        }
        [TestMethod]
        public void User_Go_To_FeaturesPage()
        {
            homePage.ClickPro_FeatureLink();
        }
        [TestMethod]
        public void User_Go_To_TechnologyPage()
        {
            homePage.ClickPro_TechLink();
        }
        [TestMethod]
        public void User_Go_To_RequirementsPage()
        {
            homePage.ClickPro_ReqLink();
        }
        [TestMethod]
        public void User_Go_To_ChangelogPage()
        {
            homePage.ClickPro_ChangelogLink();
        }
        [TestCleanup]
        public void Teardown()
        {
            browser.Quit();
        }
        
    }
}
