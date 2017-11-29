using System;
using System.Linq;

namespace Test_Page_Object
{
    internal class MainPage

    {
        private static string Url = "https://autotestdotnet.wordpress.com/";

        internal static void GoTo()
        {
            Browser.NavigateTo(Url);
        }

        internal static void OpenFirstNote()
        {
            var element = Browser.FindByXpath("//article/header");
            element.First().Click();
        }
    }
}