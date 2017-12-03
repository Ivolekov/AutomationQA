using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriverTemplateProject.Pages.Abstract;

namespace SeleniumWebDriverTemplateProject.Pages
{
    class YourAccountPage : Page
    {
        [FindsBy(How = How.CssSelector, Using = "#logoutForm ul li a")]
        public IWebElement UserNameTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#logoutForm ul li +li a")]
        public IWebElement LogOffButton { get; set; }
    }
}
