using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadMusic
{
    public class Steps
    {
        static IWebDriver driver { get { return WebDriver.Driver; } }
        static By download = By.XPath("//*[text()='Скачать .mp3']");
        static By nextPage = By.XPath("//*[text()='Вперед']");


        public static void OpenPage(string musicType)
        {
            driver.Navigate().GoToUrl($"http://allrington.ru/download-{musicType}-ringtone");
        }

        public static void ClickDownLoad(IWebElement button)
        {
            Actions newTab = new Actions(driver);
            newTab
                .KeyDown(OpenQA.Selenium.Keys.Control)
                .KeyDown(OpenQA.Selenium.Keys.Shift)
                .Click(button).KeyUp(OpenQA.Selenium.Keys.Control).KeyUp(OpenQA.Selenium.Keys.Shift)
                .Build()
                .Perform();
        }

        public static void DownloadComposition()
        {
            
            IWebElement downloadBut;

            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
                wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
                wait.Until(ExpectedConditions.ElementExists(download));
            }
            catch
            {
                driver.Navigate().Refresh();
            }
            downloadBut = WebDriver.Driver.FindElement(download);
            downloadBut.Click();
        }

        public static void BackToMainPage()
        {
            WebDriver.Driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        public static void TryGoToNextPage()
        {
            //IWebElement nextDownloadPage;

            /*var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Until(ExpectedConditions.ElementExists(download));*/
            if ((WebDriver.Driver.FindElement(download)) != null)
            {
                WebDriver.Driver.FindElement(download).Click();
            }      
        }
        
        public static void End()
        {
            WebDriver.KillDriver();
        }
    }
}
