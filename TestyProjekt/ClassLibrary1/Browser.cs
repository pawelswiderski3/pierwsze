using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace Wordpress
{
    internal class Browser
    {
        private static FirefoxDriver _driver;

        internal static IWebElement FindElementById(string id)
        {
            return _driver.FindElement(By.Id(id));
        }

        internal static void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        static Browser()
        {
            _driver = new FirefoxDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage()
                .Timeouts()
                .ImplicitWait = TimeSpan.FromMilliseconds(500);
        }

        internal static void Close()
        {
            _driver.Quit();
        }
    }
}