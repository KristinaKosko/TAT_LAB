using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadMusic
{
    class WebDriverGetter
    {
        private static IWebDriver driver;

        public static IWebDriver GetWebDriver(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    {
                        return GetChromeDriver();
                    }

                case "FireFox":
                    {
                        return GetFireFoxDriver();
                    }

                case "InternetExplorer":
                    {
                        return GetInternerExplorerDriver();
                    }
            }
            return GetChromeDriver();
        }

        public static IWebDriver GetChromeDriver()
        {
            driver = new ChromeDriver(Data.ChromeDriverPath);
            driver.Manage().Window.Maximize();

            return driver;
        }

        public static IWebDriver GetFireFoxDriver()
        {
            driver = new FirefoxDriver(FirefoxDriverService.CreateDefaultService(Data.FFDriverPath));
            driver.Manage().Window.Maximize();

            return driver;
        }

        public static IWebDriver GetInternerExplorerDriver()
        {
            driver = new InternetExplorerDriver(Data.IEDriverPath);
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
