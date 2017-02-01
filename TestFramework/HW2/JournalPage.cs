using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace HW2
{
	public class JournalPage
	{
        By category = By.ClassName("dropdown-toggle");
        By item = By.ClassName("menu-item-text");

        public IWebElement GetCategory(string categoryName)
        {
            //WebDriver.waitForElement(category, 15);
            List<IWebElement> elements = WebDriver.Driver.FindElements(category).ToList();
            try
            {
                IWebElement element = elements.Single(i => i.Text == categoryName);
                return element;
            }
            catch
            {
               // WebDriver.TakeScreenshot(categoryName);
            }
            return null;
        }

        public IWebElement TryGetItem(string itemName)
        {
            // WebDriver.waitForElement(item, 15);
            List<IWebElement> elements = WebDriver.Driver.FindElements(item).ToList();
            try
            {
                IWebElement element = elements.Single(i => i.Text == itemName);
                return element;
            }
            catch
            {
              //  WebDriver.TakeScreenshot(itemName);
            }
            return null;
        }

    }
}
