using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HW2
{
    public class ArticlesSearcher
    {
        List<string> articlesNames = new List<string>();
        public IWebElement SearchField { get { return WebDriver.Driver.FindElement(By.XPath(".//input[@name='ctl00$SearchBox$txtKeywords']")); } }
        public IWebElement SearchButton { get { return WebDriver.Driver.FindElement(By.XPath(".//button[@class='btn btn-default']")); } }

        public void InputSearch(string request)
        {
            SearchField.SendKeys(request);
            SearchButton.Click();
        }

        public void GoToSearch()
        {
            SearchField.Click();
        }
    }
}
