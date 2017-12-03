using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriverTemplateProject.Pages.Abstract;

namespace SeleniumWebDriverTemplateProject.Pages
{
    class CheckOutPage : Page
    {
        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstNameField { get; set; }

        [FindsBy(How = How.Id, Using = "LastName")]
        public IWebElement LastNameField { get; set; }

        [FindsBy(How = How.Id, Using = "Address")]
        public IWebElement AddressField { get; set; }

        [FindsBy(How = How.Id, Using = "City")]
        public IWebElement CityField { get; set; }

        [FindsBy(How = How.Id, Using = "State")]
        public IWebElement StateField { get; set; }

        [FindsBy(How = How.Id, Using = "PostalCode")]
        public IWebElement PostalCodeField { get; set; }

        [FindsBy(How = How.Id, Using = "Country")]
        public IWebElement CountryField { get; set; }

        [FindsBy(How = How.Id, Using = "Phone")]
        public IWebElement PhoneField { get; set; }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.Id, Using = "PromoCode")]
        public IWebElement PromoCodeField { get; set; }

        //[FindsBy(How = How.TagName, Using = "fieldset +input")]
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/form/input[1]")]
        public IWebElement SubmitOrderButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".container h2")]
        public IWebElement CheckoutCompleteText { get; set; }


    }
}
