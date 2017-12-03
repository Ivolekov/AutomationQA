using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumWebDriverTemplateProject.Helpers;
using SeleniumWebDriverTemplateProject.Pages;
using SeleniumWebDriverTemplateProject.Tests.Abstract;

namespace SeleniumWebDriverTemplateProject.Tests
{
    class PurchaseTests : DesktopSeleniumTestFixturePrototype
    {
        public PurchaseTests(Browsers browser) : base(browser)
        {
        }

        [Test]
        public void BuyOneAlbum()
        {
            var homePageInstance = HomePage.NavigateTo(this.Driver);

            Thread.Sleep(3000);

            homePageInstance.StoreButton.Click();
            //Thread.Sleep(1000);
            homePageInstance.CategoryButton.Click();
            //Thread.Sleep(2000);

            var albumPage = PageFactoryExtensions.InitPage<AlbumPage>(this.Driver);
            albumPage.AlbumButton.Click();
            //Thread.Sleep(2000);
            albumPage.AddToCartButton.Click();

            var cartPage = PageFactoryExtensions.InitPage<CartPage>(this.Driver);
            cartPage.CheckOutButton.Click();

            var checkOutPage = PageFactoryExtensions.InitPage<CheckOutPage>(this.Driver);
            Thread.Sleep(4000);
            checkOutPage.FirstNameField.SendKeys("Ivo");
            //Thread.Sleep(1000);
            checkOutPage.LastNameField.SendKeys("Lekov");
            checkOutPage.AddressField.SendKeys("Nadejda");
            checkOutPage.CityField.SendKeys("Sofia");
            checkOutPage.StateField.SendKeys("Sofia");
            checkOutPage.PostalCodeField.SendKeys("12200");
            checkOutPage.CountryField.SendKeys("Bulgaria");
            checkOutPage.PhoneField.SendKeys("0896123123");
            checkOutPage.EmailField.SendKeys("ivolekovbg@gmail.com");
            checkOutPage.PromoCodeField.SendKeys("FREE");
            //If Tets can't pass
            //Scroll with mouse after fileds is fill with text(in FireFox). Test will pass!!:)
            //My fire fox is Firefox Quantum (57.0.1 (64-бит) from Яндекс - 1.2)
            Thread.Sleep(3000);
            checkOutPage.SubmitOrderButton.Click();
            checkOutPage.SubmitOrderButton.Click();
            Thread.Sleep(3000);
            Assert.AreEqual(checkOutPage.CheckoutCompleteText.Text, "Checkout Complete");
        }
    }
}
