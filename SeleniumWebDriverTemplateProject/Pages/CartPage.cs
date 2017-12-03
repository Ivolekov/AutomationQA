using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriverTemplateProject.Pages.Abstract;

namespace SeleniumWebDriverTemplateProject.Pages
{
    class CartPage : Page
    {
        [FindsBy(How = How.LinkText, Using = "Checkout >>")]
        public IWebElement CheckOutButton { get; set; }
    }
}
