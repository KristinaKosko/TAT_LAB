using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW2
{
	public class WebDriver
	{
		private WebDriver() { }

		private static IWebDriver driver;

		public static IWebDriver Driver
		{
			get
			{
				if (driver == null)
				{
					driver = new ChromeDriver(@"C:\Users\Krystsina_Kasko\Desktop\TAT_LAB-TestJournalFramework\TestFramework\HW2\bin\Debug");
					driver.Manage().Window.Maximize();
				}

				return driver;
			}
		}

		public static void KillDriver()
		{
			driver.Quit();
			driver = null;
		}
	}
}
