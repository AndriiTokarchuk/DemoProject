using System;
using System.Linq;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework
{
    public class MyAccount
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='dark go-right']")]
        private IList<IWebElement> hotelsList;

        public void Goto()
        {
            Pages.TopNavigation.MyAccount();
        }

        public string[] GetHotelsNames()
        {
            return this.hotelsList.GetTextFromListOfElements();
        }

        public void GetReviewWindowForHotel(string hotelName)
        {
            IWebElement reviews = Browser.Driver.FindElement(By.XPath("//*[@id='bookings']/div[128]/div[4]/span"));
            reviews.Click();
        }

        public void GetInvoiceWindowForHotel(string hotelName)
        {
            IWebElement invoice = Browser.Driver.FindElement(By.XPath("//*[@id='bookings']/div[128]/div[4]/a"));
            invoice.Click();
        }
        

        public bool IsHotelPresent(string hotelName)
        {
            return Array.IndexOf(this.GetHotelsNames(), hotelName)  >= 1;
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("My Account");
        }
    }
}
