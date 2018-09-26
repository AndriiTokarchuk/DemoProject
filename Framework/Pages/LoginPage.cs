using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework
{
    public class LoginPage
    {
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement emailTextField;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passwordTextField;

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-action.btn-lg.btn-block.loginbtn")]
        private IWebElement loginButton;

        public void Goto()
        {
            Pages.TopNavigation.Login();
        }
        
        public void LoginUnderUser(string email, string password)
        {
            if (emailTextField.Enabled)
            {
                Extensions.FindElement(Browser.Driver, By.Name("username"));
            }
            emailTextField.SendKeys(email);
            passwordTextField.SendKeys(password);
            this.loginButton.Click();
        }

        public bool IsLoggedUnderUser(string firstName, string lastName)
        {
            var greetingsText = Extensions.FindElement(Browser.Driver, By.XPath(String.Format("//*[contains(text(),'Hi, {0} {1}')]", firstName, lastName)));
            if (greetingsText == null)
            {
                return false;
            }
            return true;
        }


        public bool IsAt()
        {
            return Browser.Title.Contains("Login");
        }
    }
}
