using NUnit.Framework;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages;
using SeleniumWebDriverTemplateProject.Tests.Abstract;
using System.Threading;

namespace SeleniumWebDriverTemplateProject.Tests
{
    class HomePageTests : DesktopSeleniumTestFixturePrototype
    {
        public HomePageTests(Browsers browser) : base(browser)
        { }

        [Test]
        public void AreOffersInHomePageTest()
        {
            var homePageInstance = HomePage.NavigateTo(this.Driver);

            Thread.Sleep(4000);

            int albumCount = homePageInstance.GetAlbums().Count;
            Assert.Greater(albumCount, 0);
        }
    }
}
