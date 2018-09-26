using System.Configuration;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public static class Browser
    {
        private static readonly string pathToSolution = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private static readonly IWebDriver webDriver = new ChromeDriver(pathToSolution + ConfigurationManager.AppSettings["pathToDriver"]); 
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
            webDriver.Url = ConfigurationManager.AppSettings["URL"] + url;
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
