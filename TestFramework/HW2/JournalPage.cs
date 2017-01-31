using System;
namespace HW2
{
	public class JournalPage
	{
		public JournalPage()
		{
		}

		public void NavigateHere(string journalName)
		{
			WebDriver.Driver.Navigate().GoToUrl("http://journals.lww.com/" + journalName);
		}
	}
}
