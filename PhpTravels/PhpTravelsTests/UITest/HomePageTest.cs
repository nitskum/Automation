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

        public void Can_Go_To_HomePage()
        {
            //homePage.ClickDemoLink();
            //homePage.ClickOrderLink();
			//new comment
            homePage.ClickProductLink();
        }

        
    }
}
