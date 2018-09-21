using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework
{
    public class TopNavigationPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='collapse']/ul[1]/li[1]/a")]
        private IWebElement hotelsLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapse']/ul[1]/li[2]/a")]
        private IWebElement homeLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapse']/ul[1]/li[3]/a")]
        private IWebElement flightsLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapse']/ul[1]/li[4]/a")]
        private IWebElement toursLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapse']/ul[1]/li[5]/a")]
        private IWebElement carsLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapse']/ul[1]/li[6]/a")]
        private IWebElement visaLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapse']/ul[1]/li[7]/a")]
        private IWebElement offersLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='collapse']/ul[1]/li[8]/a")]
        private IWebElement blogLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='li_myaccount']/a")]
        private IList<IWebElement> myAccountLink;

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement loginDropDownItem;

        public void Hotels()
        {
            this.hotelsLink.Click();
        }

        public void Home()
        {
            this.homeLink.Click();
        }

        public void Flights()
        {
            this.flightsLink.Click();
        }

        public void Tours()
        {
            this.toursLink.Click();
        }

        public void Cars()
        {
            this.carsLink.Click();
        }

        public void Visa()
        {
            this.visaLink.Click();
        }

        public void Offers()
        {
            this.offersLink.Click();
        }

        public void Blog()
        {
            this.blogLink.Click();
        }

        public void Login()
        {
            this.myAccountLink[1].Click();

            if (this.loginDropDownItem.Exists())
            {
                this.loginDropDownItem.Click();
            }
        }

        public void MyAccount()
        {
            this.Login();
        }
    }
}
