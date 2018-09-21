using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework
{
    public class Invoice
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='invoiceTable']/tbody/tr[4]/td/table/tbody/tr[2]/td/table[2]/tbody/tr/td")]
        private IList<IWebElement> table;

        public string GetDepositNowSum()
        {
            IWebElement element = Browser.Driver.FindElement(By.XPath("//*[@id='invoiceTable']/tbody/tr[4]/td/table/tbody/tr[2]/td/table[2]/tbody/tr/td[1]"));
            return element.Text;
        }

        public string GetTaxAndVatSum()
        {
            IWebElement element = this.table[1];
            return element.Text;
        }

        public string GetTotalAmountSum()
        {
            IWebElement element = this.table[2];
            return element.Text;
        }

        public bool IsAt()
        {
            return this.table[0].Exists();
        }
    }
}
