using System;

using System.Text;

using OpenQA.Selenium;

using OpenQA.Selenium.Firefox;

using OpenQA.Selenium.Support.UI;

using Xunit;

using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumTests

{

    public class Example : IDisposable

    {

        private const string SearchTextBoxId = "lst-ib";
        private const string Google = "https://www.google.pl";
        private const string SearchQuery = "Code Sprinters";
        private const string CodeSprintersPageTitle = "Code Sprinters -";

        private IWebDriver driver;
        private StringBuilder verificationErrors;



        public Example()

        {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts()
                .ImplicitWait = TimeSpan.FromMilliseconds(100);
            verificationErrors = new StringBuilder();

        }

        public void Dispose()
        {
            driver.Quit();
        }

        [Fact]

        public void NavigateToCodeSprinterSitetExample()

        {

            GoToGoogle();
            Search(SearchQuery);

            GoToSearchResultByPageTitle(CodeSprintersPageTitle);


            var element = driver.FindElement(By.LinkText("Poznaj nasze podejście"));
            Assert.NotNull(element);

            var elemnets = driver.FindElements(By.LinkText("Poznaj nasze podejście"));
            Assert.Single(elemnets);

            driver.FindElement(By.LinkText("Akceptuję")).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(11));
            wait.Until(ExpectedConditions.InvisibilityOfElementWithText(By.LinkText("Akceptuję"), "Akceptuję"));

            WaitForClickable(By.LinkText("Poznaj nasze podejście"), 5);

            driver.FindElement(By.LinkText("Poznaj nasze podejście")).Click();

            Assert.Contains("WIEDZA NA PIERWSZYM MIEJSCU", driver.PageSource);









        }

        private void Search(string Query)
        {
            var searchBox = GetSearchBox();
            searchBox.Clear();
            searchBox.SendKeys(Query);
            searchBox.Submit();
        }

        private void GoToSearchResultByPageTitle(string CodeSprintersPageTitle)
        {
            driver.FindElement(By.LinkText(CodeSprintersPageTitle)).Click();
        }

        private void GoToGoogle()
        {
            driver.Navigate().GoToUrl(Google);
        }

        private IWebElement GetSearchBox()
        {
            return driver.FindElement(By.Id(SearchTextBoxId));
        }

        protected void WaitForClickable(By by, int seconds)

        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            wait.Until(ExpectedConditions.ElementToBeClickable(by));

        }



        protected void waitForElementPresent(IWebElement by, int seconds)

        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }
    }
}
                //private void WaitForClickable(By by, int v)
                
      //      throw new NotImplementedException();
        

        //private bool IsElementPresent(By by)

        //{

        //    try

        //    {

        //        driver.FindElement(by);

        //        return true;

        //    }

        //    catch (NoSuchElementException)

        //    {

        //        return false;

        //    }

        //}



        //private bool IsAlertPresent()

        //{

        //    try

        //    {

        //        driver.SwitchTo().Alert();

        //        return true;

        //    }

        //    catch (NoAlertPresentException)

        //    {

        //        return false;

        //    }

        //}



        //private string CloseAlertAndGetItsText()

        //{

        //    try

        //    {

        //        IAlert alert = driver.SwitchTo().Alert();

        //        string alertText = alert.Text;

        //        if (acceptNextAlert)

        //        {

        //            alert.Accept();

        //        }

        //        else

        //        {

        //            alert.Dismiss();

        //        }

        //        return alertText;

        //    }

        //    finally

        //    {

        //        acceptNextAlert = true;

        //    }

        //}

