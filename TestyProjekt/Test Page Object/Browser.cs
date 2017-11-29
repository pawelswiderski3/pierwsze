using OpenQA.Selenium.Chrome;
using System;

namespace Test_Page_Object
{
    internal class Browser
    {
        private static ChromeDriver _driver;
        static Browser()
        {
            _driver = new ChromeDriver();
        }

        internal static void NavigateTo(String url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}