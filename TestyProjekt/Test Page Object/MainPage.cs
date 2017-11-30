using PageObjcectTests;

using System;

using System.Linq;
using Test_Page_Object;

namespace PageObjectTests

{

    internal class MainPage

    {

        private static string Url = "https://autotestdotnet.wordpress.com/";

        internal static void Open()

        {

            Browser.NavigateTo(Url);

        }

        internal static void OpenFirstNote()

        {

            var elements = Browser.FindByXpath("//article/header");

            elements.First().Click();

        }

    }

}