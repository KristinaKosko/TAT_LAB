using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW2
{
    [TestClass]
    public class LoginPageTests
    {
        [TestMethod]
        public void LOginPAgeTest()
        {
            var loginPage = new LoginPage();
            loginPage.NavigateHere();
            loginPage.Login("avkozlov_by", "Minsk2017");
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            WebDriver.KillDriver();
        }
    }
}

