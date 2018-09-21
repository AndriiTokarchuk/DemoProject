using System;
using System.Collections.Generic;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework
{
    public static class Extensions
    {
        public static bool Exists(this IWebElement element)
        {
            try
            {
                var text = element.Text;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

        public static string[] GetTextFromListOfElements(this IList<IWebElement> elementsList)
        {
            String[] allText = new String[elementsList.Count];
            int i = 0;
            foreach (IWebElement element in elementsList)
            {
                allText[i++] = element.Text;
            }

            return allText;
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        public static void SelectFromDropDown(this IWebElement dropDown, string value)
        {
            new SelectElement(dropDown).SelectByValue(value);
        }
    }
}
