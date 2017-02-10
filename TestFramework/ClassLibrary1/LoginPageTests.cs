using NUnit.Framework;

namespace HW2
{
        [TestFixture]
        public class LoginPageTests
        {
            [Test]
            public void LoginPageTest()
            {
                var loginPage = new LoginPage();
                loginPage.NavigateHere();
                loginPage.Login("avkozlov_by", "Minsk2017");
            }

            [OneTimeTearDown]
            public static void Cleanup()
            {
                WebDriver.KillDriver();
            }
        }
}

