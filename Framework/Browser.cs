using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Framework
{
    public static class Browser
    {
        private static string baseUrl = "https://www.phptravels.net ";
        private static IWebDriver webDriver = new ChromeDriver("D:\\Demo\\Framework\\bin\\Debug");
        public static void Initialize()
        {
            Maximize();
            Goto("");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            webDriver.Dispose();
            webDriver.Quit();
        }

        public static void Maximize()
        {
            webDriver.Manage().Window.Maximize();
        }
    }
}
