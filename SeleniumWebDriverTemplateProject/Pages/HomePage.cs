﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumWebDriverTemplateProject.Pages
{
    public class HomePage : Page
    {

        [FindsBy(How = How.LinkText, Using = "Music Store")]
        public IWebElement MusicStoreButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "Home")]
        public IWebElement HomeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#logoutForm ul > li")]
        public IWebElement UserGreetingTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#logoutForm ul > li + li")]
        public IWebElement LogoutButton { get; set; }

        [FindsBy(How = How.Id, Using = "registerLink")]
        public IWebElement RegisterButton { get; set; }

        [FindsBy(How = How.Id, Using = "loginLink")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "navbar-inverse")]
        public IWebElement NavigationBarRoot { get; set; }

        [FindsBy(How = How.Id, Using = "album-list")]
        public IWebElement AlbumListRoot { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".navbar-nav li +li a")]
        public IWebElement StoreButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".navbar-nav li +li ul li +li  a")]
        public IWebElement CategoryButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#album-list li a .control-label")]
        public IWebElement AlbumButton { get; set; }


        public bool IsCartVisible()
        {
            return this.NavigationBarRoot.FindElements(By.Id("cart-status")).Any();
        }

        public int GetCartItemCount()
        {
            if (!this.IsCartVisible()) { return 0; }
            string cartItemCountAsString = this.NavigationBarRoot.FindElement(By.Id("cart-status")).Text;
            return int.Parse(cartItemCountAsString);
        }

        public IList<IWebElement> GetAlbums()
        {
            IList<IWebElement> list = AlbumListRoot.FindElements(By.TagName("a")).ToList();
            return list;
        }

        public static HomePage NavigateTo(IWebDriver driver)
        {
            var page = LoginPage.NavigateTo(driver);
            System.Threading.Thread.Sleep(3000);

            page.LogIn();

            var homePageInstance = PageFactoryExtensions.InitPage<HomePage>(driver);

            return homePageInstance;
        }
    }
}
