using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.ObjectModel;

namespace Test_Page_Object
{
    internal class Browser
    {
        private static FirefoxDriver _driver;

        internal static IWebElement FindElementById(string id)
        {
            return _driver.FindElement(By.Id(id));
        }

        static Browser()
        {
            _driver = new FirefoxDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage()
                .Timeouts()
                .ImplicitWait = TimeSpan.FromMilliseconds(500);
        }

       // internal static void WaitForInvisible(By, by)
      //  {
        //    new WebDriverWait(_driver,TimeSpan.FromSeconds(10))
        //    .until
      //  }

        internal static ReadOnlyCollection<IWebElement> FindByXpath(string xpath)
        {
            return _driver.FindElements(By.XPath(xpath));
        }

        internal static void NavigateTo(String url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        internal static void Close()
        {
            _driver.Quit();
        }
    }
}