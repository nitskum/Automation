using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;


namespace PhpTravels.Common
{
   public class Browser
    {
        public IWebDriver Driver { get; set; }
        string chromePath = @"F:\PhpTravels";
        string iePath = @"F:\PhpTravels";


        int browserCategory;

        public Browser(BrowserType browserType)
        {
            this.browserCategory = (int)browserType;
        }

        public void Initialize()
        {
            switch (browserCategory)
            {
                case 1:
                    //System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", @"F:\\PhpTravels\geckodriver.exe");
                    Driver = new FirefoxDriver();
                    Driver.Url = "http://phptravels.com/";
                    Driver.Manage().Window.Maximize();
                    break;

                case 2:
                    Driver = new ChromeDriver(chromePath);
                    Driver.Url = "http://phptravels.com/demo/";
                    break;

                case 3:
                    Driver = new InternetExplorerDriver(iePath);
                    Driver.Url = "http://phptravels.com/demo/";
                    Driver.Manage().Window.Maximize();
                    break;


            }
        }

        public void Quit()
        {
            Driver.Close();
        }
        public enum BrowserType
        {
            Firefox = 1,
            Chrome = 2,
            IE = 3
        }
    }
}
