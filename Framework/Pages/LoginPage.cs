using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework
{
    public class LoginPage
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email']")]
        private IWebElement emailTextField;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-action btn-lg btn-block loginbtn']")]
        private IWebElement loginButton;

        public void Goto()
        {
            Pages.TopNavigation.Login();
        }

        public void LoginUnderUser(string email, string password)
        {
            emailTextField.SendKeys(email);
            passwordTextField.SendKeys(password);
            this.loginButton.Click();
        }

        public bool IsLoggedUnderUser(string firstName, string lastName)
        {
            IWebElement greetingsText = Browser.Driver.FindElement(By.XPath(String.Format("//*[contains(text(),'Hi, {0} {1}')]", firstName, lastName)));
            if (greetingsText.Exists())
            {
                return true;
            }
            return false;
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Login");
        }
    }
}
