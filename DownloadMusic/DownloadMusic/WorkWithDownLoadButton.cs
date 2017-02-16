using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadMusic
{
    public class WorkWithDownLoadButton
    {
        public static string GetXPath(string number)
        {
            return $"html/body/div[1]/div[2]/div[1]/div[1]/div/div[4]/div[1]/div/table/tbody/tr/td[2]/div[{number}]/a/button";
        }

        public static IWebElement GetDLButton(string xPath)
        {
            return WebDriver.Driver.FindElement(By.XPath(xPath));
        }
    }
}
