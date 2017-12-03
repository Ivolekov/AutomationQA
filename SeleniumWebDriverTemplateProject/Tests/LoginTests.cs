using System.Threading;
using NUnit.Framework;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages;
using SeleniumWebDriverTemplateProject.Tests.Abstract;

namespace SeleniumWebDriverTemplateProject.Tests
{
    class LoginTests : DesktopSeleniumTestFixturePrototype
    {
        public LoginTests(Browsers browser) : base(browser){}

        [Test]
        public void LoginTest()
        {
            var loginPageInstance = LoginPage.NavigateTo(base.Driver);

            loginPageInstance.LogIn();

            var yourAccountPage = PageFactoryExtensions.InitPage<YourAccountPage>(this.Driver);

            Thread.Sleep(5000);

            Assert.AreEqual(
                yourAccountPage.UserNameTextBox.Text, "Hello Administrator@test.com!"
            );
        }

        [Test]
        public void LogoutTest()
        {
            var loginPageInstance = LoginPage.NavigateTo(base.Driver);

            loginPageInstance.LogIn();

            var yourAccountPage = PageFactoryExtensions.InitPage<YourAccountPage>(this.Driver);

            Thread.Sleep(5000);

            yourAccountPage.LogOffButton.Click();

            var homePage  = PageFactoryExtensions.InitPage<HomePage>(this.Driver);
            Thread.Sleep(3000);

            Assert.AreEqual(homePage.LoginButton.Text, "Log in");
        }
    }
}
