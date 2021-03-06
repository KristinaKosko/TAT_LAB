﻿using System.Threading.Tasks;
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
					driver = WebDriverGetter.GetWebDriver(TestData.browser);
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
