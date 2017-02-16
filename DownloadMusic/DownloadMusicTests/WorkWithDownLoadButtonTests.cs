using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Linq;
using System.Threading;

namespace DownloadMusic.Tests
{
    [TestClass()]
    public class WorkWithDownLoadButtonTests
    {
        static IWebDriver driver { get { return WebDriver.Driver; } }
        public static string[] numbers = { "2", "5", "8", "11", "14", "17", "20", "23", "26", "29", "32", "35", "38", "41", "44", "47", "50", "53", "56", "59" };
        [TestMethod()]
        public void GetAllDLButtonsTest()
        {
            //driver.Navigate().GoToUrl($"http://allrington.ru/download-{Data.ForeignRingtones}-ringtone");
            Steps.OpenPage(Data.ForeignRingtones);
            var counter = 0;
            if (counter != 20)
            {
                foreach (var number in numbers)
                {
                    var xPath = WorkWithDownLoadButton.GetXPath(number);
                    var composition = WorkWithDownLoadButton.GetDLButton(xPath);
                    Steps.ClickDownLoad(composition);
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                    Thread.Sleep(3000);
                    Steps.DownloadComposition();
                    Steps.BackToMainPage();
                    counter++;
                }
            } else Steps.TryGoToNextPage();            
        }

        [TestCleanup()]
        public void CleanUp()
        {
            Steps.End();
        }
    }
}