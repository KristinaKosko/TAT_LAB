using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace HW2
{
    public class Steps
    {
        static IWebDriver driver { get { return WebDriver.Driver; } }
        static JournalPage page;

        public static void OpenJournal(string nameOfJournal)
        {
            driver.Navigate().GoToUrl($"http://journals.lww.com/{nameOfJournal}");
        }

        public static bool CheckItems(NavigationItem item)
        {
            JournalPage page = new JournalPage();
            IWebElement category;
            try
            {
                if (item.submenuItems.Count == 0)
                {
                    category = page.TryGetItem(item.name);
                    if (category.Text != item.name)
                        return false;
                }
                else
                {
                    category = page.GetCategory(item.name);
                    category.Click();
                }
            }
            catch
            {
               // WebDriver.TakeScreenshot(navModel.Category);
                return false;
            }
            try
            {
                foreach (var submenuItem in item.submenuItems)
                {
                    IWebElement subItem = page.TryGetItem(submenuItem.name);
                    if (subItem.Text != submenuItem.name)
                    {
                        category.Click();
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                //WebDriver.TakeScreenshot(navModel.Item);
                return false;
            }
        }

        public static void End()
        {
            WebDriver.KillDriver();
        }
    }
}
